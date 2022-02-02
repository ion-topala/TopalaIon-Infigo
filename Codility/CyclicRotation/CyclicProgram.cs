namespace Codility;

public class CyclicProgram
{
    public int[] SolutionCyclicProgram(int[] givenArray, int numbersOfShifting)
    {
        if (givenArray.Length > 0)
        {
            int lengthArray = givenArray.Length;

            for (int j = 0; j < numbersOfShifting; j++)
            {
                int globalTemp = givenArray[0];

                for (int i = 0; i < lengthArray; i++)
                {
                    if (i == 0)
                    {
                        givenArray[0] = givenArray[lengthArray - 1];
                    }
                    else
                    {
                        int temp = givenArray[i];
                        givenArray[i] = globalTemp;
                        globalTemp = temp;
                    }
                }
            }
        }

        return givenArray;
    }

    static public void Main(String[] args)
    {
        CyclicProgram obj = new CyclicProgram();
        int[] numbersArgument = { };
        obj.SolutionCyclicProgram(numbersArgument, 3);
    }
}