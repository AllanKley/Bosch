#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
Fa�a um programa que preencha tr�s vetores com cinco posi��es cada.

O primeiro vetor receber� os nomes de cinco funcion�rios;

O segundo e o terceiro vetor receber�o, respectivamente, o sal�rio e o tempo de servi�o de cada um.

� Mostre um primeiro relat�rio apenas com os nomes dos funcion�rios que n�o ter�o aumento;

� Mostre um segundo relat�rio apenas com os nomes e os novos sal�rios dos funcion�rios que ter�o aumento.

� Sabe-se que os funcion�rios que ter�o direito ao aumento s�o aqueles que possuem tempo de servi�o superior a cinco anos ou sal�rio inferior a R$ 800,00.

� Sabe-se, ainda, que, se o funcion�rio satisfizer �s duas condi��es anteriores, tempo de servi�o e sal�rio, o aumento ser� de 35%;

� Para o funcion�rio que satisfazer apenas � condi��o tempo de servi�o, o aumento ser� de 25%;

� Para aquele que satisfazer apenas � condi��o sal�rio, o aumento ser� de 15%.
*/





int main(int argc, char** argv) {
	
	int quant=5; // A quantidade pode ser alterada para facilitar os testes
	float salario[quant];
	int tempo[quant], count=0;
	char nome[quant][10];
	
	
	
	for(int i=0; i<quant; i++){  // PREENCHE OS DADOS
	
		system("cls");
		printf("Funcionario %d\n\n", i+1);
		
		printf("Nome: \n----  ");
		scanf("%s", &nome[i]);
		
		
		printf("Salario:\n----  ");
		scanf("%f", &salario[i]);
		
		printf("Tempo de servico:\n----  ");
		scanf("%d", &tempo[i]);
		
		printf("\n");
	}
	
	system("cls");
	printf("CONDICAO 1\n\n");
	count=0;
	for(int i=0; i<quant; i++){ // CONSICAO 1 (SALARIO E TEMPO)
	
		if(tempo[i]>5 && salario[i]<800){

			printf("Nome:  %s\n", nome[i]);
			printf("Salario reajustado:  %.1f", salario[i]*1.35);
			count=1;
			printf("\n\n");
		}
		
	}
	if(count==0){
			printf("Nenhum funcionario se encaixa nessa categoria\n");
			printf("\n\n");
	}
	printf("CONDICAO 2\n\n");
	count=0;
	for(int i=0; i<quant; i++){ // CONSICAO 2 (TEMPO)
	
		if(tempo[i]>5 && salario[i]>800){
			
			printf("Nome:  %s\n", nome[i]);
			printf("Salario reajustado:  %.1f", salario[i]*1.25);
			count=1;
			printf("\n\n");
		}
	}
	if(count==0){
			printf("Nenhum funcionario se encaixa nessa categoria\n");
			printf("\n\n");
	}
	printf("CONDICAO 3\n\n");
	count=0;
	for(int i=0; i<quant; i++){ // CONSICAO 3 (SALARIO)
	
		if(tempo[i]<5 && salario[i]<800){

			printf("Nome:  %s\n", nome[i]);
			printf("Salario reajustado:  %.1f", salario[i]*1.15);
			count=1;
			printf("\n\n");
		}
	}
	if(count==0){
			printf("Nenhum funcionario se encaixa nessa categoria\n");
			printf("\n\n");
	}
	printf("\CONDICAO 4\n\n");
	count=0;
	for(int i=0; i<quant; i++){ // CONSICAO 4 (NENHUMA CONDICAO)
	
		if(tempo[i]<5 && salario[i]>800){

			printf("Nome:  %s\n", nome[i]);
			printf("Salario sem reajuste:  %.1f", salario[i]);
			count=1;
			printf("\n\n");
		}
	
	
	}
	if(count==0){
			printf("Nenhum funcionario se encaixa nessa categoria\n");
			printf("\n\n");
	}
	return 0;
}
