using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class BinaryGap {
    public int solution(int N)
    {
        string numberConvertedToBinary = Convert.ToString(N, 2);
        int max = 0;
        bool isCounting = false;
        int count = 0;
        
        for (int i = 0; i < numberConvertedToBinary.Length; i++)
        {
            if (numberConvertedToBinary[i] == '1')
            {
                isCounting = true;
                
                if (count >= max )
                {
                    max = count;
                    count = 0;
                }
            }
            else
            {
                count += 1;
            }
        }
        
        return max;
    }
}