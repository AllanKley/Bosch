#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
6) Fa�a um programa que simule um controle banc�rio.

Para tanto, devem ser lidos os c�digos de dez contas e seus respectivos saldos.

Os c�digos devem ser armazenados em um vetor de n�meros inteiros (n�o pode haver mais de uma conta com o mesmo c�digo) e os saldos devem ser armazenados em um vetor de n�meros reais.

� O saldo dever� ser cadastrado na mesma posi��o do c�digo. Por exemplo, se a conta 504 foi armazenada na quinta posi��o do vetor de c�digos, seu saldo dever� ficar na quinta posi��o do vetor de saldos.

� Depois de fazer a leitura dos valores, dever� aparecer o seguinte menu na tela:

� 1. Efetuar dep�sito

� 2. Efetuar saque

� 3. Consultar o ativo banc�rio, ou seja, o somat�rio dos saldos de todos os clientes

� 4. Finalizar o programa

� Para efetuar dep�sito, deve-se solicitar o c�digo da conta e o valor a ser depositado.

� Se a conta n�o estiver cadastrada, dever� aparecer a mensagem Conta n�o encontrada e voltar ao menu.

� Se a conta existir, atualizar seu saldo;

� Para efetuar saque, deve-se solicitar o c�digo da conta e o valor a ser sacado.

� Se a conta n�o estiver cadastrada, dever� aparecer a mensagem Conta n�o encontrada e voltar ao menu.

� Se a conta existir, verificar se o seu saldo � suficiente para cobrir o saque. (Estamos supondo que a conta n�o possa ficar com o saldo negativo)

� Se o saldo for suficiente, realizar o saque e voltar ao menu. Caso contr�rio, mostrar a mensagem Saldo insuficiente e voltar ao menu;

� Para consultar o ativo banc�rio, deve-se somar o saldo de todas as contas do banco.

� Depois de mostrar esse valor, voltar ao menu;

� O programa s� termina quando for digitada a op��o 4 � Finalizar o programa.
*/





int main(int argc, char** argv) {
	
	int quant=10; // A quantidade pode ser alterada para facilitar os testes
	int sair=0,rept;
	int codigo[quant], verif;
	float saldo[quant], ativo_banc=0, deposito, saque;
	
	for(int i=0; i<quant; i++){  // PREENCHE OS DADOS
		rept=0;
		printf("Cadastro %d\n", i+1);
		
		printf("Codigo: ");
		scanf("%d", &verif);
		
		if(i==0){
			codigo[i]=verif;
			printf("Saldo: ");
			scanf("%f", &saldo[i]);
		}else{
			for(int j=0; j<i; j++){
				if(verif == codigo[j]){
					rept=1;
				}
			}
			if(rept==0){
				codigo[i]=verif;
				printf("Saldo: ");
				scanf("%f", &saldo[i]);
			}else{
				printf("Codigo repetido!!");
				i--;
			}
		}
		
		
		 
		printf("\n");
	}
	
	
	
	while(sair != 5){ // MENU
		
		system("cls");
		
		printf("MENU:\n");
		printf("\n1) Deposito");
		printf("\n2) Saque");
		printf("\n3) Consultar ativo bancario");
		printf("\n4) Consultar conta");
		printf("\n5) Sair\n\n----  ");
		scanf("%d", &sair);
		
	
		
		if(sair==1){  // DEPOSITO
			rept=0;
			system("cls");
			
			printf("Digite o codigo da conta que deseja depositar: ");
			scanf("%d", &verif);
		
			for(int i=0; i<quant; i++){
				if(verif == codigo[i]){
					rept=1;
				}
			}
			
			if(rept==0){
				printf("Conta inesistente!!");
				
			}else{
				printf("Quanto deseja depositar?\n----  ");
				scanf("%f", &deposito);
				for(int i=0; i<quant; i++){
					if(verif == codigo[i]){
						saldo[i]+=deposito;
					}
				}
			}
			printf("\n\nDigite qualquer tecla para continuar\n");  
			getch();
		
		
		
		}else if(sair==2){ // SAQUE
			rept=0;
			system("cls");
			
			printf("Digite o codigo da conta que deseja sacar: ");
			scanf("%d", &verif);
		
			for(int i=0; i<quant; i++){
				if(verif == codigo[i]){
					rept=1;
				}
			}
			
			if(rept==0){
				printf("Conta inesistente!!");
				
			}else{
				printf("Quanto deseja sacar?\n----  ");
				scanf("%f", &saque);
				
				for(int i=0; i<quant; i++){
					if(verif == codigo[i]){
						if(saldo[i]-saque>0){
							saldo[i]-=saque;
							printf("\n\nValor sacado\n");
						}else{
							printf("\n\nSem saldo\n");	
						}
					}
				}
			}
			printf("\n\nDigite qualquer tecla para continuar\n");  
			getch();
			
			
		}else if(sair==3){ // ATIVO BANCARIO
			system("cls");
			ativo_banc=0;
			for(int i=0; i<quant; i++){
				ativo_banc+=saldo[i];
			}
			printf("O ativo bancario atual eh: %.1f", ativo_banc);
			printf("\n\nDigite qualquer tecla para continuar\n");  
			getch();
			
			
		}else if(sair==4){ // CONSULTAR SALDO
			rept=0;
			system("cls");
			printf("Digite o codigo da conta que deseja consultar: ");
			scanf("%d", &verif);
		
			for(int i=0; i<quant; i++){
				if(verif == codigo[i]){
					printf("Saldo: %.1f", saldo[i]);
					rept=1;
				}
			}
			
			if(rept==0){
				printf("Conta inesistente!!");
				
			}else{
				
			}
			printf("\n\nDigite qualquer tecla para continuar\n");  
			getch();	
		}
		
		
		printf("\n\n");
	}
	
	
	
	return 0;
}
