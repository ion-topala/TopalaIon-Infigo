class CountingElements
{
    private static void printArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    private static int[] CreateVoidArray(int length)
    {
        return new int[length + 1];
    }

    public int FrogRiverOne(int leavesPosition, int[] givenArray)
    {
        int lengthArray = givenArray.Length;
        int[] count = CreateVoidArray(leavesPosition);
        int sum = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            if (count[givenArray[i] - 1] == 0 && givenArray[i] <= leavesPosition)
            {
                sum++;
                count[givenArray[i] - 1] = 1;
            }

            if (sum == leavesPosition)
            {
                return i;
            }
        }
        
        return -1;
    }

    static public void Main(String[] args)
    {
        CountingElements obj = new CountingElements();
        int[] arrayArgument = {1, 3, 1, 4, 2, 3, 5, 4};
        Console.WriteLine(obj.FrogRiverOne(5, arrayArgument));
    }
}