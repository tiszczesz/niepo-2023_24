Console.WriteLine("Podaj rozmiar tablicy");
try
{
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];//utworzenie tablicy
    FillArray(numbers);
    ShowArray(numbers);
    Console.WriteLine(" ---------------------------------------------------------------- ");
    ShowShowOnlyAdd(numbers);

}
catch (FormatException ex)
{
    Console.WriteLine("Error");
    Console.WriteLine(ex.Message);
}

void FillArray(int[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(0, 100);
    }
}
void ShowArray(int[] nums)
{
    foreach (int elem in nums)
    {
        Console.WriteLine($"element tablicy : {elem}");
    }
}

void ShowShowOnlyAdd(int[] nums)
{
    foreach (int elem in nums)
    {
        if (elem % 2 == 0)
        {
            Console.WriteLine($"element tablicy : {elem}");
        }
    }
}
