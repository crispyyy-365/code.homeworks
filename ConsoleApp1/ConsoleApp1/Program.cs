Console.WriteLine("ededi daxil et :");

float num = Convert.ToInt32(Console.ReadLine());

if (num % 2 != 1 || num % 3 != 1)
{
    Console.WriteLine("bu eded murekkeb ededdir . ");
}
else if (num % 2 != 1 && num % 3 != 1)
{
    Console.WriteLine("bu eded murekkeb ededdir . ");
}
else
{
    Console.WriteLine("bu eded sade ededdir . ");
};