using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var result = new int[size, size];
        int x = 0;
        int y = 0;
        int direction = 0;
        int cycle = 1;
        int iter = 1;
        int currentSize = size;
        for (int i = 1; i <= Math.Pow(size, 2); i++)
        {
            result[x, y] = i;
            if (iter == currentSize)
            {
                ++cycle;
                if (cycle % 2 == 0)
                {
                    --currentSize;
                }
                iter = 1;
                direction = (direction + 1) % 4;
            }
            else
            {
                iter++;
            }
            switch (direction)
            {
                case 0:
                    y++;
                    break;
                case 1:
                    x++;
                    break;
                case 2:
                    y--;
                    break;
                case 3:
                    x--;
                    break;
            }            
        }
        return result;
    }
}
