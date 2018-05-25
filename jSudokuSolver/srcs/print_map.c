/*
** JAKA PROJECT, 2018
** Suduku Solver
** File description:
** Print sudoku
*/

#include "../include/solver.h"

void	print_map(int **map)
{
	int	i, j;

	i = -1;
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
		write(1, "\n", 1);
	}
	my_printf("+-----+-----+-----+\n");

}
