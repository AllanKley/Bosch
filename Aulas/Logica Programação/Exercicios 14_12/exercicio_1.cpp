#include <iostream>
#include <stdio.h>
#include <stdlib.h>



/*
1) Uma pequena loja de artesanato possui apenas um vendedor e comercializa dez tipos de objetos. O vendedor recebe, mensalmente, salário de R$ 545,00, acrescido de 5% do valor total de suas vendas.
Ø O valor unitário dos objetos deve ser informado e armazenado em um vetor;
Ø A quantidade vendida de cada peça deve ficar em outro vetor, mas na mesma posição.
Crie um programa que receba os preços e as quantidades vendidas, armazenando-os em seus respectivos vetores (ambos com tamanho dez).
Depois, determine e mostre:
ü um relatório contendo: quantidade vendida, valor unitário e valor total de cada objeto.
Ao final, deverão ser mostrados o valor geral das vendas e o valor da comissão que será paga ao vendedor;
ü o valor do objeto mais vendido e sua posição no vetor (não se preocupe com empates)..
*/





int main(int argc, char** argv) {
	int quant_produtos=10;
	int salario_bruto = 545, valor_unitario[quant_produtos], quant_vendas[quant_produtos];
	float salario_total, venda_total ;
	
	for(int i =0;i<quant_produtos;i++){  // CADASTRA OS PRODUTOS
		
		printf("Produto %d:", i+1);
	
		printf("\nValor unitario: ");
		scanf("%d", &valor_unitario[i]);
		
		printf("Quantidade vendida: ");
		scanf("%d", &quant_vendas[i]);
		printf("\n");

	}
	
	system("cls");
	for(int i =0; i<quant_produtos; i++){ // EXIBE OS PRODUTOS E SEUS RESPECTIVOS TOTAIS
		
		int total = valor_unitario[i] * quant_vendas[i];
		
		printf("\nProduto %d", i+1);
		printf("\nValor unitario: %d", valor_unitario[i]);
		printf("\nQuantidade vendida: %d", quant_vendas[i]);
		printf("\nTotal: %d", total);
		printf("\n");
	}
	
	for(int i =0; i<quant_produtos; i++){ // CALCULA O VALOR TOTAL DAS VENDAS
		
		if(i==0){
			venda_total = valor_unitario[i]*quant_vendas[i];
		}
		else{
			venda_total += valor_unitario[i]*quant_vendas[i];
		}
	}
	
	
	salario_total = salario_bruto+(venda_total*0.05); // CALCULA O SALARIO DO ENDEDOR BASEADO NAS VENDAS
	
	
	printf("\n\nSalario total vendedor: %.2f\n\n", salario_total);
	
	
	
	
	
	return 0;
}
