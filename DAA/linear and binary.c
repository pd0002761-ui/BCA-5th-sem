#include <stdio.h> 
 
int main() 
{ 
    int a[20], n, i, key, pos = -1, low, high, mid; 
 
    printf("Enter number of elements: "); 
    scanf("%d", &n); 
 
    printf("Enter sorted elements: "); 
    for(i = 0; i < n; i++) 
        scanf("%d", &a[i]); 
 
    printf("Enter key: "); 
    scanf("%d", &key); 
 
    for(i = 0; i < n; i++) 
        if(a[i] == key) { pos = i; break; } 
 
    if(pos != -1)  
printf("Linear: Found at %d\n", pos); 
    else  
printf("Linear: Not found\n"); 
 
    low = 0; high = n - 1; pos = -1; 
 
    while(low <= high) 
    { 
        mid = (low + high) / 2; 
        if(a[mid] == key) { pos = mid; break; } 
        if(a[mid] < key) low = mid + 1; 
        else high = mid - 1; 
    } 
 
  if(pos != -1)  
printf("Binary: Found at %d\n", pos); 
 else  
printf("Binary: Not found\n"); 
 
    return 0; 
} 

