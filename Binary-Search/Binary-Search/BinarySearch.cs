using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    public class BinarySearch
    {
        int indexPosition = 0;

        public int Search(int[] array, int searchElement)
        {            
            int[] sortedArray = SortArray(array);
            return FindElementInArray(sortedArray, searchElement, 0, sortedArray.Length);           
        }

        private int FindElementInArray(int[] sortedArray, int y, int startindex, int endindex)
        {
            int med = 0;
         
            med = (startindex + endindex) / 2;

            if (y > sortedArray[med])
            {
                startindex = med;
                endindex = sortedArray.Length;
                FindElementInArray(sortedArray, y, startindex, endindex);
            }
            else if (y == sortedArray[med])
            {
                //Console.WriteLine("The element " + y + " found at " + (med + 1) + " position");
                indexPosition = med+1;
                return indexPosition;
            }
            else
            {
                endindex = med;
                FindElementInArray(sortedArray, y, startindex, endindex);
            }

            return indexPosition;
        }

        private void PrintSortedArray(int[] sortedArray)
        {
            Console.WriteLine("element in sorted order :");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
        }

        private int[] SortArray(int[] x)
        {
            int temp, iCount = 0;

            for (int i = 0; i < x.Length - 1; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }

                    iCount++;
                }
            }

            return x;
        }

    }
}
