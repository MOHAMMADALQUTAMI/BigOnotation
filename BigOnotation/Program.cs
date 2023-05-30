using System;
int[] x = new int[10];
for(int i=0;i<x.Length;i++) //o(n)
{
    x[i] =x[i] *5; //o(n)
}

int[] y = new int[10];
for(int i=0;i<y.Length;i++) //o(n)
{
    y[i] =y[i] *5; //o(1)
}
 for(int i=0;i<x.Length;i++) //o(n)
 {
if(x[i]==70) //o(1)
{
    for(int k=0;i<y.Length;k++)//o(n)
    {
if(y[k]==x[i])//o(1)
{
Console.WriteLine("the index of 70 in y is"+k);//o(n)
{
    
}
}
    }
}
 } ///time complixty = o(n^2)      // n *n = n^