// her döngü için ayrı int ddeğerleri tanımladım

int i = 0;

while ( i < 10 )
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("bir ve 20 arasındaki sayılar :");
int j = 1;
while ( j < 21)
{
    Console.WriteLine(j);
    j++;

}
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("bir ve 20 arasındaki çift sayılar :");
int a = 1;
while ( a < 21 )
{

    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}
Console.WriteLine("----------------------------------------------------------");
int top = 0;
int k = 50;
while ( k <= 150 )
{
    top = top + k;
    k++;

}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :" + top);
Console.WriteLine("----------------------------------------------------------");
int cifttop = 0;
int tektop = 0;
int b = 1;
while ( b <= 120 )
{
    if (b % 2 == 0)
    {
        cifttop += b;
    }
    else
    {
        tektop += b;
    }
    b++;

}
Console.WriteLine("çift sayıların toplamı :" + cifttop);
Console.WriteLine("tek sayıların toplamı :" + tektop);