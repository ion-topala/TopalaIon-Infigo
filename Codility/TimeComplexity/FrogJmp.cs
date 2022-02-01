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

    static public void Main(String[] args)
    {
        FrogJmp a = new FrogJmp();
        int[] numbersArgument = Enumerable.Range(0, 100000).Select(it => 1000000).ToArray();
        Console.WriteLine(a.PermMissingElem(numbersArgument));
    }
}