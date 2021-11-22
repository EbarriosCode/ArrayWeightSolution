using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayProblem
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Input: 123,27,151,323,32
            Weight: 6,9,7,8,5
            Output: 32,123,151,323,27
            */

            int[] arr = new int[] { 123, 27, 151, 323, 32 };
            Solution(arr);
        }

        public static void Solution(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            int length = arr.Length;
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                string cadena = arr[i].ToString();

                int sumWeight = 0;
                foreach (char c in cadena)
                {
                    sumWeight += Convert.ToInt32(c.ToString());
                }

                result.Add(arr[i], sumWeight);
            }

            var values = result.ToList();
            values.Sort((x, y) => x.Value.CompareTo(y.Value));

            foreach (var item in values)
            {
                Console.WriteLine("Vaue: " + item.Key + "     Weight: " + item.Value);
            }
        }
    }
}
