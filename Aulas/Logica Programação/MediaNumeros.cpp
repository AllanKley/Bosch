#include <iostream>
#include <stdlib.h>
#include <stdio.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int *aloca(int num);
float media(int *numbers, int num);
void exibe(int *numbers, int num);

int main(int argc, char** argv) {
	
	int sair=1, num, *numeros;
	
	
	
	while (sair!=0){
		
		system("cls");
		
		printf("Quantos numeros deseja digitar?\n------\t");
		scanf("%d", &num);
		
		numeros = aloca(num);
		
		printf("\nA media dos numeros digitados eh: %f\n\n", media(numeros, num));
		
		printf("Numeros digitados: ");
		exibe(numeros, num);
		
		printf("\n\nDigite 1 para continuar e 0 para sair: ");
		scanf("%d", &sair);
		free(numeros);
	}
	
	return 0;
}


int *aloca(int num){
	int count, *numbers;
	numbers = (int *) malloc(num*sizeof(int));
	printf("\n");
	for(count =0; count<num; count++){
		printf("Numero [%d]", count+1);
		scanf("%d", &numbers[count]);
	}
	return numbers;
}

float media(int *numbers, int num){
	
	float media=0.0;
	int count;
	for(count = 0; count <num; count++){
		media += numbers[count];
	}
	return media/num;
}

void exibe(int *numbers, int num){
	int count;
	for(count = 0; count <num; count++){
		printf("%d  ", numbers[count]);
	}
}
