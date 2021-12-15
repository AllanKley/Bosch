#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
Faça um programa que preencha três vetores com cinco posições cada.

O primeiro vetor receberá os nomes de cinco funcionários;

O segundo e o terceiro vetor receberão, respectivamente, o salário e o tempo de serviço de cada um.

ü Mostre um primeiro relatório apenas com os nomes dos funcionários que não terão aumento;

ü Mostre um segundo relatório apenas com os nomes e os novos salários dos funcionários que terão aumento.

ü Sabe-se que os funcionários que terão direito ao aumento são aqueles que possuem tempo de serviço superior a cinco anos ou salário inferior a R$ 800,00.

ü Sabe-se, ainda, que, se o funcionário satisfizer às duas condições anteriores, tempo de serviço e salário, o aumento será de 35%;

ü Para o funcionário que satisfazer apenas à condição tempo de serviço, o aumento será de 25%;

ü Para aquele que satisfazer apenas à condição salário, o aumento será de 15%.
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
