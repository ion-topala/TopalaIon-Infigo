namespace Codility;

public class BinaryGapWithBitwise
{
    public int solution(int N)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < 32; i++)
        {
            var current = (N >> i) & 1;
            if (current == 1)
            {
                if (count >= max)
                {
                    max = count;
                    count = 0;
                }
            }
            else
            {
                count++;
            }
        }
        Console.WriteLine("The max {0}",max);
        return max;
    }

    static public void Main(String[] args)
    {
        BinaryGapWithBitwise obj = new BinaryGapWithBitwise();
        obj.solution(529);
    }
}