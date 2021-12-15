#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
3) Faça um programa que efetue reserva de passagens aéreas de uma companhia. O programa deverá ler informações sobre os voos (número, origem e destino) e o número de lugares disponíveis para doze aviões (um vetor para cada um desses dados).
Depois da leitura, o programa deverá apresentar um menu com as seguintes opções:
ü consultar;
ü efetuar reserva; e
ü sair.
Quando a opção escolhida for Consultar, deverá ser disponibilizado mais um menu com as seguintes opções:
ü por número do voo;
ü por origem; e
ü por destino.
Quando a opção escolhida for Efetuar reserva, deverá ser perguntado o número do voo em que a pessoa deseja viajar.
O programa deverá dar as seguintes respostas:
ü reserva confirmada — caso exista o voo e lugar disponível, dando baixa nos lugares disponíveis;
ü voo lotado — caso não exista lugar disponível nesse voo;
ü voo inexistente — caso o código do voo não exista.
A opção Sair é a única que permite encerrar a execução do programa. Sendo assim, após cada operação de consulta ou reserva, o programa volta ao menu principal
*/





int main(int argc, char** argv) {
	
	int quant=2; // A quantidade pode ser alterada para facilitar os testes
	int sair=0, consulta=0, voo, reserva=0;
	int numero[quant], lugares[quant];
	char origem[quant][10],destino[quant][10], temp[10];
	
	for(int i=0; i<quant; i++){  // PREENCHE OS DADOS
	
		printf("Aviao %d\n", i+1);
		
		printf("Digite o numero do voo: ");
		scanf("%d", &numero[i]);
		
		printf("Digite a origem: ");
	
		scanf("%s", &origem[i]);
		
		printf("Digite o destino: ");
		scanf("%s", &destino[i]);
		
		printf("Digite o numero de lugares: ");
		scanf("%d", &lugares[i]);
		printf("\n");
	}
	

	
	while(sair != 3){
		
		system("cls");
		
		printf("MENU:\n");
		printf("\n1) Consultar");
		printf("\n2) Reservar");
		printf("\n3) Sair\n\n----  ");
		scanf("%d", &sair);
		
	
		
		if(sair==1){ 
		
			system("cls");
			
			printf("CONSULTAR POR:\n");
			printf("\n1) Numero do voo");
			printf("\n2) Origem");
			printf("\n3) Destino\n\n----  ");
			scanf("%d", &consulta);
			
			system("cls");
			
			if(consulta==1){ //CONSULTA POR NUMERO DO VOO
				
				printf("\nDigite o numero do voo: \n---- ");
				scanf("%d", &voo);
				
				for(int i=0; i<quant; i++){
					if(voo==numero[i]){
						printf("\nNumero do voo: %d", numero[i]);
						printf("\nOrigem: %s", origem[i]);
						printf("\ndestino: %s", destino[i]);
						printf("\nVagas: %d", lugares[i]);
						printf("\n");
					}
				}
				
				
			}else if(consulta==2){  // CONSULTA POR ORIGEM 
				
				printf("\nDigite a origem do voo: \n---- ");
			 	scanf("%s", &temp);
			
				for(int i=0; i<quant; i++){
					if(strcmp(temp,origem[i]) == 0){
						printf("\nNumero do voo: %d", numero[i]);
						printf("\nOrigem: %s", origem[i]);
						printf("\ndestino: %s", destino[i]);
						printf("\nVagas: %d", lugares[i]);
						printf("\n");
					}
				}
			
			
				
			}else if(consulta==3){ // CONSULTA POR DESTINO
				
				printf("\nDigite a origem do voo: \n---- ");
				scanf("%s", &temp);
				
				for(int i=0; i<quant; i++){
					if(strcmp(temp,destino[i]) == 0){
						printf("\nNumero do voo: %d", numero[i]);
						printf("\nOrigem: %s", origem[i]);
						printf("\ndestino: %s", destino[i]);
						printf("\nVagas Disponiveis: %d", lugares[i]);
						printf("\n");
					}
				}	
			}
			
			printf("\nDigite qualquer tecla para continuar\n");  
			getch(); 
			
		}else if(sair==2){ // RESERVA
			system("cls");
			reserva=0;
			printf("\nQual o numero do seu voo?\n---- ");
			scanf("%d", &voo);
			
			for(int i=0; i<quant; i++){
				if(voo==numero[i]){
					if(lugares[i]!=0){
						lugares[i]-=1;
						printf("\nReservado");
					}else{
						printf("\nSem vagas");
					}
					reserva=1;
				}
				
			}
			if(reserva==0){
				printf("\nVoo nao encontrado");
				
			
			}
			
			printf("\n\nDigite qualquer tecla para continuar\n");  
			getch(); 
			
		}
		printf("\n\n");
	}
	
	
	
	return 0;
}
