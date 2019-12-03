using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbruce1730ex3b
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius;
            celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * 9/5) + 32;
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal grossPay;
            if (hours <= 40)
                grossPay = hours * rate;
            else
                grossPay = (40 * rate) + (hours - 40) * (rate * 1.5m);
            return grossPay;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal hours = TotalHours(strNumbers);
            decimal grossPay = GrossPay(hours, rate);
            return grossPay;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
        }

        public static void CelsiusToFahrenheit(double celsius)
        { 
        
        }
    }
}
