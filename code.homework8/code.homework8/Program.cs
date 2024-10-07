//Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxar

int[] num = { };

Console.WriteLine("Length of the first array : ");

int length = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref num, length);

Console.WriteLine("numbers : ");

for (int i = 0; i < length; i++)
{
    int element = Convert.ToInt32(Console.ReadLine());
    num[i] = element;
}

int[] num2 = { };

Console.WriteLine("Length of the second array : ");

int length2 = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref num2, length2);

Console.WriteLine("numbers : ");

for (int i = 0; i < length2; i++)
{
    int element2 = Convert.ToInt32(Console.ReadLine());
    num2[i] = element2;
}

Console.WriteLine("same numbers of each array : ");

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length2; j++)
    {
        if (num[i] == num2[j])
        {
            Console.WriteLine(num[i]);
            break;
        }
    }
}