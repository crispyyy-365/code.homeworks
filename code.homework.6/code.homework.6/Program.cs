//Ədədlərdən ibarət arrayın ən kiçik elementini tapın

int[] num = { 9, 16, 4, 23, 14 };

int count = 0;

Console.WriteLine("arrayin en kicik elementi : ");

for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        if (num[i] > num[j])
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
        Console.WriteLine(num[i]);
    }
}