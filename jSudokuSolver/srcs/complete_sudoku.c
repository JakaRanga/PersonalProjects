/*
** JAKA PROJECT, 2018
** Sudoku solver
** File description:
** check the map
*/

#include "../include/solver.h"

int	is_valid(int **map, int pos)
{
	int	i, j, k;

	if (pos == 81)
		return (0);
	i = pos / 9, j = pos % 9;
	if (map[i][j] != 0)
		return (is_valid(map, pos + 1));
	k = 0;
	while (++k <= 9)
	{
		if (nb_in_line(k, map, i) == 0 && nb_in_col(k, map, j) == 0 &&
		    nb_in_block(k, map, i, j) == 0)
		{
			map[i][j] = k;
			if (is_valid(map, pos + 1) == 0)
				return (0);
		}
	}
	map[i][j] = 0;
	return (1);
}
