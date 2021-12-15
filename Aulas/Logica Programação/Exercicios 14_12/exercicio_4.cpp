#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
4) Faça um programa que preencha um vetor com os modelos de cinco carros (exemplos de modelos: Fusca, Gol, Vectra etc).

Carregue outro vetor com o consumo desses carros, isto é, quantos quilômetros cada um deles faz com um litro de combustível.

Calcule e mostre:

ü O modelo de carro mais econômico; e

ü Quantos litros de combustível cada um dos carros cadastrados consome para percorrer uma distância de 1.000 km.
*/





int main(int argc, char** argv) {
	
	int quant=5; // A quantidade pode ser alterada para facilitar os testes
	int consumo[quant], menor_id, menor;
	char modelo[quant][10];
	
	
	
	for(int i=0; i<quant; i++){  // PREENCHE OS DADOS
	
		system("cls");
		printf("Automovel %d\n\n", i+1);
		
		printf("Modelo: \n----  ");
		scanf("%s", &modelo[i]);
		
		
		printf("Consumo:\n----  ");
		scanf("%d", &consumo[i]);
		
		printf("\n");
	}
	
	
	for(int i=0; i<quant; i++){ // ENCONTRA O AUTOMOVEL DE MENOR CONSUMO
		if(i==0){
			menor = consumo[i];
			menor_id = i;
		}else{
			if(consumo[i]<menor){
				menor = consumo[i];
				menor_id = i;	
			}
		}
	}
	
	system("cls");
	printf("O automovel com menor consumo eh:\n\nModelo: %s\nConsumo: %d", modelo[menor_id], consumo[menor_id]);
	
	printf("\n\nDigite qualquer tecla para continuar\n");  
	getch(); 
	
	system("cls");
	
	
	printf("CONSUMO GERAL DOS AUTOMOVEIS (1.000 km)\n\n"); // MOSTRA OS RESULTADOS GERAIS
	for(int i=0; i<quant; i++){
		
		printf("\n\nAutomovel %d\n\n", i+1);
		
		printf("Modelo:  %s\n", modelo[i]);

		printf("Consumo:  %d", consumo[i]*1000);
		
	}
	
	return 0;
}
