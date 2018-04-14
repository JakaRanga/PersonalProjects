/*
** solver.h for solver.h in /home/jakaranga/delivery/My_Projects_Repo/sudoku_solver
** 
** Made by JakaRanga
** Login   <jeremy.bouton@epitech.eu>
** 
** Started on  Sat Jun 17 02:52:33 2017 JakaRanga
** Last update Sat Jun 17 18:01:00 2017 JakaRanga
*/

#ifndef SOLVER_H_
# define SOLVER_H_

#include <unistd.h>
#include <stdio.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <fcntl.h>

void	print_map(int**);
void	free_tab(char**);
void	free_2d_int(int**, int, int);
int	my_printf(char*, ...);
int	nb_in_line(int, int**, int);
int	nb_in_col(int, int**, int);
int	nb_in_block(int, int**, int, int);
int	is_valid(int**, int);
char	**wordtab(char*, char);

#endif /* !SOLVER_H_ */
