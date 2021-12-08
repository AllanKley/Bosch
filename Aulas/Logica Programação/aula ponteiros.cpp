#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	int num1 =1, num2 = 2;
	char let1 = 'a', let2 = 'b';
	float f1=4.2, f2=4.3;
	double d1=4.2, d2=4.2;
	
	int teste[10];
	
	printf("Tamanho:\nInt:\t%d\nChar:\t%d\nFloat:\t%d\nDouble:\t%d\n\n", sizeof(int), sizeof(char),sizeof(float), sizeof(double));
	
	printf("Inteiros: \nValores - %d , %d \nEnderecos - %d , %d \nTamanhos - %d , %d\n\n", num1, num2, &num1, &num2, sizeof(num1), sizeof(num2));
	printf("Letras: \nValores - %c , %c \nEnderecos - %d , %d \nTamanhos - %d , %d\n\n", let1, let2, &let1, &let2, sizeof(let1), sizeof(let2));
	printf("Float: \nValores - %.1f , %.1f \nEnderecos - %d , %d \nTamanhos - %d , %d\n\n", f1, f2, &f1, &f2, sizeof(f1), sizeof(f2));
	printf("Double: \nValores - %.1f , %.1f \nEnderecos - %d , %d \nTamanhos - %d , %d\n\n", d1, d2, &d1, &d2, sizeof(d1), sizeof(d2));
	
	printf("imprimindo o vetor 'teste': %d\n", teste);
	printf("imprimindo o endereco do primeiro elemento: %d\n", &teste[0]);
	printf("imprimindo o tamanho ocupado pelo vetor: %d\n", sizeof(teste));
	
	
	
	
	int n1=0;
	double n2=0;
	int *p1=NULL;
	double *p2=NULL;
	
	
	p1 = &n1;
	p2 = &n2;
	
	printf("\n\nEndereco com &:\nn1: %d\nn2: %d\n\n", &n1, &n2);
	printf("Endereco com ponteiro:\nn1: %d\nn2: %d\n\n", p1, p2);
	
	p1 = NULL;
	p2 = NULL;
	
	printf("Endereco com ponteiro limpo:\nn1: %d\nn2: %d\n", p1, p2);
		
		
		
		
		
		
		
		
	int x, y, z;
	int *px=NULL, *py=NULL, *pz=NULL;
	
	px = &x;
	py = &y;
	pz = &z;
	
	printf("\ndigite o primeiro numero: ");
	scanf("%d", px);
	printf("digite o segundo numero: ");
	scanf("%d", py);
	printf("digite o terceiro numero: ");
	scanf("%d", pz);
	
	printf("\nx: %d\ny: %d\nz: %d\n", *px, *py, *pz);
	printf("\nx: %d\ny: %d\nz: %d\n", x, y, z);
	
	
	
		
	return 0;
}
