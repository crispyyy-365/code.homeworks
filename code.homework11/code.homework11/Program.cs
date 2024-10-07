//1-den 10 qeder olan arrayda bir reqem eskikdir. Eskik olan reqemi tapan algorithm yazin ve nezere alin ki verilen arrayda reqemler siralanmadan duzulub

int[] nums1 = { 3, 7, 1, 9, 8, 4, 5, 6, 10 };
int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = 0;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 9; j++)
    {
        if (nums2[i] == nums1[j])
        {
            count++;
            break;
        }
    }
    if (count == 1)
    {
        count = 0;
    }
    else
    {
        Console.WriteLine("eksik olan eded : " + nums2[i]);
    }
}

//Elave
//istenilen sirada duzulmus array ucun 

int[] numbers1 = new int[9];
int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int Count = 0;

Console.WriteLine("arrayin ededlerini daxil edin : ");

for (int i = 0; i < 9; i++)
{
    numbers1[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers1[i] < 1 || numbers1[i] > 10)
    {
        Console.WriteLine("daxil edilen eded 1 ve 10 arasinda deyil.");
        break;
    }
}
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 9; j++)
    {
        if (numbers2[i] == numbers1[j])
        {
            count++;
            break;
        }
    }
    if (Count == 1)
    {
        Count = 0;
    }
    else
    {
        Console.WriteLine("eksik olan eded : " + numbers2[i]);
    }
}