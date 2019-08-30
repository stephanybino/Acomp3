using System;

namespace Acomp3
{
    class TailQuickSort : IQuickSort
    {
        public void Part(int[] E, int left, int right)
        {
            int c = E[right]; //pivô
            int t, j = left;
            for (int k = left; k < right; k++)
            {
                if (E[k] <= c)
                {
                    t = E[j];
                    E[j] = E[k];
                    E[k] = t;
                    j++;
                }
              
            }
            t = E[j];
            E[j] = E[right];
            E[right] = t;
            return j;
        }
        public void Sort(int[] E, int left, int right)
        {
           while(left < right)
                {
                    int s = Part(E, left, right);
                    if ((s - left) < right - s)
                    {
                        Sort(E, left, s - 1);
                        left = s + 1;
                    }
                    else
                    {
                        Sort(E, s + 1, right);
                        right = s - 1;
                    }
                }
        }

        public void Sort(int[] E, int n)
        {
            Sort(E, 0, n - 1);
        }
    }
}