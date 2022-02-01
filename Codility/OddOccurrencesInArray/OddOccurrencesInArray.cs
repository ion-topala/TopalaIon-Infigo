class OddOccurrencesInArray
{
    public int SolutionOddOccurrence(int[] givenArray)
    {
            int oddNumber = givenArray[0];
            int globalCounter = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                int counter = 1;
                
                for (int j = 0; j < givenArray.Length ; j++)
                {
                    if (i != j)
                    {
                        if (givenArray[i] == givenArray[j])
                        {
                            counter++;
                        }
                    }
                }

                if (counter % 2 == 1)
                {
                    globalCounter = givenArray[i];
                }
            }

            return globalCounter;
    }
    public int SolutionOddOccurrenceXOR(int[] givenArray)
    {
        int oddNumber = givenArray[0];
        
        for (int i = 1; i < givenArray.Length; i++)
        {
            oddNumber = oddNumber ^ givenArray[i];
        }
        return oddNumber;
    }
    

    static public void Main(String[] args)
    {
        OddOccurrencesInArray obj = new OddOccurrencesInArray();
        int[] numbersArgument = {9, 3, 9, 3, 9, 7, 9};
        Console.WriteLine(obj.SolutionOddOccurrenceXOR(numbersArgument));
    }
}