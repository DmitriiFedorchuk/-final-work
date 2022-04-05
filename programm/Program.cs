string[] array = new string[5] {"Hel", "111", "fhf", "fdssdf", "sdfgf"};
string[] newArray = new string[array.Length];
void SortArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int ind = 0; ind < array.Length; ind++)
    {
    if(array[ind].Length <= 3)
        {
        newArray[count] = array[ind];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        Console.Write($"{array[ind]} ");
    }
}
SortArray(array, newArray);
PrintArray(newArray);
