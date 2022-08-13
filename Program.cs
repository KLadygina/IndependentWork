string[] text = { "hello", "wld", "2", ":-)", "car" };

string result = String.Empty;
string word = String.Empty;
int neededlength = 3;
for (int i = 0; i < text.Length; i++)
{
    word = text[i];
    if (word.Length == neededlength)
    {
        result = result + " " + text[i];
    }
}

string[] array = result.Split(" ");
Console.WriteLine();

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

FillArray(array); 
