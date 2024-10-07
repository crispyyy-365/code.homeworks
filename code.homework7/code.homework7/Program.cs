//Verilmish arrayda murekkeb ededleri ekrana çıxarin

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

Console.WriteLine("complex numbers of the array : ");

int count = 0;

for (int i = 0; i < length; i++)
{
    for (int j = 2; j <= 11; j++)
    {
        if (num[i] == j)
        {
            break;
        }
        if (num[i] % j == 0)
        {
            count++;
        }
        if (count > 1)
        {
            Console.WriteLine(num[i]);
            break;
        }
    }
}