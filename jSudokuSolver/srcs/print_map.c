/*
** print_map.c for print map in /home/jakaranga/delivery/My_Projects_Repo/sudoku_solver
** 
** Made by JakaRanga
** Login   <jeremy.bouton@epitech.eu>
** 
** Started on  Sat Jun 17 03:45:47 2017 JakaRanga
** Last update Sat Jun 17 14:57:39 2017 JakaRanga
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
