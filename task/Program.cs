string[] text = new string [5] { "hello", "world", "hi", "!!!", "0" };
string[] array = new string[text.Length];

int count = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Length <= 3)
    {
        array[count] = text[i]; 
        count++;
        
    }
    

}  
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array);