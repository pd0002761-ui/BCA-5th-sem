#include<stdio.h>
int main()
{
	int n,i,j;
	float p[20],w[20],r[20],W,profit=0,t;
	printf("Enter number of objects:");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("Enter object %d weight:",i+1);
		scanf("%f",&w[i]);
		printf("Enter object %d profit:",i+1);
		scanf("%f",&p[i]);
		r[i]=p[i]/w[i];
    }
    printf("Enter capacity:");
    scanf("%f",&W);
    for(i=0;i<n-1;i++)
    for(j=i+1;j<n;j++)
    if(r[i]<r[j])
    {
    	t=r[i];r[i]=r[j];r[j]=t;
    	t=w[i];w[i]=w[j];w[j]=t;
    	t=p[i];p[i]=p[j];p[j]=t;
	}
	for(i=0;i<n;i++)
	{
		if(w[i]<=W)
		{
			profit +=p[i];
			W -=w[i];
		}
		else
		{
			profit +=r[i]*W;
			break;
			
		}
	}
	printf("Maximum profit=%.2f",profit);
	return 0;
}