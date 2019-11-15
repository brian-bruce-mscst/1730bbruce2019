using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace bbruce1730ex2h
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay) 
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = dateA - dateB;
                result = timeTillDue.Days.ToString() + " days";
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);

                if (dateA > dateB)
                {
                    TimeSpan pastDue = dateA - dateB;
                    result = pastDue.Days.ToString() + " days past due";
                }
                else 
                { 
                    result = "On time";
                }
                    
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            // remove first char, insert 'cr'
            // try block, trim, if
            string result = "Invalid input";
            string removeInsert = s;
            removeInsert = removeInsert.Trim();
            try
            {
                removeInsert = removeInsert.Remove(0, 1);
                removeInsert = removeInsert.Insert(0, "cr");
                result = removeInsert;
            }
            catch { }

            return result;
        }
        public static string StringCalc02(string s)
        {
            // leave first char, remove second char, replace with 'rit'
            // try block, trim, if
            string result = "Invalid input";
            string removeInsert = s;
            removeInsert = removeInsert.Trim();
            try
            {
                removeInsert = removeInsert.Remove(1, 1);
                removeInsert = removeInsert.Insert(1, "rit");
                result = removeInsert;
            }
            catch { }

            return result;
        }
        public static string StringCalc03(string s)
        {
            // skip first two char, substring next four char, toupper and display
            // try block, trim, if
            string result = "Invalid input";
            string removeInsert = s;
            removeInsert = removeInsert.Trim();
            try
            {
                string nextFour = removeInsert.Substring(2, 4).ToUpper();
                result = nextFour;
            }
            catch { }

            return result;
        }
        public static string StringCalc04(string s)
        {
            // padleft use * for 10 char
            // try block, trim, if
            string result = "Invalid input";
            string padLeft = s;
            padLeft = padLeft.Trim();
            try
            {
                padLeft = padLeft.PadLeft(10,'*').ToString();
                result = padLeft;
            }
            catch { }

            return result;
        }
        public static string StringCalc05(string s)
        {
            // replace ( with "", ) with "", " " with "", - with ""
            // try block, trim, if
            string result = "Invalid input";
            string replace = s;
            replace = replace.Trim();
            try
            {
                replace = replace.Replace("(", "");
                replace = replace.Replace(")", "");
                replace = replace.Replace(" ", "");
                replace = replace.Replace("-", "");
                result = replace;
            }
            catch { }

            return result;
        }
        public static string StringCalc06(string s)
        {
            // use replace like before, then insert .
            // try block, trim, if to check length 7 then only put 1 ., if lenth 10  put 2 ., incorrect number of digits then invalid input
            string result = "Invalid input";
            string replace = s;
            replace = replace.Trim();
            try
            {
                replace = replace.Replace("(", "");
                replace = replace.Replace(")", "");
                replace = replace.Replace(" ", "");
                replace = replace.Replace("-", "");
                if (replace.Length == 7)
                {
                    replace = replace.Insert(3, ".");
                    result = replace;
                }
                else if (replace.Length == 10)
                {
                    replace = replace.Insert(3, ".");
                    replace = replace.Insert(7, ".");
                    result = replace;
                }


            }
            catch { }

            return result;
        }
        public static string StringCalc07(string s)
        {
            // to lower first, if Pioneer found then display Found, else Not found
            // try block, trim, if
            string result = "Invalid input";
            string contains = s;
            contains = contains.Trim();
            try
            {
                contains = contains.ToLower();
                if (contains.Contains("pioneer"))
                {
                    contains = "Found";
                    result = contains;
                }
                else
                {
                    contains = "Not found";
                    result = contains;
                }
            }
            catch { }

            return result;
        }
        public static string StringCalc08(string s)
        {
            // search for comma, display everything after the , " "
            // try block, trim, if, if no , Invalid input
            string result = "Invalid input";
            string input = s;
            int outputIndex;
            input = input.Trim();
            try
            {
                if (input.Contains(","))
                {
                    outputIndex = input.IndexOf(",") + 1;
                    result = input.Substring(0, outputIndex - 1);
                }
                return result;
            }
            catch { }

            return result;
        }
        public static string StringCalc09(string s)
        {
            // lastindexof to find last space, display everything after the last " "
            // try block, trim, if, if no space Invalid input
            string result = "Invalid input";
            string input = s;
            input = input.Trim();
            int outputIndex;
            try
            {
                if (input.Contains(" "))
                { 
                    outputIndex = input.LastIndexOf(" ");
                    result = input.Substring(outputIndex + 1);
                }
                return result;
            }
            catch { }

            return result;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            string result = "Invalid input";

            try
            {
                StringBuilder sb = new StringBuilder(100);
                sb.Append(s1 + ", ");
                sb.Append(s2 + ", ");
                sb.Append(s3);
                result = sb.ToString();
            }
            catch { }

            return result;
        }
    }
}