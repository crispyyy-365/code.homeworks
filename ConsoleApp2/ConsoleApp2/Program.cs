string option;

string[] arr = { "eli", "taceddin", "ayxan" };

Console.WriteLine("1.Add contacts");

Console.WriteLine("2.Show contacts");

Console.WriteLine("3.Show maintained contact");

do
{
    option = Console.ReadLine();

    switch (option)
    {
        case "1":

            Console.WriteLine("value : ");

            string contact = Console.ReadLine();

            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = contact;

            Console.WriteLine("contact added");

            break;

        case "2":
            Console.WriteLine("these are your contacts : ");

            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            };
            break;

        case "3":

            string name = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (name == arr[i])
                {
                    Console.WriteLine(arr[i]);
                }
            };
            break;
    }

}
while (option != "0");