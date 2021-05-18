class CombSort
{
    static int GetNextGap(int gap)
    {
       
        gap = (gap * 10) / 13;
        if (gap < 1)
        {
            return 1;
        }
        return gap;
    }

    static void Sort(int[] array)
    {
        int length = array.Length;

        int gap = length;

       
        bool swapped = true;

        while (gap != 1 || swapped == true)
        {
            gap = GetNextGap(gap);

           
            swapped = false;

            
            for (int i = 0; i < length - gap; i++)
            {
                if (array[i] > array[i + gap])
                {
                    
                    int temp = array[i];
                    array[i] = array[i + gap];
                    array[i + gap] = temp;

                    swapped = true;
                }
            }
        }
    }

    public static void Main()
    {
        int[] array = { 10, 28, 1, 55, 6, 21, 36, 3, 45, 15, 0 };

        Console.WriteLine("Comb Sort");

        CommonFunctions.PrintInitial(array);

        Sort(array);

        CommonFunctions.PrintFinal(array);
        Console.ReadLine();

    }
}