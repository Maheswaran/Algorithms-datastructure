using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = GetArrayAsInput();
            int y = ElementToFindInArray();
            BinarySearch srch = new BinarySearch();
            srch.Search(x, y);
        }

        private static int[] GetArrayAsInput()
        {
            List<int> values = new List<int>();

            Console.WriteLine("Enter number of elements in the array");
            string input = Console.ReadLine();
            int len = !string.IsNullOrEmpty(input) ? Convert.ToInt32(input) : -1;

            if (len == -1)
            {
                Console.WriteLine("Enter valid number");
                return null;
            }

            Console.WriteLine("Enter the nunbers to be in array, Press enter for feed new number");

            while (len != 0)
            {

                int i = Convert.ToInt32(Console.ReadLine());
                values.Add(i);
                len--;
            }

            return values.ToArray();
        }
        
        private static int ElementToFindInArray()
        {
            Console.WriteLine("Enter the nunber to be find in array");
            string findVal = Console.ReadLine();
            return Convert.ToInt32(findVal);
        }
        
    }
}
