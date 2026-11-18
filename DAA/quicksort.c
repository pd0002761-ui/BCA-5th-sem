#include <stdio.h> 
void quick(int a[], int low, int high) 
{ 
int i = low, j = high, pivot = a[low], t; 
    while(i < j) 
    { 
        while(a[i] <= pivot && i < high) i++; 
        while(a[j] > pivot) j--; 
 
        if(i < j) 
        { 
            t = a[i]; a[i] = a[j]; a[j] = t; 
        } 
    } 
 
    a[low] = a[j]; 
    a[j] = pivot; 
 
    if(low < j-1) quick(a, low, j-1); 
    if(j+1 < high) quick(a, j+1, high); 
} 
 
int main() 
{ 
    int a[50], n, i; 
 
    printf("Enter number of elements: "); 
    scanf("%d", &n); 
 
    printf("Enter elements: "); 
    for(i = 0; i < n; i++) scanf("%d", &a[i]); 
 
    quick(a, 0, n-1); 
 
    printf("Sorted array: "); 
    for(i = 0; i < n; i++) printf("%d ", a[i]); 
 
    return 0; 
} 
