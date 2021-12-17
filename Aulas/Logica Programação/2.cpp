#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

struct Node{
 int num;
 struct Node *prox;
}; 
typedef struct Node node;

void inicia(node *LISTA);
int menu(void);
void opcao(node *LISTA, int op);
node *criaNo();
void insereFim(node *LISTA);
void insereInicio(node *LISTA);
void exibe(node *LISTA);
void libera(node *LISTA);
node *retiraInicio(node *LISTA);
node *retiraFim(node *LISTA);
node *aloca();

int main(void)
{
 node *LISTA = (node *) malloc(sizeof(node));
 if(!LISTA){
  printf("Sem memoria disponivel!\n");
  exit(1);
 }
 inicia(LISTA);
 int opt;
 
 do{
	system("cls");
  opt=menu();
  printf("\n");
  opcao(LISTA,opt);
  
 }while(opt);

 free(LISTA);
 return 0;
}

void inicia(node *LISTA)
{
 LISTA->prox = NULL;
}

int menu(void)
{
 int opt;
 
 printf("Escolha a opcao\n");
 printf("0. Sair\n");
 printf("1. Exibir lista\n");
 printf("2. Adicionar node no inicio\n");
 printf("3. Adicionar node no final\n");
 printf("4. Zerar lista\n");
 printf("5. Retirar do inicio\n");
 printf("6. Retirar do fim\n");
 printf("Opcao: "); scanf("%d", &opt);
 
 return opt;
}

void opcao(node *LISTA, int op)
{
	switch(op){
	  	case 0:
	  	 libera(LISTA);
	   	break;
	   
	  case 1:
	   	exibe(LISTA);
	   	printf("\nDigite qualquer tecla para continuar\n\n");
	 	getch();
	   break;
	  
	  case 2:
	   insereInicio(LISTA);
	   break;
	  
	  case 3:
	   insereFim(LISTA);
	   break;  
	   
	  case 4:
	   inicia(LISTA);
	   break;
   
	case 5:
		tmp = retiraInicio(LISTA);
		printf("Retirado: %3d\n\n", tmp->num);
		break;
	
	case 6:
		tmp = retiraFim(LISTA);
		printf("Retirado: %3d\n\n", tmp->num);
		break;
  
  default:
   printf("Comando invalido\n\n");
 }
}




int vazia(node *LISTA)
{
 if(LISTA->prox == NULL)
  return 1;
 else
  return 0;
}


node *aloca(){
	node *novo=(node *) malloc(sizeof(node));
	 if(!novo){
	  printf("Sem memoria disponivel!\n");
	  exit(1);
	 }
	 printf("Novo elemento: "); scanf("%d", &novo->num);
	 novo->prox = NULL;
	 return novo;
}




void insereFim(node *LISTA)
{
 
 node *novo=aloca();
 novo->	prox=NULL;
 
 if(vazia(LISTA))
  LISTA->prox=novo;
 else{
  node *tmp = LISTA->prox;
  
  while(tmp->prox != NULL)
   tmp = tmp->prox;
  
  tmp->prox = novo;
 }
}




void insereInicio(node *LISTA)
{
 node *novo=aloca();
 novo->	prox=NULL;

 node *oldHead = LISTA->prox;
 
 LISTA->prox = novo;
 novo->prox = oldHead;
}






void exibe(node *LISTA)
{
 if(vazia(LISTA)){
  printf("Lista vazia!\n\n");
  return ;
 }
 
 node *tmp;
 tmp = LISTA->prox;
 
 while( tmp != NULL){
  printf("%5d", tmp->num);
  tmp = tmp->prox;
 }
 printf("\n\n");
}





void libera(node *LISTA)
{
 if(!vazia(LISTA)){
  node *proxNode,
     *atual;
  
  atual = LISTA->prox;
  while(atual != NULL){
   proxNode = atual->prox;
   free(atual);
   atual = proxNode;
  }
 }
}








