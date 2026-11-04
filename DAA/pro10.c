#include<stdio.h>
#include<limits.h>
int main()
{
	int p[20],m[20][20];
	int n,i,j,k,L,q;
	printf("Enter number of martices:");
	scanf("%d",&n);
	printf("Enter %d dimensions:",n+1);
	for(i=0;i<=n;i++)
	{
		scanf("%d",&p[i]);
		
	}
	for(i=1;i<=n;i++)
	{
		m[i][i]=0;
	}
	for(L=2;L<=n;L++)
	{
		for(i=1;i<=n-L+1;i++)
		{
			j=i+L-1;
			m[i][j]=INT_MAX;
			for(k=i;k<j;k++)
			{
				q=m[i][k]+m[k+1][j]+p[i-1]*p[k]*p[j];
				if(q<m[i][j])
				{
					m[i][j]=q;
			}
		}
	}
}
printf("\nmatrix Chain Multiplication\n");
printf("Minimun number of multiplications=%d\n",m[1][n]);
printf("\nDP Cost Table:\n");
for(i=1;i<=n;i++)
{
	for(j=1;j<=n;j++)
	{
		if(j<i)
		{
			printf("-");
			
		}
		else
		{
			printf("%4d",m[i][j]);
			
		}
	}
	printf("\n");
	
}
return 0;
}