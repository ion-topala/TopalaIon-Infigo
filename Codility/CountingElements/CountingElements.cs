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
        
        return 0;
    }
    
    public int CheckPermutationV3(int[] givenArray)
    {
        var length = (long) givenArray.Length;
        var sumIndex = 0;
        var sumNum = 0;
        
        for (int i = 0; i < length; i++)
        {
            sumIndex += i + 1;
            sumNum += givenArray[i];
        }

        if (sumIndex == sumNum)
        {
            return 1;
        }
        
        return 0;
    }

    public int[] MaxCounters(int lengthCount, int[] givenArray)
    {
        var counter = CreateVoidArray(lengthCount - 1);
        printArray(counter);
        var k = 0;
        
        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i] <= lengthCount && givenArray[i] >= 1)
            {
                counter[givenArray[i]-1] += 1;
                if (counter[givenArray[i]-1] >= k)
                {
                    k = counter[givenArray[i]-1];
                }
                printArray(counter);
            }
            else if (givenArray[i] > lengthCount)
            {
                for (int j = 0; j < lengthCount; j++)
                {
                    counter[j] = k;
                }
                printArray(counter);
            }
        }
        
        return givenArray;
    }

    static public void Main(String[] args)
    {
        CountingElements obj = new CountingElements();
        int[] arrayArgument = {3, 4, 4, 6, 1, 4, 4};
        obj.MaxCounters(5,arrayArgument);
    }
}