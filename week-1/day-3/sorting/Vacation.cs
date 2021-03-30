using System;
using System.Collections.Generic;
using System.Linq;

namespace Vacation
{
    public class Vacation
    {
        public static void Main(string[] args)
        {
            var applicants = new List<int> { 1267, 1968, 1935, 8561, 7775, 4524,
                3874, 9759, 6489, 9191, 4966, 6272, 8610, 6978, 627, 7999, 2115, 8926, 4736, 9311, 5931, 2702, 5937,
                1431, 4028, 4068, 7554, 4450, 9011, 8054, 1906, 1766, 4473, 5681, 9345, 3105, 6084, 5270, 2864, 1011,
                7272, 7361, 1034, 6617, 2681, 7578, 3388, 5102, 7244, 5390, 5809, 1818, 8254, 5336, 7528, 4922, 4099,
                798, 5548, 4329, 2293, 274, 7152, 991, 9527, 9718, 2489, 8523, 4611, 3437, 4363, 6293, 2663, 7165, 8994,
                7449, 4008, 866, 4235, 7100, 7762, 5130, 9495, 1659, 3443, 4153, 6075, 4413, 1940, 997, 7643, 283, 385,
                153, 931, 6626, 422, 8897, 1800, 6175, 5075, 2286, 8434, 3834, 2849, 9836, 3860, 8036, 7050, 9997, 1719,
                177, 5136, 5241, 9291, 3805, 3891, 4782, 7123, 1493, 5826, 9933, 2786, 7708, 6206, 9405, 9087, 4733,
                2472, 2158, 7039, 3693, 1950, 4155, 2635, 6606, 3911, 1482, 5267, 4240, 5624, 5481, 6906, 7299, 3767,
                8593, 8854, 1734, 9416, 126, 4880, 4233, 2949, 9234, 7893, 663, 9802, 4097, 9184, 348, 6753, 4433, 8615,
                4901, 6222, 356, 9169, 7983, 1841, 5694, 5811, 9893, 2570, 4805, 6850, 6064, 6592, 6473, 9524, 6033,
                9461, 5775, 5195, 6405, 2347, 6590, 8607, 5057, 4764, 9356, 6311, 3939, 1016, 8514, 9742, 8795, 7834,
                8862, 9826, 7230 };

            /* Acme corp is planning a vacation and the employee ID's are messed up.
            Write a simple sorting function that orders the employees ids in increasing numerical order
            so that the HR can distribute benefits easier.  Return with the sorted list.

            Use the insertion sort algorithm
            Display the results to the console */
            InsertionSort(applicants);
        }

        private static void InsertionSort(List<int> applicants)
        {
            //applicants.Sort();
            int[] inputArray = applicants.ToArray();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            var result = inputArray;
            result.ToList();

            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
