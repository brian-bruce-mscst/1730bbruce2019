using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbruce1730ex2f
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100)            // Begin nested if
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;     // End nested if
            }
            else                                // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            decimal total = 0m;
            
            if (input != "")
            {
                ethereum = Decimal.Parse(input);
                total = ethereum * 200m;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            // if order is under $50 add $5 for shipping
            decimal price = 0m;
            decimal quantity = 0m;
            decimal total = 0m;
            decimal shipping = 0m;
            if (inputA != "" && inputB != "")
            {
                price = Decimal.Parse(inputA);
                quantity = Decimal.Parse(inputB);
                total = quantity * price;
                if (total < 50m)
                {
                    shipping = total + 5m;
                    return shipping.ToString("n2");
                }
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal prior = 0m;
            decimal current = 0m;
            decimal rate = .10m;
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                if (Decimal.Parse(inputA) < Decimal.Parse(inputB)) 
                { 
                    prior = Decimal.Parse(inputA);
                    current = Decimal.Parse(inputB);
                    total = (current - prior) * rate;
                    return total.ToString("n2");
                }
                return "Invalid input";
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            double leftNum = 0;
            double rightNum = 0;
            double result = 0;
            if (inputA != "" && inputB != "")
            {
                if (Double.Parse(inputA) > 0 && Double.Parse(inputB) > 0)
                {
                    leftNum = Int32.Parse(inputA);
                    rightNum = Int32.Parse(inputB);
                    if (leftNum >= rightNum)
                    {
                        result = leftNum / rightNum;
                        return result.ToString("n2");
                    }
                    else
                        result = rightNum / leftNum;
                    return result.ToString("n2");
                }
                else
                    return "Invalid input";
            }
            return "Invalid input";
        }
    }
}
