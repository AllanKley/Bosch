#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
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
