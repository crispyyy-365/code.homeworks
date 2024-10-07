// Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin

string[] words = { "apple", "pea", "computer", "car", "watch", "book", "guitar" };

for (int i = 0; i < words.Length; i++)
{
    for (int j = 0; j < words[i].Length; j++)
    {
        if (words[i].Length > 4)
        {
            Console.WriteLine(words[i]);
            break;
        }
    }
}