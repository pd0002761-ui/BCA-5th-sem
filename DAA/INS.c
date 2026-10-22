#include <stdio.h> 
int main()
{
int n,a[100]; 
int i,j,key;
printf("Enter number of elements: "); 
scanf("%d", &n);
printf("Enter elements: "); 
for (i = 0; i < n; i++)
{
  scanf("%d", &a[i]);
}
for (i = 1; i < n; i++)
{
key = a[i];
j = i - 1;
while (j >= 0 && a[j] > key)
{
a[j + 1] = a[j]; 
j--;
}
a[j + 1] = key;
}
printf("Sorted array: "); 
for (i = 0; i < n; i++)
{
printf("%d ", a[i]);
}
return 0;
}
 

