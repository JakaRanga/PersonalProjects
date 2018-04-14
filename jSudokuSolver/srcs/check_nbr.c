/*
** JAKA PROJECT, 2018
** Sudoku Solver
** File description:
** Get info from map
*/

#include "../include/solver.h"

int	nb_in_line(int nb, int **map, int line)
{
	int	i = -1;

	while (++i < 9)
	{
		if (map[line][i] == nb)
			return (1);
	}
	return (0);
}

int	nb_in_col(int nb, int **map, int col)
{
	int	i = -1;

	while (++i < 9)
	{
		if (map[i][col] == nb)
			return (1);
	}
	return (0);
}

int	nb_in_block(int nb, int **map, int i, int j)
{
	int	k, l;

	k = i - (i % 3);
	l = j - (j % 3);
	i = k - 1;
	while (++i < k + 3)
	{
		j = l - 1;
		while (++j < l + 3)
			if (map[i][j] == nb)
				return (1);
	}
	return (0);
}
