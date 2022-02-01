class FrogJmp
{
    public int FrogJmpSolution(int currentPosition, int nextPosition, int stepSize)
    {
        var steps = Math.Ceiling((double) (nextPosition - currentPosition) / stepSize);
        int stepsConvertedToInt = Convert.ToInt32(steps);
        return stepsConvertedToInt;
    }

    static public void Main(String[] args)
    {
        FrogJmp a = new FrogJmp();
        Console.WriteLine(a.FrogJmpSolution(10, 85, 30));
    }
}