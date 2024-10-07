//Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxar

int[] num = { };

Console.WriteLine("Length of the array : ");

int length = Convert.ToInt32(Console.ReadLine());
Array.Resize(ref num, length);

Console.WriteLine("numbers : ");

for (int i = 0; i < length; i++)
{
    int element = Convert.ToInt32(Console.ReadLine());

    num[i] = element;
}

int count = 0;
int count2 = 0;

for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        if (num[i] < num[j])
        {
            count++;
        }
    }
    if (count > 0)
    {
        count = 0;
    }
    else
    {
        Console.WriteLine("index of the highest value of the array : ");
        Console.WriteLine(i);
        break;
    }
}
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        if (num[i] > num[j])
        {
            count2++;
        }
    }
    if (count > 0)
    {
        count = 0;
    }
    else
    {
        Console.WriteLine("index of the lowest value of the array : ");
        Console.WriteLine(i);
        break;
    }
}