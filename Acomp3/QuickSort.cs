using System;

namespace Acomp3
{
    class QuickSort : IQuickSort
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
           if ( left < right)
            {
                int b = Part(E, left, right);
                Sort(E, left, b-1);
                Sort(E, b+1, right);
            }
        }

        public void Sort(int[] E, int n)
        {
             Sort(E, 0, n - 1); 
        }
    }
}
