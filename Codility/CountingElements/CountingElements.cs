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

    public int CheckPermutationV1(int[] givenArray)
    {
        var length = (long) givenArray.Length;
        var sumExpected = length * (long) (length + 1) / 2;
        var sumObtained = 0;

        for (int i = 0; i < length; i++)
        {
            sumObtained += givenArray[i];
        }

        if (sumExpected == sumObtained)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int CheckPermutationV2(int[] givenArray)
    {
        var length = (long) givenArray.Length;
        var maxElement = givenArray[0];
        var sum = 0;

        for (int i = 0; i < length; i++)
        {
            sum += givenArray[i];
            if (givenArray[i] > maxElement)
            {
                maxElement = givenArray[i];
            }
        }

        var sumExpected = maxElement * (long) (maxElement + 1) / 2;
        if (sumExpected == sum)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    static public void Main(String[] args)
    {
        CountingElements obj = new CountingElements();
        int[] arrayArgument = {4, 1, 3, 2};
        Console.WriteLine(obj.CheckPermutationV2(arrayArgument));
    }
}