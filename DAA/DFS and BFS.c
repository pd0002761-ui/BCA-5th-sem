#include <stdio.h> 
int a[10][10], v[10], n; 
void DFS(int s) 
{ 
int i; 
    printf("%d ", s); 
    v[s] = 1; 
    for(i=0; i<n; i++) 
        if(a[s][i] && !v[i]) DFS(i); 
} 
 
void BFS(int s) 
{ 
    int q[10], f=0, r=0, i; 
    for(i=0; i<n; i++) v[i]=0; 
    q[r++]=s; v[s]=1; 
 
    while(f<r) 
    { 
        s=q[f++]; 
        printf("%d ",s); 
        for(i=0; i<n; i++) 
            if(a[s][i] && !v[i]) 
                v[i]=1, q[r++]=i; 
    } 
} 
 
int main() 
{ 
    int i,u,w,e,s; 
    printf("Enter number of vertices: "); 
    scanf("%d",&n); 
    printf("Enter number of edges: "); 
    scanf("%d",&e); 
 
    for(i=0;i<e;i++) 
    { 
        printf("Enter edge (u v): "); 
        scanf("%d%d",&u,&w); 

      a[u][w]=a[w][u]=1; 
    }
     printf("Enter starting vertex: "); 
     scanf("%d",&s); 
     printf("DFS: "); DFS(s); 
     printf("\nBFS: "); BFS(s); 
     return 0; 
   } 
