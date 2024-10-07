//Verilmish ededin mertebelerinin cemini tap

int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

do
{
    int i = num % 10;
    sum += i;
    num /= 10;
}
while (num > 0 || num < 0);
Console.WriteLine(sum);