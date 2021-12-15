#include <iostream>
#include <stdio.h>
#include <stdlib.h>



/*
2) Faça um programa que, no momento de preencher um vetor com oito números inteiros, já os armazene de forma crescente.
*/





int main(int argc, char** argv) {
	
	int quant=8, temp, count=0;
	int numeros[quant];
	
	for(int i=0;i<quant;i++){
		printf("Digite o %d valor: ", i+1);
		scanf("%d", &temp);
		
		
		if(i==0){ // COLOCA O PRIMEIRO NUMERO
			numeros[i]=temp;
			
		}else{
			count =0;
			for(int j=i;j>=0;j--){
				
				if(j==0){ // CASO O NUMERO SEJA MENOR QUE TODOS OS OUTROS
					for (int k=0; k<count; k++){
						numeros[i-k] = numeros[i-k-1];
					}
					numeros[i-count]=temp;
					break;
				}
				
				else if(temp<numeros[j-1]){ // CASO O NUMERO SEJA MENOR QUE O ANTERIOR - PARTE 1
					count++;
					
					
				}else if(count == 0){ // CASO O NUMERO SEJA MAIOR QUE TODOS
					numeros[j]=temp;
					break;
					
					
				}else{ // CASO O NUMERO SEJA MENOR QUE O ANTERIOR - PARTE 2
					for (int k=0; k<count; k++){
						numeros[i-k] = numeros[i-k-1];
					}
					numeros[i-count]=temp;
					break;
				}
			}
			
			
		}
		
		printf("Vetor atual: "); // PRINTA O VETOR SENDO ORDENADO
		for(int j=0;j<=i;j++){
			printf(" %d ", numeros[j]);
		}
		printf("\n\n");
	}
	
	
	return 0;
}
