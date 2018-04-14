/*
** JAKA PROJECT, 2018
** Sudoku solver
** File description:
** main
*/

#include "../include/solver.h"

char	**write_map(char *fname)
{
	struct stat	info;
	char		**map;
	char		*buff;
	int		fd, tmp;

	stat(fname, &info);
	if (info.st_size != 90 || (fd = open(fname, O_RDONLY)) <= 0)
		return (NULL);
	if ((buff = malloc(sizeof(char) * 91)) == NULL)
		return (NULL);
	if ((tmp = read(fd, buff, info.st_size)) < 90)
		return (NULL);
	buff[tmp - 1] = '\0';
	if ((map = wordtab(buff, '\n')) == NULL)
		return (NULL);
	free(buff);
	return (map);
}

int	**fill_map(char *fname)
{
	int	i, j;
	int	**map;
	char	**tmp;
  
	if ((tmp = write_map(fname)) == NULL)
		return (NULL);
	if ((map = malloc(sizeof(int*) * 10)) == NULL)
		return (NULL);
	map[9] = NULL;
	i = -1;
	while (++i != 9)
	{
		if ((map[i] = malloc(sizeof(int) * 10)) == NULL)
			return (NULL);
		map[i][9] = -1;
		j = -1;
		while (++j != 9)
		{
			if (tmp[i][j] >= '0' && tmp[i][j] <= '9')
				map[i][j] = tmp[i][j] - 48;
			else
				return (NULL);
		}
	}
	free_tab(tmp);
	return (map);
}

int	main(int ac, char** av)
{
	int	**map;
  
	if (ac != 2)
		return (my_printf("No argument\n"), 83);
	if ((map = fill_map(av[1])) == NULL)
		return (my_printf("%s: Not a good file\n", av[1]), 84);
	my_printf("Sudoku\n");
	print_map(map);
	if (is_valid(map, 0) != 0)
		return (my_printf("Can't be solved\n"), 85);
	my_printf("Solved!\n");
	print_map(map);
	free_2d_int(map, 10, 10);
	return (0);
}
