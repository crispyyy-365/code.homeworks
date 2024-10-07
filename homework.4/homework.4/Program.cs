// ededlerden ibaret arrayin ededlerinin cemini tap

using System.Net.Http.Headers;

int[] num = { 56, 72, 88, 49 };
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum = sum + num[i];
}
Console.WriteLine(sum);