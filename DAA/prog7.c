#include<stdio.h>
void heapify(int a[],int n,int i)
{
	int largest=i,l=2*i+1,r=2*i+2,t;
	if(l<n&&a[l]>a[largest])
	largest=l;
	if(r<n&&a[r]>a[largest])
	largest=r;
	if(largest!=i)
	{
		t=a[i];
		a[i]=a[largest];
		a[largest]=t;
		heapify(a,n,largest);
		
	}
}int main()
{
	int a[50],n,i,t;
	printf("Enter number of elements:");
	scanf(" %d",&n);
	printf("Enter elements:");
	for(i=0;i<n;i++)
	scanf(" %d",&a[i]);
	for(i=n/2-1;i>=0;i--)
	heapify(a,n,i);
	for(i=n-1;i>0;i--)
	{
		t=a[0];
		a[0]=a[i];
		a[i]=t;
		heapify(a,i,0);
	}
	printf("Sorted elements:");
	for(i=0;i<n;i++)
	printf(" %d",a[i]);
	return 0;
	
}