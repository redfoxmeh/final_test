string [] array = { "Hello", ", ", "World", "!", "I", "am", "Groot", "42" };
ArrayChecking(array);
void ArrayChecking(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
}