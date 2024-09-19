/**
int a;
int k = 0;
Console.Write("Son kriteng: a =");
a = Convert.ToInt32(Console.ReadLine());
if(a==1) Console.WriteLine("tup son:");
for(int i = 1; i <= a; i++)
{
    if(a%i==0)
    {
        k++;
         Console.WriteLine(i);
    }
}
if(k==2 || k==1) Console.WriteLine("Tup son:");
else Console.WriteLine("tup son emas:");
*/


/**
int a;
Console.Write("Son kriteng: a =");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bo'luvchilari:");
for(int i = 2; i <= a; i++)
{
    if(a%i==0 && i<=10)
    {
         Console.Write($"{i} ");
    }
}
*/

/**
int a;
int b;
Console.WriteLine("son kriting: ");
a=Convert.ToInt32(Console.ReadLine());
Key:
Console.WriteLine("Darajani kriteng: ");
b=Convert.ToInt32(Console.ReadLine());
if(b<=0)
{
    Console.WriteLine("Musbat son kriteng:");
    goto Key;
}
Math.Pow(a,b);
Console.WriteLine(Math.Pow(a,b));
*/

/**
int n;
int sum=0;
Console.Write("nechta son kritmoqchisiz: ");
n = Convert.ToInt32(Console.ReadLine());
int[] M1 = new int[n];
for(int i = 0; i < n; i++)
{
    M1[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < n; i++)
{
    sum = sum + M1[i];
}
Console.WriteLine($" sonlar yig'indisi: {sum}");
*/

int s1;
string s
double sum = 0;
s = Console.ReadLine();
s1=Convert.ToInt32(s.Length);
foreach (char digit in s)
{
    int digitValue = digit - '0';
    sum = sum + Math.Pow(digitValue,s1);
}
Console.WriteLine($"qiymat = {sum}");
int x = Convert.ToInt32(s);
if(x==sum)
{
    Console.WriteLine($"armstrong son: = {sum}");
}
