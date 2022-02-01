namespace Codility;

public class BinaryGapWithBitwise
{
    public int solution(long N)
    {
        int max = 0;
        int count = 0;
        bool foundFirstOne = false;
        
        for (int i = 0; i < sizeof(long)*8; i++)
        {
            var current = (N >> i) & 1;
            
            if (current == 1)
            {
                foundFirstOne = true;
                
                if (count >= max)
                {
                    max = count;
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            else
            {
                if (foundFirstOne)
                {
                    count++;
                }
            }
        }
        
        return max;
    }

    static public void Main(String[] args)
    {
        BinaryGapWithBitwise obj = new BinaryGapWithBitwise();
        obj.solution(561892);
    }
}