using System.Net.Http.Headers;

Console.WriteLine("ikireqemli ededi daxil edin : ");

int num = Convert.ToInt32(Console.ReadLine());
int a = num / 10;
int b = num % 10;
int count = 0;

while (num != 0)
{
    num = num / 10;
    count++;
};
if (a > b && count ==2)
{
    Console.WriteLine("bu ededin reqemleri arasinda en boyuyu : ");
    Console.WriteLine(a);
}
else if (a < b && count ==2)
{
    Console.WriteLine("bu ededin reqemleri arasinda en boyuyu : ");
    Console.WriteLine(b);
}
else if (count != 2)
{
    Console.WriteLine("bu eded ikireqemli deyil !");
}
else
{
    Console.WriteLine("bu ededin reqemleri beraberdir .");
};