#include <iostream>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <ctype.h>



/*
6) Faça um programa que simule um controle bancário.

Para tanto, devem ser lidos os códigos de dez contas e seus respectivos saldos.

Os códigos devem ser armazenados em um vetor de números inteiros (não pode haver mais de uma conta com o mesmo código) e os saldos devem ser armazenados em um vetor de números reais.

ü O saldo deverá ser cadastrado na mesma posição do código. Por exemplo, se a conta 504 foi armazenada na quinta posição do vetor de códigos, seu saldo deverá ficar na quinta posição do vetor de saldos.

ü Depois de fazer a leitura dos valores, deverá aparecer o seguinte menu na tela:

§ 1. Efetuar depósito

§ 2. Efetuar saque

§ 3. Consultar o ativo bancário, ou seja, o somatório dos saldos de todos os clientes

§ 4. Finalizar o programa

ü Para efetuar depósito, deve-se solicitar o código da conta e o valor a ser depositado.

ü Se a conta não estiver cadastrada, deverá aparecer a mensagem Conta não encontrada e voltar ao menu.

ü Se a conta existir, atualizar seu saldo;

ü Para efetuar saque, deve-se solicitar o código da conta e o valor a ser sacado.

ü Se a conta não estiver cadastrada, deverá aparecer a mensagem Conta não encontrada e voltar ao menu.

ü Se a conta existir, verificar se o seu saldo é suficiente para cobrir o saque. (Estamos supondo que a conta não possa ficar com o saldo negativo)

ü Se o saldo for suficiente, realizar o saque e voltar ao menu. Caso contrário, mostrar a mensagem Saldo insuficiente e voltar ao menu;

ü Para consultar o ativo bancário, deve-se somar o saldo de todas as contas do banco.

ü Depois de mostrar esse valor, voltar ao menu;

ü O programa só termina quando for digitada a opção 4 — Finalizar o programa.
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
