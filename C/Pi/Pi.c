#include<stdio.h> // define the header file 
#include<stdlib.h>
#include"integer-input.h" 
int main()   // define the main function  
{  
    puts("Enter the number of iterations:");
	int x;
    getIntegerFromStdin(&x);
	printf("Number of iterations: %d\n", x);
    float piOut = 3.0;
    float add = 0;
    float sign = 1;
    for (int i = 1; i <= x; i++)
    {
        float doubleI = 2 * i;
        float seq = 4 / (doubleI * (doubleI + 1) * (doubleI + 2)) * sign;
        add = add + seq;
        sign = sign * (-1);        
    }       
	float outPut = piOut + add;
    printf("Pi after %d iterations: %f", x, outPut);
    return 0;     
}  