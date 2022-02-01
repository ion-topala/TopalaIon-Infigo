namespace Codility;

public class CyclicProgram
{
    public int[] solution(int[] A, int K)
    {
        if (A.Length > 0)
        {
            int N = A.Length;
            
            for (int j = 0; j < K; j++)
            {
                int globalTemp = A[0];
                
                for (int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        A[0] = A[N - 1];
                    }
                    else
                    {
                        int temp = A[i];
                        A[i] = globalTemp;
                        globalTemp = temp;
                    }
                }
            }
        }

        return A;
    }

    static public void Main(String[] args)
    {
        CyclicProgram obj = new CyclicProgram();
        int[] numbersArgument = {};
        obj.solution(numbersArgument, 3);
    }
}