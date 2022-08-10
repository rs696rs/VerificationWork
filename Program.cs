
string[] Array3Characters(string[] array)
{
    int count = 0;
    string[] array2 = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }

    }
    Array.Resize(ref array2, count);
    return array2;
}

string[] arrayWords = { "yes", "ussr", "usa", "to", "1234", "1567", "a", "Stalin", "gulag", "b", "c", "no" };
string[] newArrayWords = Array3Characters(arrayWords);

Console.Write("[" + string.Join(", ", newArrayWords) + "]");
