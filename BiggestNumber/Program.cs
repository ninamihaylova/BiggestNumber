class BiggestNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int biggestNumber = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > biggestNumber)
            {
                biggestNumber = currentNumber;
            }
        }

        Console.WriteLine(biggestNumber);
    }
}