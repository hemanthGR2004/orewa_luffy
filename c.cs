
#include<stdio.h> // printf()
#include<stdlib.h> // exit()
#include<sys/types.h> // pid_t
#include<sys/wait.h> // wait() #include<unistd.h> // fork
int main(int argc, char **argv)
pid_t pid; pid — fork(); if(pid—0)
printf("lt is the child process and pid is  int i=O; for(i=O;i<8;i++)
printf("%d\n",i);
exit(());
else if(pid > O)
printf("lt is the parent process and pid is %d\n",getpid()); int status; wait(&status); printf("Child is reaped\n");
else
printf("Error in forking..\n"); exit(EXIT FAILURE);
