class FrogJmp
{
    public int FrogJmpSolution(int currentPosition, int nextPosition, int stepSize)
    {
        var steps = Math.Ceiling((double) (nextPosition - currentPosition) / stepSize);
        int stepsConvertedToInt = Convert.ToInt32(steps);
        return stepsConvertedToInt;
    }

    public int PermMissingElem(int[] givenArray)
    {
        long expectedSum = ((long) givenArray.Length + 1) * ((long)  givenArray.Length + 2) / 2;
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
            
            for (int j = i+1 ; j < lengthArray; j++)
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

    static public void Main(String[] args)
    {
        FrogJmp a = new FrogJmp();
        int[] numbersArgument = Enumerable.Range(0, 100000).Select(it => 1000).ToArray();
        a.TapeEquilibrium(numbersArgument);
    }
}