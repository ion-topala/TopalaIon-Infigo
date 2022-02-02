namespace TimeComplexity;

public class TimeComplexity
{
    public int FrogJmpSolution(int currentPosition, int nextPosition, int stepSize)
    {
        var steps = Math.Ceiling((double) (nextPosition - currentPosition) / stepSize);
        int stepsConvertedToInt = Convert.ToInt32(steps);
        return stepsConvertedToInt;
    }

    public int PermMissingElem(int[] givenArray)
    {
        long expectedSum = ((long) givenArray.Length + 1) * ((long) givenArray.Length + 2) / 2;
        long realSum = 0;
        for (int i = 0; i < givenArray.Length; i++)
        {
            realSum += givenArray[i];
        }

        return (int) (expectedSum - realSum);
    }

    public int TapeEquilibrium(int[] givenArray)
    {
        long lengthArray = givenArray.Length;
        long sumToP = 0;
        long minDifference = 0;
        bool firstDifference = true;

        for (int i = 0; i < lengthArray - 1; i++)
        {
            sumToP += givenArray[i];
            long restSum = 0;

            for (int j = i + 1; j < lengthArray; j++)
            {
                restSum += givenArray[j];
            }

            if (firstDifference)
            {
                minDifference = Math.Abs(sumToP - restSum);
                firstDifference = false;
            }
            else
            {
                if (Math.Abs(sumToP - restSum) < minDifference)
                {
                    minDifference = Math.Abs(sumToP - restSum);
                }
            }
        }

        return (int) minDifference;
    }

    public int TapeEquilibriumV2(int[] givenArray)
    {
        long sum = 0;
        int lengthArray = givenArray.Length;
        long sumToP = 0;
        long minDifference = 0;
        bool firstDifference = true;

        for (int i = 0; i < lengthArray; i++)
        {
            sum += givenArray[i];
        }

        for (int i = 0; i < lengthArray - 1; i++)
        {
            sumToP += givenArray[i];
            long rightDifference = sum - sumToP;
            if (firstDifference)
            {
                minDifference = Math.Abs(sumToP - rightDifference);
                firstDifference = false;
            }
            else
            {
                if (Math.Abs(sumToP - rightDifference) < minDifference)
                {
                    minDifference = Math.Abs(sumToP - rightDifference);
                }
            }
        }

        return (int) minDifference;
    }

    public int TapeEquilibriumV3(int[] givenArray)
    {
        int lengthArray = givenArray.Length;
        long sumToP = 0;
        long minDifference = int.MaxValue;

        long sum = givenArray.Sum();

        for (int i = 0; i < lengthArray - 1; i++)
        {
            sumToP += givenArray[i];
            minDifference = Math.Min(minDifference, Math.Abs(sumToP - (sum - sumToP)));
        }

        return (int) minDifference;
    }

    static public void Main(String[] args)
    {
        TimeComplexity a = new TimeComplexity();
        int[] numbersArgument = {3, 1, 2, 4, 3};
        Console.WriteLine(a.TapeEquilibriumV3(numbersArgument));
    }
}