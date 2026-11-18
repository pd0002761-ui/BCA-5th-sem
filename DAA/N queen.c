#include <stdio.h> 
#include <stdlib.h> 
int x[20], n; 
int place(int k, int i) 
{ 
    int j; 
    for(j = 1; j < k; j++) 
        if(x[j] == i || abs(x[j] - i) == abs(j - k)) 
            return 0; 
    return 1; 
} 
 
void queen(int k) 
{ 
    int i; 
    for(i = 1; i <= n; i++) 
    { 
        if(place(k, i)) 
        { 
            x[k] = i; 
            if(k == n) 
            { 
                for(i = 1; i <= n; i++) 
                    printf("%d ", x[i]); 
                printf("\n"); 
            } 
            else 
                queen(k + 1); 
        } 
    } 
} 
 
int main() 
{ 
    printf("Enter number of queens: "); 
    scanf("%d", &n); 
    queen(1); 
    return 0; 
} 
