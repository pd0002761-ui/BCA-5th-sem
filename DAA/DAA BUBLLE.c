#include <stdio.h> 
#include <time.h> 
 int main() {    
  int a[100], n, i, j, temp;    
   clock_t start, end;    
    double cpu_time_used;      
	printf("Enter the number of elements: ");     
    scanf("%d", &n);      
	printf("Enter %d elements:\n", n);  
	   for (i = 0; i < n; i++)     {         
	   scanf("%d", &a[i]);     }     
	    // Start time     start = clock();      // Bubble Sort     
		for (i = 0; i < n - 1; i++)     {        
		 for (j = 0; j < n - i - 1; j++)         {             
		 if (a[j] > a[j + 1])             {                 
		 temp = a[j];                 
		 a[j] = a[j + 1];                 
		 a[j + 1] = temp; } } } 
		 // End time 
		 end = clock();
		  printf("Sorted array in ascending order:\n");
		  for(i = 0; i < n; i++) { 
		   printf("%d ", a[i]); }
		   cpu_time_used = (double)(end - start) / CLOCKS_PER_SEC; 
		   printf("\nExecution time: %f seconds\n", cpu_time_used); 
           return 0; 
       }