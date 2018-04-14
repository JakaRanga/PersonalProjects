/*
** JAKA PROJECT, 2018
** Suduku Solver
** File description:
** Print sudoku
*/

#include "../include/solver.h"

void	print_map(int **map)
{
	char	c;
	int	i, j;

	i = -1;
	c = '\n';
	while (++i != 9)
	{
		j = -1;
		if (i % 3 == 0)
			my_printf("+-----+-----+-----+\n");
		while (++j != 9)
		{
			if (j % 3 == 0)
				my_printf("|");
			else
				my_printf(".");
			my_printf("%i", map[i][j]);
		}
		my_printf("|");
		write(1, &c, 1);
	}
	my_printf("+-----+-----+-----+\n");

}
