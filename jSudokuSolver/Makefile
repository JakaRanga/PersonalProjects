SRCS	=	srcs/check_nbr.c		\
		srcs/complete_sudoku.c		\
		srcs/main.c			\
		srcs/print_map.c

OBJS	=	$(SRCS:.c=.o)

NAME	=	solver

CC	=	gcc -no-pie

CFLAGS	=	-Wall -Wextra -Werror



$(NAME):	$(OBJS)
		$(CC) $(OBJS) $(LDFLAGS) -o $(NAME) libs/*.a

all:		$(NAME)

re:		fclean all

clean:
		rm -f $(OBJS)

fclean:		clean
		rm -f $(NAME)

.PHONY:		all clean fclean re
