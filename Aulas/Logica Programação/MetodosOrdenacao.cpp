#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>

void embaralhar(int *arr, int size);
void printArray(int arr[], int size);
void insertionSort(int arr[], int size);
void selectionSort (int arr[],int size);
void bubbleSort (int arr[], int size);

int main(){
	
	int size = 5;
	int menu=0;
    int arr[size];
	
	while(menu!=4){
		system("cls");
	 	embaralhar(arr,size);
	 	
	 	printf("VETOR EMBARALHADO: ");
	    printArray(arr, size);
	    printf("\n");
	    printf("----------------------\n");
	    printf("|        Menu:       |\n");
	    printf("----------------------\n");
	    printf("| 1) Insertion Sort  |\n");
	    printf("| 2) Selection Sort  |\n");
	    printf("| 3) Bubble Sort     |\n");
	    printf("| 4) Sair            |\n");
	    printf("----------------------\n\n");
	    printf("---> ");
	    scanf("%d", &menu);
	    
	    if(menu==1){
	    	system("cls");
	    	insertionSort(arr, size);
	    	printf("\nDigite qualquer tecla para continuar\n");  
			getch(); 
			
		}else if(menu==2){
			system("cls");
			selectionSort(arr, size);
			printf("\nDigite qualquer tecla para continuar\n");  
			getch(); 
		}else if(menu==3){
			system("cls");
			bubbleSort(arr, size);
			printf("\nDigite qualquer tecla para continuar\n");  
			getch(); 
		}
	}
	
    
  
    return 0;
}


void embaralhar(int *arr, int size)
{
	srand(time(NULL));

    for(int i = 0; i < size; i++){
    	arr[i] = rand() % 100 + 1;
	}
        
} 

void printArray(int arr[], int size){
    int i;
    for (i = 0; i < size; i++)
        printf("%d ", arr[i]);
    printf("\n\n");
}


void insertionSort(int arr[], int size){
    int i, j, key;
    for (i = 1; i < size; i++) {

    	printf(" ----------- Passo %d -----------\n\n", i);
    	printf("->->-> Antes <-<-<-\n\n");
    	printArray(arr, size);

        key = arr[i];
        j = i - 1;
        
        if(j >= 0 && arr[j] > key){
        	printf("->->-> Entrou na ordenacao <-<-<-\n\n");
		}
        
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j = j - 1;
            
            printArray(arr, size);
        }
        arr[j + 1] = key;
		
		/* Imprime o vetor ordenado */
        printf("->->-> Depois <-<-<-\n\n");
        printArray(arr, size);
    	
    }
}

void selectionSort (int arr[],int size) {
  int i, j, min, aux;
  
  
  for (i = 0; i < (size - 1); i++) {
  		
  		printf(" ----------- Passo %d -----------\n\n", i+1);
    	printf("->->-> Antes <-<-<-\n\n");
    	printArray(arr, size);
  		
  		
	    /* O minimo é o primeiro número não ordenado ainda */
	    min = i;
	    for (j = i+1; j < size; j++) {
		    
			/* Caso tenha algum numero menor ele faz a troca do minimo*/
		    if (arr[j] < arr[min]) {
		  		min = j;
	    	}
	    }
	    
		/* Se o minimo for diferente do primeiro numero não ordenado ele faz a troca para ordena-los*/
	    if (i != min) {
	    	aux = arr[i];
	    	arr[i] = arr[min];
	    	arr[min] = aux;
	    }
	    
	    /* Imprime o vetor ordenado */
  		printf("->->-> Depois <-<-<-\n\n");
  		printArray(arr, size);
  }
  
  
  
  printf ("\n");
}


void bubbleSort(int arr[], int size)
{
    int i, j, temp;
    for (i = 0; i < size-1; i++){
    	printf(" ++++++++++++++ Passada %d ++++++++++++++\n\n", i+1);
    	
    	
    	for (j = 0; j < size-i-1; j++){
    		printf(" ----------- Passo %d -----------\n\n", j+1);
    		printf("->->-> Antes <-<-<-\n\n");
    		printArray(arr, size);
    		
        	if (arr[j] > arr[j+1]){
        	
        		int temp = arr[j];
    			arr[j] = arr[j+1];
   				arr[j+1] = temp;
		
			}
			
			printf("->->-> Depois <-<-<-\n\n");
  			printArray(arr, size);
		}
		
	}    
}
