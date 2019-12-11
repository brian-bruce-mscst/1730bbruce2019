using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbruce1730ex3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index >= 1 && index < days.Length + 1)
            {
                return days.GetValue(index - 1).ToString();
            }
            else
            return "Invalid index";
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            search = search.Trim();
            search = search.ToUpper();
            int index = Array.IndexOf(days, search);
            if (index >= 0)
            {
                search = hours[index];
                return search;
            }
            else
            return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;
            
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            if (count <= numbers.GetLength(0))
            {
                double sum = 0.0;
                for (int i = 0; i < count; i++)
                    sum += numbers[i];

                return sum;
            }
            else
                return 0.0;
        }
        public static double Calc5(double[] numbers)
        {
            int count = numbers.Length;
            double sum = Ex3cCalculations.Calc3(numbers, count);

            sum = sum / count;
            
            return sum;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double number in numbers)
                {
                    if (number > avg)
                        
                        aboveAvgList.Add(number);
                }
            }
            return aboveAvgList.ToArray(); ;
        }
    }
}
