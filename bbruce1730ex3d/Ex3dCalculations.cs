using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbruce1730ex3d
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            StringBuilder sbResult = new StringBuilder(200);
            foreach (int value in values)
            sbResult.Append(value.ToString() + ", ");
            sbResult.ToString();
            string result = sbResult.ToString();
            return result.Remove(result.LastIndexOf(", "));
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;

            foreach (int value in values)
                if (value == searchValue)
                    count++;

                // loop
                //     increment counter if current value equals searchValue
                // return counter
                return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;
            foreach (int value in values)
                if (value >= searchMin && value <= searchMax)
                    count++;
            return count;
        }
    }
}
