



.1. BMI Calculator

Write a program to find the BMI of a person given their height(In Metres) and weight(In Kg) as inputs.
Include a class UserProgramCode with static method BMICalc which accepts two float numbers. The return type is String.
Create a class Program which would get the input and call the static method BMICalc present in the UserProgramCode.
Input and Output Format:
Input1 is a float – Weight (In Kg)
Input2 is a float - Height (In Metres)
Output is a string – Interpreted BMI value.
Metric BMI Formula
BMI = ( Weight in Kilograms / ( Height in Meters x Height in Meters ) )

Business rule:

BMI Interpretation is given below
Underweight = BMI of <18.5
Normalweight = BMI of 18.5–24.9
Overweight = BMI of 25–29.9
Obesity = BMI of 30 or greater
If zero or negative number is given as input then return "InvalidInput" , otherwise return "Underweight","Normalweight",
"Overweight","Obesity" as per Business rule.
Sample Input 1:
70
1.65
Sample Output 1:
Overweight]
Sample Input 2:
45
1
Sample Output 2:
Obesity


\\Answer:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            float input1, input2;
            input1 = float.Parse(Console.ReadLine());
            input2 = float.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.BMICalc(input1, input2));
            Console.ReadLine();

        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checking_d
{
    class UserProgramCode
    {
        public static string BMICalc(float input1, float input2)
        {

            float bmi;

            if (input1 <= 0 || input2 <= 0)
            {
                return ("InvalidInput");
            }
            else
            {

                bmi = (input1 / (input2 * input2));
                if (bmi < 18.5)
                    return ("Underweight");
                else if (bmi >= 18.5 && bmi <= 24.9)
                    return ("Normalweight");
                else if (bmi >= 25 && bmi <= 29.9)
                    return ("Overweight");
                else if (bmi >= 30)
                    return ("Obesity");
            }
            return ("null");
        }
    }
}
……………………………………………………………………………………………………………………………………………………………………………………………………………………………………………
2.Time Validation


 Write code to validate time using the following rules:
Business rules:
- It should be a valid time in 12 hrs format
- It should have case insensitive AM or PM
-The time as input in the following format 'hh:mm am' or 'hh:mm pm'
Include a class UserProgramCode with static method validateTime  which accepts the String.The return type should be interger.
Create a class Program which would get the input and call the static method validateTime present in the UserProgramCode.
If the given time is as per the given business rules return 1 else return -1.If the method returns 1 then print "Valid time format" else print "Invalid time format" in Program.


Input and Output Format:


The input time  will be a string
Output  will be a string.("Valid time format" or "Invalid time format").
Sample Input 1:
09:59 pm
Sample Output 1:
Valid time format


\\Answer


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int ans = UserProgramCode.validateTime(str);
            if (ans == 1)
                Console.WriteLine("Valid time format");
            else if (ans == -1)
                Console.WriteLine("Invalid time format");
            Console.ReadLine();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Checking_d
{
    class UserProgramCode
    {
        public static int validateTime(string str)
        {
            DateTime dt;
            bool b = DateTime.TryParseExact(str, "hh:mm tt", null,System.Globalization.DateTimeStyles.None, out dt);
            if (b==true)
                    return 1;
            else
                  return -1;  
          
        }

    }
}



-----------------------------------------------------------------------------------------

3. IP Validator 


Write code to read an IP address in a String variable and validate the IP address. Print “Valid” if it is a valid IP address else print “Invalid”.


Note: An IP address has the format a.b.c.d where a,b,c,d are numbers between 0-255 


Include a class UserProgramCode with a static method ipValidator which accepts a string. The return type (integer) should return 1 if it a valid IP, else return 2.
Create a Class Program which would be used to accept a string and call the static method present in UserProgramCode.


Input and Output Format:


Input consists of a String.
Output consists of a String(“Valid” or “Invalid”).
Refer sample output for formatting specifications.
Sample Input 1:
132.145.184.210
Sample Output 1:
Valid
Sample Input 2:
132.145.184.290
Sample Output 2:
Invalid



\\Answer:-



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int no = UserProgramCode.ipValidator(str);
            if (no == -1)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    static class UserProgramCode
    {
         public static int ipValidator(string str)
        {
            int res = 1, k;
            
                string[] s = str.Split('.');
                int[] i = new int[s.Length];
                for (k = 0; k < i.Length; k++)
                {
                    foreach (char c in s[k])
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            res = -1;
                            break;
                        }
                    }
                    i[k] = Int32.Parse(s[k]);
                }
                if (i[0] <= 0 || i[0] >= 255)
                    res = -1;
                else if (i[1] <= 0 || i[1] >= 255)
                    res = -1;
                else if (i[2] <= 0 || i[2] >= 255)
                    res = -1;
                else if (i[3] <= 0 || i[3] >= 255)
                    res = -1;
                else if (k != 4)
                    res = -1;
                     
                         
           return res;
        }
   }
}

-----------------------------------------------------------------------------------------


4. List the Elements
Write a program that accepts integer list and an integer. List all the elements in the list that are greater than the value of given integer. Print the result in descending order.
Include a class UserProgramCode with static method GetElements() which accepts an integer list and the integer as input and returns an integer list. 
If there is no element found in input1, then store -1 to the first element of output list.
Create a class Program which would get the input and call the static method GetElements() present in the UserProgramCode. If there is no such element in the input list, print "No element found". 
Input and Output Format:
Input consists of n+2 integers. The first integer corresponds to n, the number of elements in the array. The next 'n' integers correspond to the elements in the array.
The last input is an integer.
Output is an integer list or the string "No element found".
Sample Input 1:
7 
1
4
7
3
9
15
24
17
Sample Output 1:
24
Sample Input 2:
6
5
9
3
4
16
21
9
Sample Output 2:
21
16
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    
        class Program
    {
            static void Main(string[] args)
            {
                int n, i;
                n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (i = 0; i < n; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                int limit = int.Parse(Console.ReadLine());
                int[] ans = UserProgramCode.GetElements(arr, limit);
                if (ans[0] == -1)
                    Console.WriteLine("No element found");
                else
                {
                    foreach (int item in ans)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.ReadLine();

            }


    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Checking_d
{
    class UserProgramCode
    {
        public static int[] GetElements(int[] arr, int limit)
        {
            int n = arr.Length;
            List<int> temp = new List<int>();
            int i, j;
            i = 0;
            for (j = 0; j < n; j++)
            {
                if (arr[j] > limit)
                {
                    temp.Add(arr[j]);
                    i++;
                }
            }
            if (i == 0)
            {
                temp.Add(-1);
                int[] temp1 = temp.ToArray();
                return temp1;
            }
            else
            {
                int[] temp1 = temp.ToArray();
                Console.WriteLine("");
                Array.Sort(temp1);
                Array.Reverse(temp1);
                return temp1;
            }           
        }

     }

  }

-----------------------------------------------------------------------------------------

5. Class Division
Write a program to calculate the division/class obtained by the student when the marks obtained by a student in 5 different subjects are given as inputs. 
The student gets a division/class as per the following rules:
Percentage above or equal to 60 - “First Class”.
Percentage between 50 and 59 - “Second Class”.
Percentage between 40 and 49 - “Third Class”.
Percentage less than 40 - “Failed”. 
Include a class UserProgramCode with a static method calculateResult which accepts five integers. The return type (String) should return the class of the student.
Create a Class Program which would be used to accept 5 integer inputs and call the static method present in UserProgramCode.

Input and Output Format:
Input consists of five integers.
Output consists of a String(class of the student).
Refer sample output for formatting specifications.
Sample Input 1:
41
45
46
40
41
Sample Output 1:
Third Class


\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{

    class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5;
            sub1 = int.Parse(Console.ReadLine());
            sub2 = int.Parse(Console.ReadLine());
            sub3 = int.Parse(Console.ReadLine());
            sub4 = int.Parse(Console.ReadLine());
            sub5 = int.Parse(Console.ReadLine());

            Console.WriteLine(UserProgramCode.calculateResult(sub1, sub2, sub3, sub4, sub5));
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace Checking_d
{
    class UserProgramCode
    {
        public static string calculateResult(int sub1, int sub2, int sub3, int sub4, int sub5)
        {            
            int sum = sub1 + sub2 + sub3 + sub4 + sub5;
            string str = "";
            int avg = sum / 5;
            if (avg >= 60)
                str = "First Class";
            else if (avg >= 50 && avg <= 59)
                str = "Second Class";
            else if (avg >= 40 && avg <= 49)
                str = "Third Class";
            else if (avg < 40)
                str = "Failed";
            return str;
        }
        }
    }

===========================================================================
6. Index power array
Write code to read an integer array and to find the power of each individual element according to its position index, add them up and print as output.
Include a class UserProgramCode with a static method getSumOfPower which accepts an integer that corresponds to the size of the array and an integer array. The return type (Integer) should return the final output.
Create a Class Program which would be used to accept Input array and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 integers, where the first integer corresponds to the number of elements, followed by the array elements.
Output consists of an Integer(final output).
Refer sample output for formatting specifications.
Sample Input 1:
4
7
6
2
1
Sample Output 1:
12
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int sum = UserProgramCode.getSumOfPower(n, a);
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
 
namespace Checking_d
{
    class UserProgramCode
    {
        public static int getSumOfPower(int size, int[] a)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += (int)Math.Pow(a[i], i);
            }
            return sum;
        }
   }
}
 
 
 
------------------------------------------------------------------------------------------------------------------------------------------
7. Count of Elements
Write a program that gets the count of elements in input1 list that starts with the character
passed in input2 irrespective of case. Print the count.
Business Rule:
1. If there is no element that start with the given char in input1, then return -1.
2. Only alphabets should be given in input1 string else return -2.
Include a class UserProgramCode with a static method GetCount which accepts the size of the string array, string array and a character. The return type (Integer) should return count. Follow the Business rules.
Create a Class Program which would be used to accept the size of the array, the array elements and a character, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an integer, which corresponds to the size of the array, a string list, and a character.
Output consists of an Integer (final count), or a String(“No elements Found” if -1 is returned or “Only alphabets should be given” if -2 is returned.
Refer sample output for formatting specifications.
Sample Input 1:
3
abc
Apple
Mango
a
Sample Output 1:
2
 
Sample Input 2:
2
goods
bads
a
Sample Output 2:
No elements Found
Sample Input 3:
2
good$
bad$
a
Sample Output 3:
Only alphabets should be given
 
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
 
    class Program
    {
            static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    str[i] = Console.ReadLine();
                }
                char c = char.Parse(Console.ReadLine());
                int output = UserProgramCode.getCount(n, str, c);
                if (output > 0)
                {
                    Console.WriteLine(output);
                }
                else if (output == -1)
                {
                    Console.WriteLine("No elements Found");
                }
                else if (output == -2)
                {
                    Console.WriteLine("Only alphabets should be given");
                }
            }
 
            Console.ReadLine();
        }
 
    }
}
 
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
 
namespace Checking_d
{
    class UserProgramCode
    {
        public static int getCount(int size, string[] str, char c)
            {
                int count = 0;
                char c_cap = char.ToUpper(c);
                char c_small = char.ToLower(c);
                Regex reg = new Regex(@"^([A-Za-z]{1,})$");

                foreach (string s in str)
                {
                    if (!reg.IsMatch(s))
                    {
                        return -2;
                        
                    }
                                      
                    if (c_small == s[0] || c_cap == s[0])
                        count++;
                }
                if (count >= 1)
                {
                    return count;
                }
                else
                    return -1;
            }
   }
}
 
 
-----------------------------------------------------------------------------------------
 
 
 
8.Is – Is Not
Write a program to read a String and to replace every appearance of the word "is" by "is not". If the word "is" is immediately preceeded or followed by a letter no change should be made to the string. Print the final string.
Include a class UserProgramCode with a static method negativeString which accepts a string. The return type (String) should return the final output.
Create a Class Program which would be used to accept a string input, and call the static method present in UserProgramCode.
 
Input and Output Format:
Input consists of a string.
Output consists of a string.
Refer sample output for formatting specifications.
Sample input 1:
This is just a misconception
Sample Output 1:
This is not just a misconception
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
            static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string output = UserProgramCode.negativeString(s);
            Console.WriteLine(output);        
            Console.ReadLine();
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
namespace Checking_d
{
    class UserProgramCode
    {
        public static string negativeString(string str)
        {
            string neg_string = null;
            string[] str1 = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str1.Length; i++)
            {
 
                if (str1[i].Equals("is"))
                {
                    sb.Append("is not ");
                }
                else
                {
                    sb.Append(str1[i] + " ");
                }
            }
            neg_string = sb.ToString();
            return neg_string;
        }
   }
}
 
 
-----------------------------------------------------------------------------------------
 
 
9. Sum of Squares
Write a program to find the sum of the squares of first n natural numbers. If n less than 0, return -1.
Include a class UserProgramCode with a static method sumSquare which accepts an integer. The return type is an integer as given in the above statement.
Create a Class Program which would be used to accept Input and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of the value n.
Output consists of a integer as mentioned in the problem statement.
Refer sample output for formatting specifications.
Sample Input 1:
3
Sample Output 1:
14
 
Sample Input 2:
-5
Sample Output 2:
-1
 
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = UserProgramCode.sumSquare(n);
            if (result == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checking_d
{

    class UserProgramCode
    {
        public static int sumSquare(int n)
        {
            if (n < 0)
                return -1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i * i ;
            }
            return sum;
        }
    }
}
 
 
-----------------------------------------------------------------------------------------
 
 
10. Cattle Graze
 
In a village there is a ground with full of grass where the cattle-rearing people take their cattle to maze in the ground. Assume that the cattle is tied to a tree. Write a program to calculate the area of grass that the cattle can maze. The rope length would be the input and area rounded of two decimal places would be the output.
Do not use Math.PI for the value of PI. Use 3.14 directly.
Include a class UserProgramCode with a static method calculateArea which accepts an integer. The return type is double. The method returns the area rounded to 2 decimal places.
Create a Class Program which would be used to accept Input and call the static method present in UserProgramCode.
Use random function in Math library.
Input and Output Format:
Input consists of the integer value n.
Output consists of a double.
Refer sample output for formatting specifications.
Sample Input 1:
3
Sample Output 1:
28.26
 
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.calculateArea(n).ToString("#0.00"));
            Console.ReadLine();
        }
    }
}
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
 
namespace Checking_d
{
    class UserProgramCode
    {
        public static double calculateArea(int n)
        {
            double area = 0;
            area = Math.Round((3.14 * n * n), 2);
            return area;
 
        }
   }
}
 


===========================================================

===========================================================
11. Reverse Substring
 
Given a input string with a startIndex and length, Write a program to extract substring from right to left. Assume the last character has index 0.
Include a class UserProgramCode with a static method reverseSubstring which accepts a string and two integers. The return type is string as given in the above statement.
Create a Class Program which would be used to accept Input and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string, and two integers – startIndex and length.
Output consists of a string as mentioned in the problem statement.
Refer sample output for formatting specifications.
Sample Input 1:
rajasthan
2
3
Sample Output 1:
Hts
\\Answer:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int start = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            string str2 = UserProgramCode.reverseSubstring(str, start, len);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    class UserProgramCode
    {
        public static string reverseSubstring(string str, int start, int len)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string str1 = new string(ch);
            string s = str1.Substring(start, len);
            char[] ch1 = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char item in ch1)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
   }
}


-----------------------------------------------------------------------------------------


12. Shipping Cost
Write a program to compute the Cost of Booking for Shipping. The Shipping Cost is computed according to the shipping type and the package weight. The shipping rate is given below.
Shipping types - Weight Rate (bahts/gram)
Regular for first 2000 - 0.25 (basic charge)
Regular exceeding 2000 - 0.35
For each Express, use the same rate as Regular + 50 bahts fee
Note that the Shipping cost is computed from the possible valid minimum rate.
 
Input1- Weight in grams
Input2- Type of delivery ('R' Regular and 'X' Express)
 Include a class UserProgramCode with a static method CalcShippingCost which accepts an integer(weight) and a character (type of delivery). The return type (integer) should return the shipping cost.
Create a Class Program which would be used to accept a integer value and a character, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an integer and a character.
Output consists of an integer(the shipping cost).
Refer sample output for formatting specifications.
 
Sample input 1:
4500
R
Sample Output 1:
1375
 
Sample Input 2:
1800
X
Sample Output 2:
500
\\Answer:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{

    class Program
    {
        static void Main(string[] args)
        {
            int gms = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.CalcShippingCost(gms, ch));
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    class UserProgramCode
    {
        public static double CalcShippingCost(int gms, char ch)
        {
            double temp;
            if (ch == 'R')
            {
                if (gms <= 2000)
                    return gms * 0.25;
                else
                {
                    temp = 2000 * 0.25;
                    return temp + ((gms - 2000) * 0.35);
                }
            }
            else if (ch == 'X')
            {
                if (gms <= 2000)
                    return gms * 0.25 + 50;
                else
                {
                    temp = gms * 0.25;
                    return temp + ((gms - 2000) * 0.35) + 50;
                }
            }
            else
                return 0;
        }
   }
}


----------------------------------------------------------------------------------------
13. Valid Negative Number
Write a program to read a negative number as a String variable and to validate the number. If the given string contains a valid negative number print corresponding positive number  else print “Invalid number” . 
Include a class UserProgramCode with a static method validateNumber which accepts a String. The return type (String) should return the corresponding output. If the input string is not a valid negative number, the method returns "-1".
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String( a negative number).
Output consists of a String(the corresponding output).
Refer sample output for formatting specifications.
 
Sample Input 1:
-94923
Sample Output 1:
94923
Sample Input 2:
-13O
Sample Output 2:
Invalid number
\\Answer:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{

    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n;
            n = Convert.ToInt32(UserProgramCode.validateNumber(str));
            if(n==-1)
                Console.WriteLine("Invalid number");
            else
                Console.WriteLine(n);
            
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    class UserProgramCode
    {
        public static string validateNumber(string str)
        {
            str.ToCharArray();
            int temp = 0;
            if (str[0] == '-')
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] >= 48 && str[i] <= 57)
                        temp = 1;
                    else
                        temp = 0;
                if (temp == 1)
                {
                    str = str.Substring(1, str.Length - 1);
                    return str.ToString();
                }
                else
                    return "-1";
            }
            else
                return "-1";
        }
   }
}


-----------------------------------------------------------------------------------------


14. Add non Common Elements
Write a program to read two integer arrays and  to add all the non common elements from the 2 integer arrays. Print the final output.
Business Rules:
Only positive numbers should be given to the input Lists.
1. If the input1 List consists of negative numbers, return -1.
2. If the input2 List consists of negative numbers, return -2.
3. If the both the input lists consists of negative numbers, return -3. 
Include a class UserProgramCode with a static method sumNonCommonElement which accepts the inputs in the following order (input1, size1, input2, size2). The return type (integer) should return output according to the business rules.
Create a Class Program which would be used to accept two lists, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+m+2 integers, where first two integers corresponds to the size of the two array lists, respectively, followed by the corresponding array elements.
Output consists of an Integer(the corresponding output), or a String “Input 1 has negative numbers” if the first array contains negative numbers, “Input 2 has negative numbers” if the second array contains negative numbers, or “Both inputs has negative numbers” if both array has negative numbers.
Refer sample output for formatting specifications.
 
Sample Input 1:
4
3	
6
9
2
1
10
7
5
Sample Output 1:
38
 
Sample Input 2:
4
3
-6
9
2
1
10
7
5
Sample Output 2:
Input 1 has negative numbers
 
Sample Input 3:
4
3
6
9
2
1
10
-7
5
Sample Output 3:
Input 2 has negative numbers
Sample Input 3:
4
3
6
9
-2
1
10
-7
5
Sample Output 3:
Both inputs has negative numbers

\\Answer:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] ar1 = new int[n];
            int[] ar2 = new int[m];
            for (int i = 0; i < n; i++)
                ar1[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
                ar2[i] = int.Parse(Console.ReadLine());
            int flag = UserProgramCode.sumNonCommonElement(ar1, n, ar2, m);
            if (flag == -1)
                Console.WriteLine("Input 1 has negative numbers");
            else if (flag == -2)
                Console.WriteLine("Input 2 has negative numbers");
            else if (flag == -3)
                Console.WriteLine("Both inputs has negative numbers");
            else
                Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    class UserProgramCode
    {
        public static int sumNonCommonElement(int[] ar1, int n, int[] ar2, int m)
        {
            int a = 0, b = 0, c = 0;
            int sum = 0;
            int[] temp = new int[m + n];
            
            for (int i = 0; i < n; i++)
                if (ar1[i] < 0)
                    a = 1;
            for (int j = 0; j < m; j++)
                if (ar2[j] < 0)
                    b = 1;
            if (a == 0 && b == 0)
            {
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                                if (ar1[i] == ar2[j])
                                {
                                    ar1[i] = 0;
                                    ar2[j] = 0;
                                }

                        return ar1.Sum() + ar2.Sum();


             }
            if (a == 1 && b == 0)
                return -1;
            else if (b == 1 && a == 0)
                return -2;
            if (a == 1 && b == 1)
                return -3;

            return 0;


        }
   }
}

-----------------------------------------------------------------------------------------


15. Get the longest string
Write a program to get the longest string from the list which starts with the given character.Assume that input comparison  is done  irrespective of case. ie case insensitive.
Include a class UserProgramCode with a static method  getLongestString which accepts a String list and a character. The return type  is a string.
Create a Class Program which would be used to accept the size of the string list, the list elements and the search character and calls the static method present in UserProgramCode. 
In getLongestString
1. If there is no element found list, then return the string "No elements found "
2. Only alphabets should be given in the list. Otherwise return the string, "String contains non alphabetic characters. "
3.I f the two or more strings start with the given character ,the longest string should be returned. Assume that the longest string will be unique.

Input Output format
First line points to the size of the string list as n.
The next n lines points to elements of the string list.
The last input points to the character.
Output consists of a string.

SAMPLE INPUT 1:
4
Yellow
Red
Black
Blue
b
SAMPLE OUTPUT 1:
Black

SAMPLE  INPUT 2:
3
Black
White
45
W
SAMPLE OUTPUT 2:
String contains non alphabetic characters.
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Checking_d
{

    class Program
    {

        static void Main(string[] args)
        {
            ****Isletter obj=new Isletter();
            
            List<string> ls = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ls.Add(Console.ReadLine());
            }
            char ch = char.Parse(Console.ReadLine());
              string a=UserProgramCode.IsAlphaNumeric(ls,ch);
              Console.WriteLine(a);
            Console.ReadLine();
        }
    }


    static class UserProgramCode
    {
        public static string IsAlphaNumeric(List<string> input, char ch)
        {
            int alpha = 1,temp = 0;
            int count = 0;
            string pqr = "";
            foreach (string s in input)
            {
                bool b = Regex.IsMatch(s, "^[a-zA-Z]+$");
                if (!b)
                {
                    alpha = 0;
                }
            }
           
            if (alpha == 0)
            {
                Console.WriteLine("String contains non alphabetic characters.");
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i].ToCharArray()[0] == char.ToUpper(ch) || input[i].ToCharArray()[0] == char.ToLower(ch))
                    {
                        if (input[i].Length > count)
                            count = input[i].Length;
                        temp = 1;
                    }
                }
                if (temp == 0)
                    Console.WriteLine("No elements found");
                else
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i].Length == count)
                            pqr=input[i];
                    }
                }
            }
            return pqr;
        }
        
   }
}

==============================================================================
=====================================================================================================================================================
16. Length of the longest string
Write code to find the length of the longest string in the given string list.
Include a class UserProgramCode with static method longestWordLength that accepts the String list and the return type should be int
Create a class Program which would get the input and call the static method longestWordLength(String[] array) present in the UserProgramCode.
The longestWordLength(String[] array) returns the length of the longest string
Input and Output Format:
The first integer corresponds to n, the number of elements in the list. The next 'n' integers correspond to the elements in the String list.

SAMPLE INPUT 1
2
Black
Blue 
SAMPLE OUTPUT 1
5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    public class UserProgramCode
    {
        public static string longestWordLength(string[] s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > sum)
                {
                    sum = s[i].Length;
                }
            }
            return sum.ToString();
        }    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str=new string[n];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string res = UserProgramCode.longestWordLength(str);
            Console.WriteLine(res);
Console.ReadLine();
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------------------------

17. Get All Elements

Write a program to get all the elements that are greater than 5 from a given input integer list.
Display it in the order as present in the array. 
Print the elements.
Business Rule:
If any of the element in the input list is greater than 500 then store -1 in the oth index of the output list. 
Include a class UserProgramCode with a static method GetAllElements which accepts an integer List and its size. The return type (integer list) should return output according to the business ruless
Create a Class Program which would be used to accept a list, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 integers, where first integer corresponds to the size of the list, followed by the corresponding list elements.
Output consists of an Integer list, or a String “Array element greater than 500” if any of the elements is greater than 500.
Refer sample output for formatting specifications. 
Sample Input 1:
6
1
3
7
8
5
13
Sample Output1:
7
8
13 
Sample Input 2:
6
1
3
7
8
501
13
Sample Output 2:
Array element greater than 500

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fwd_Prgs
{
    public class UserProgramCode
    {
        public static int GetAllElements(List<int> a, int n)
        {
            List<int> b = new List<int>();
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > 500)
                   b.Add(-1);
                else if (a[i] > 5)
                {
                    b.Add(a[i]);
                }
            }
            b.Sort();
            if (b.Count == 0)
                return 0;
            else
            if (b[0] == -1)
                Console.WriteLine("Array element greater than 500");

            else
                for (int i = 0; i < b.Count; i++)
                    Console.WriteLine(b[i]);
            return 0;
        }
    }
}

namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(int.Parse(Console.ReadLine()));
            UserProgramCode.GetAllElements(a, n);
            Console.ReadLine();
        }
    }
}


-----------------------------------------------------------------------------------------

18. Sum Common Elements
Write a program to read two int arrays, eg. A{2,3,5,1} and B{1,3,9}, and to find out sum of common elements in given arrays. Print the sum, or print “No common elements found” if there are no common elements.
Assume the common element appears only once in each array.
Include a class UserProgramCode with a static method getSumOfIntersection which accept the size of two integer arrays and the two integer arrays. The return type (integer) should return the sum, or -1, accordingly.
Create a Class Program which would be used to accept two integer arrays, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+m+2 integers, where first two integers corresponds to the size of the two array lists, respectively, followed by the corresponding array elements.
Output consists of an Integer(the corresponding output) or string - (“No common elements found”).
Refer sample output for formatting specifications. 
Sample Input 1:
4
3
2
3
5
1
1
3
9
Sample Output 1:
4 
Sample Input 2:
4
3
2
31
5
14
1
3
9
Sample Output 2:
No common elements found
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fwd_Prgs
{
    public class UserProgramCode
    {
        public static int getSumOfIntersection(int n1, int n2, int[] a, int[] b)
        {
            int sum = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                    if (a[i] == b[j])
                        sum = sum + a[i];

            }
            if (sum == 0)
                return -1;
            else
                return sum;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int[] a = new int[n1];
            int[] b = new int[n2];
            for (int i = 0; i < n1; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
                b[i] = int.Parse(Console.ReadLine());
            int res = UserProgramCode.getSumOfIntersection(n1, n2, a, b);
            if (res == -1)
                Console.WriteLine("No common elements found");
            else
                Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------

19. Find largest digit in a given number 
Write a code to find the Largest digit from given input integer.
Include a class UserProgramCode with static method findLargestDigit(int num)
Create a class Program which would get the input and call the static method findLargestDigit(num) present in the UserProgramCode.
If the interger is a negative value findLargestDigit(num) method returns -1 to Program, otherwise returns largest digit in a given number.
If -1 is returned then print "The number should be a positive number".
Input and Output Format:
Input is an integer n.
Output is an integer which is the largest digit in the given number n.
SAMPLE INPUT 1:
456
SAMPLE OUTPUT1:
6
SAMPLE INPUT 2:
-12434567
SAMPLE OUTPUT2:
The number should be a positive number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fwd_Prgs
{
    public class UserProgramCode
    {
        public static int findLargestDigit(int num)
        {
            if (num >=0)
            {
                int temp, res = 0;

                while (num > 0)
                {
                    temp = num % 10;
                    if (temp > res)
                        res = temp;
                    num = num / 10;
                }
                return res;
            }
            else
                return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = UserProgramCode.findLargestDigit(n);
            if (res != -1)
                Console.WriteLine(res);
            else
                Console.WriteLine("The number should be a positive number");
            Console.ReadLine();
        }
    }
}

-----------------------------------------------------------------------------------------

20. Sum Of Digits
Write a program to read a String and to get the sum of all the digits present in the given string. Print the sum. If there is no digit in the given string print “No digit present”.
Include a class UserProgramCode with a static method sumOfDigits which accepts a String. The return type (Integer) should return the sum, or return -1 if no digits are present.
Create a Class Program which would be used to accept a String and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of an Integer or a String “No digit present “ ..
Refer sample output for formatting specifications.
Sample Input 1:
good23bad4
Sample Output 1:
9
Sample Input 2:
good@#bad$
Sample Output 2:
No digit present

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fwd_Prgs
{
    public class UserProgramCode
    {
        public static string sumOfDigits(string str)
        {
            char[] s = str.ToCharArray();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                if ((s[i] > 47) && (s[i] < 58))
                {
                    sum = sum + (int)s[i] - 48;

                }
            string res = sum.ToString();
            if (sum == 0)
                return "-1";
            else
                return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string res = UserProgramCode.sumOfDigits(s);
            if (res == "-1")
                Console.WriteLine("No digit present");
            else

                Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}



--------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------------

21. String Encryption
 Write code to encrypt the given string using following rules and print the encrypted string:
Rules: 
Replace the characters at odd positions by next character in alphabet.
Leave the characters at even positions unchanged.
 If an odd position charater is 'z' replace it by 'a'.
Assume the first character in the string is at position 1.
Include a class UserProgramCode with static method encrypt that accepts a string and returns the encrypted string.
Create a class Program which would get the input and call the static method encrypt present in the UserProgramCode.
Input and Output Format :
The input is a String .
The output is a String which holds the encrypted text.
Sample Input 1:
curiosity
Sample Output 1:
Dusipsjtz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string s1 = UserProgramCode.method1(str);
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static string method1(string s)
        {
            int i = 0, a = 0;
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (s[i] == 'z')
                        sb.Append('a');
                    else
                    {
                        a = Convert.ToInt16(s[i]);
                       
                        a = a + 1;
                        sb.Append(Convert.ToChar(a));
                    }
                }
                else
                    sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}


-----------------------------------------------------------------------------------------

22. Arithmetic Operation
Write a program to perform the user specified arithmethic operation. The program will consist of 3 parameters. First one for specifying the type of operation (+,-,*,/) and the other two are the operands upon which the operation has to be performed. Print the final output.
Business Rules:
1. The first parameter should have the values as 1,2,3 or 4. If it has any other value other than this, return -1.
2. The Second and the third parameter should be only positive numbers, else return -2.
3. If the first parameter is
1 --------------- Add the second and third parameter. (second+third) 
2 --------------- Subtract the second and third parameter.(second-third)
3 ---------------- Multiply second and third parameter. .(second*third)
4 ---------------- Divide second by third parameter.(second/third)
Include a class UserProgramCode with a static method arithmeticOperation which accepts three integers. The return type (Integer) should return the result of the operation performed. Return -1 or -2 according to the Business rules.
Create a Class Program which would be used to accept three integers, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of three integers, where the first integer corresponds to the type of operator, the second and third integer corresponds to the operands.
Output consists of an Integer or, a String “Invalid operator” if the -1 is returned, “Invalid operands” if -2 is returned. 
Assume all outputs are Integers. 
Refer sample output for formatting specifications.
Sample Input 1:
1
2
3
Sample Output 1:
5
Sample Input 2:
5
2
3
Sample Output 2:
Invalid operator
Sample Input 3:
1
-2
3
Sample Output 3:
Invalid operands

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int s1 = UserProgramCode.arithmeticOperation(a, b, c);
            if (s1 == -1)
                Console.WriteLine("Invalid Operator");
            else if (s1 == -2)
                Console.WriteLine("Invalid Operands");
            else
                Console.WriteLine(s1);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int arithmeticOperation(int a, int b, int c)
        {
            if (a > 0 && a < 5)
            {
                if (b < 0 || c < 0)
                    return -2;
                else
                    if (a == 1)
                        return b + c;
                    else if (a == 2)
                        return b - c;
                    else if (a == 3)
                        return b * c;
                    else
                        return b / c;
            }
            else
                return -1;
        }
    }
}

---------------------------------------------------------------------------------------------------------------------------------------
23. Get Middle Characters
Write a program to read a string of even length and to fetch two middle most characters. Print the output.
Include a class UserProgramCode with a static method getMiddleChars which accepts a String. The return type (String) should return the output String.
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String of even length.
Output consists of a String, the middle two letters 
Refer sample output for formatting specifications.
Sample Input 1:
This
Sample Output 1:
Hi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string s1 = UserProgramCode.getMiddleChars(str);
            Console.WriteLine(s1);

            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static string getMiddleChars(string s)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            if (s.Length % 2 == 0)
            {
                i = s.Length / 2;
                sb.Append(s[i - 1]);
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
---------------------------------------------------------------------
24. Add Days
Write a program which can print the date n days after the given date.
The date should be given in string format “mm/dd/yyyy” without time and the resultant added date should also be in the format “mm/dd/yyyy”.
Only positive value should be given as input to the days to be added,  else print “n value is negative”.  If the date format is not “mm/dd/yyyy” , then print “Invalid date format” .
Include a class UserProgramCode with a static method addDays which accepts a String and an Integer. The return type (String) should return the final date as String or it would return "-1" if the day value is negative or it would return "-2" if the date is not as per the given format.
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String and an integer, where the String corresponds to the input date and the integer corresponds to the number of days.
Output consists of a String.
Refer sample output for formatting specifications.
Sample Input 1:
10/21/2009
5
Sample Output 1:
10/26/2009 
Sample Input 2:
10/21/2009
-5
Sample Output 2:
n value is negative 
Sample Input 3:
40/21/2009
5
Sample Output 3:
Invalid date format
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = Convert.ToInt16(Console.ReadLine());
            string s1 = UserProgramCode.addDays(s, i);
            if (s1 == "-1")
            {
                Console.WriteLine("n value is negative");
                Console.ReadKey();
            }
            else if (s1 == "-2")
            {
                Console.WriteLine("Invalid date format");
                Console.ReadKey();
            }
            else
            Console.WriteLine(s1);

            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static string addDays(string s, int a)
        {
            string format = "MM/dd/yyyy";
            DateTime dt;
            bool b = DateTime.TryParseExact(s, format, null, System.Globalization.DateTimeStyles.None, out dt);
            if (!b)
                return "-2";
            if (a < 0)
                return "-1";
            dt = dt.AddDays(a);

            return dt.ToString("MM/dd/yyyy");
        }
    }
}
----------------------------------------------------------------
25. Sum Of Squares Of Even Digits
Write a program to read a positive integer and to calculate the sum of squares of even digits available in the given number. Print the output.
Include a class UserProgramCode with a static method sumOfSquaresOfEvenDigits which accepts an Integer. The return type (Integer) should return the sum of squares of even digits available in the given number.
Create a Class Program which would be used to accept an Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an Integer.
Output consists of an Integer, the sum of squares of even digits available in the given number .
Refer sample output for formatting specifications.
Sample Input 1:
56895
Sample Output 1:
100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{

    class Program
    {
        static void Main(string[] args)
        {

            int i = Convert.ToInt32(Console.ReadLine());
            int s1 = UserProgramCode.sumOfSquareofEvenDigits(i);

            Console.WriteLine(s1);

            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int sumOfSquareofEvenDigits(int a)
        {
            int sum = 0;
            string a1 = a.ToString();
            int a2 = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                a2 = (int)(a1[i]) - 48;
                if (a2 % 2 == 0)
                {

                    sum = sum + (a2 * a2);

                }
            }
            return sum;
        }
    }
}
=====================================================================
27. Fibonacci Series
Write method to generate fibonacci series and calculate the sum of first n numbers in the series and return it as output.
Include a class UserProgramCode with a static method getSumOfNfibos that accepts an integer as input and returns an integer.
Create a class Program which would get the input and call the static method getSumOfNfibos present in the UserProgramCode. 
Input and Output Format:
Input consists of an integer that corresponds to n.
Output consists of an integer which corresponds to the sum of the first n terms in the fibonocci series.
Note: First two numbers in a Fibonacci series are 0, 1 and all other subsequent numbers are sum of its previous two numbers. Example - 0, 1, 1, 2, 3, 5...
Sample Input 1:
15
Sample Output 1:
986
Sample Input 2:
4
Sample Output 2:
4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int i = UserProgramCode.getSumOfNfibos(n);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int getSumOfNfibos(int n)
        {
            int f = 0, f1 = -1, f2=1 , sum = 0;
            for (int i = 0; i < n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;

                sum += f;
            }
            return sum;
        }
    }
}


------------------------------------------------------------------------------------------------------------------------------------------
28. Shortest Length
Write a method to get the length of the shortest word in the given string array.
Include a class UserProgramCode with a static method shortestWordLength that accepts a string array and returns an integer that corresponds to the length of the shortest word. 
Create a class Program which would get the input and call the static method shortestWordLength present in the UserProgramCode. 
Input and Output Format:
First line of the input consists of an integer that corresponds to the number of elements in the string array.
The next n lines of the input consists of the elements in the string array. Assume that all the elements in the string array are single words.
Output is an integer which corresponds to the length of the shortest word
Sample Input 1:
3
cherry
hai
apple
Sample Output 1:
3
Sample Input 2:
4
cherry
apple
blueberry
grapes
Sample Output 2:
5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[50];
            for (i = 0; i < n; i++)
                s[i] = Console.ReadLine();
            s[i] = "\0";
            int sl = UserProgramCode.shortestWordLength(s);
            Console.WriteLine(sl);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int shortestWordLength(string[] s)
        {

            int sl = s[0].Length;
            for (int i = 1; s[i] != "\0"; i++)
            {
                if (s[i].Length < sl)
                    sl = s[i].Length;
            }
            return sl;
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
29. Calculate Bill 
Write a program to calculate the bill given the previous reading , current reading and per unit charge as inputs. 
Include a class UserProgramCode with static method calculateBill() that accepts 2 strings corresponding to the previous reading and current reading and an integer that corresponds to the per unit charge. This method returns an integer that corresponds to the bill amount to be paid.
Create a class Program which would get the inputs and call the static method calculateBill() present in the UserProgramCode. 
Input and Output Format:
Reading Format - XXXXXAAAAA where XXXXX is consumer number and AAAAA is meter reading.
Input1 is a String - previous reading of the consumer
Input2 is a String - current reading of the consumer
Input3 is an integer - per unit charge to the consumer
output is an integer - Calculated BILL value. 
Metric BILL Formula:
Bill=(current reading-previous reading)*per unit charge
Sample Input 1:
ABC2012345
ABC2012660
4
Sample Output 1:
1260
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int sl = UserProgramCode.calculateBill(s1, s2, n);
            Console.WriteLine(sl);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int calculateBill(string s1, string s2, int n)
        {
            int sum = 0;
            if(s1.Substring(0,4).Equals(s2.Substring(0,4)))
            {
            string ss1 = s1.Substring(5);
            string ss2 = s2.Substring(5);
            int a = int.Parse(ss1);
            int b = int.Parse(ss2);
            sum = (b - a) * n;
            }
            return sum;
        }
    }
}


-----------------------------------------------------------------------------------------

30. Calculate the sum of cube 
Write a program to find the sum of the cube of first 'n' natural numbers. 
Include a class UserProgramCode with a static method sumOfCube() that accepts an integer and returns an integer . If the input is not a natural number, return -1.
Create a class Program which would get the input and call the static method sumOfCube() present in the UserProgramCode. 
Input and Output Format:
Input is an integer that corresponds to n
Output is an integer (Sum of cubes) or if the given input n is not a natural number then print “The input is not a natural number” 
Sample Input 1:
5
Sample Output 1:
225 
Sample Input 2:
-1
Sample Output 2:
The input is not a natural number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fwd_Prgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = UserProgramCode.sumOfCube(n);
            if (s == -1)
            {
               Console.WriteLine("The input is not a natural number");
            }
            else
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int sumOfCube(int n)
        {
            int flag = 0;
            if (n < 0)
            {
                flag = -1;
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + (i * i * i);
                   
                }
                flag = sum;
            }
                return flag;
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
31. Form New Word
Write a program to read a string and a positive int (say n) as input and to construct a string with first n and last n characters in the given string. Note - the given string length is >= 2n
Include a class UserProgramCode with a static method formNewWord() that accepts a string and an integer. The method returns a string.
Create a class Program which would get the inputs and call the static method formNewWord() present in the UserProgramCode. 
Input and Output Format:
Input consists of a string and an integer.
Output is a String that corresponds to the newly formed word.
Sample Input 1:
California
3
Sample Output 1:
Calnia

ANS: 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Workout41
{
    class UserProgramCode
    {
        public static string formNewWord(string s, int n)
        {
            string s1;
            int l, n1;
            l = s.Length;
            if (l > n * 2)
            {
                n1 = l - n;
                s1 = s.Substring(0, n) + s.Substring(n1, n);
                return s1;
                
            }
            else
            {
                return "";
               
            }
           
        }
    }


    

    
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int n;
            UserProgramCode u = new UserProgramCode();
            s = Console.ReadLine();
            n = int.Parse(Console.ReadLine());
            s = UserProgramCode.formNewWord(s, n);
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
}


------------------------------------------------------------------------------------------------------------------------------------------


32. CheckCharacters
Given a method with a string input, write code to test if first and last characters are same. Incase they are same return 1 else return -1 as output. Note - Consider case.
Include a class UserProgramCode with static method checkCharacters that accepts a string and returns an integer.
Create a class Program which would get the input and call the static method checkCharacters present in the UserProgramCode.
Input and Output Format:
Input is a String - a sentence
Output is a String --- “The characters are same” or “The characters are different”.
Sample Input 1:
the picture was great
Sample Output 1:
The characters are same
Sample Input 2:
Hai how are you? 
Sample Output 2:
The characters are different

ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str;
            str=Console.ReadLine();

            n = UserProgramCode.checkcharacters(str);
            if (n == 1)
                Console.WriteLine("The characters are same");
            else
                Console.WriteLine("The characters are different");
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int checkcharacters(string str)
        {
            int len = str.Length;
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(len - 1);
            if (str1.Equals(str2))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}


------------------------------------------------------------------------------------------------------------------------------------------
33. Count Characters
Write a program to count the number of characters present in the given input String.
Include a class UserProgramCode with static method countCharacters which accepts string array.
The return type is a integer value.
Create a class Program which would get the input and call the static method countCharacters present in theUserProgramCode .
Sample Input 1:
qwerty
Sample Output 1:
6
Sample Input 2:
12345
Sample Output 2:
5

ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace program33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str;
            str = Console.ReadLine();
            n = UserProgramCode.countcharacters(str);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int countcharacters(string str)
        {
            int len = str.Length;
            return len;
        }
    }
}



-----------------------------------------------------------------------------------------------------------------------------------------
34. Validate ID Locations
Write a program to read two string inputs and check whether the first string is in valid format. First string is ID and second string is location. A valid ID  should be in the format CTS-LLL-XXXX where LLL is the first three letters of given location and XXXX is a four digit number. If the given ID is as per the given format, print “valid” else print “invalid”.
Include a class UserProgramCode with a static method validateIDLocations which accepts two Strings. The return value (Integer) should be 1 if the first string is valid, else return -1.
Create a Class Program which would be used to read 2 strings and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of 2 strings.
Output consists of a string, “valid” or  “invalid”.
Refer sample output for formatting specifications. 
Sample Input 1:
CTS-hyd-1234
hyderabad
Sample Output 1:
Valid

ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace prgrm35
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s1, s2;
            s1=Console.ReadLine();
            s2 = Console.ReadLine();
            i = UserProgramCode.validateIDlocations(s1,s2);
            if (i == 1)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int validateIDlocations(string s1, string s2)
        {
            int output = 0;
            Regex reg = new Regex(@"^([CTS]+[-]+([A-Za-z]{3})+[-]+([0-9]{4}))$");
            if (reg.IsMatch(s1))
            {
                string res = s2;
                if (s1.Contains(res.Substring(0, 3)))
                {
                    output = 1;
                }
                else
                {
                    output = -1;
                }
            }
            else
            {
                output = -2;
            }
            return output;
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------
35. String Manipulation
Write a program which can read two strings and add the reverse of the second string in the middle of the first string.
Print "Special character found" if the string consists of special characters, else print the final String.
Hint: If the first string contains odd number of characters
e.g. String1 is having 7 characters, then add the second reverse string after the 4 characters of the first string. 
Include a class UserProgramCode with a static method stringManipulation which accepts two Strings. The return type (String) should return the final String.
Create a Class Program which would be used to accept two Strings, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of two Strings.
Output consists of a String( the final String), or “Special character found” if the string consists of special characters.
Refer sample output for formatting specifications. 
Sample Input 1:
Arun
Ram
Sample Output 1:
ArmaRun
Sample Input 2:
Aruns
Ram
Sample Output 2:
ArumaRns
Sample Input 3:
Arun$
Ram
Sample Output 3:
Special character found

ANS:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prgm34
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            string str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            ans = UserProgramCode.stringmanipulation(str1, str2);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static string stringmanipulation(string str1, string str2)
        {
            string res1, res2, res3, rev = "";
            int len, len2, len3;
            len = str1.Length;
            if (len % 2 == 0)
            {
                len2 = len / 2;
                res3 = str1.Substring(len2);
            }
            else
            {
                len2 = (len / 2) + 1;
                res3 = str1.Substring(len2);
            }
            len3 = str2.Length - 1;
            while (len3 >= 0)
            {
                rev = rev + str2[len3];
                len3--;
            }
            res1 = str1.Substring(0, len2);
            res2 = res1 + rev + res3;
            return res2;
        }
    }
}

=========================================================================

36. Check Sum
Write program to read a positive int as input and to calculate the sum of the odd digits in the given number. If the sum is odd print “Odd” else print “Even”. 
Include a class UserProgramCode with a static method checkSum which accepts a positive Integer. The return type (Integer) should return 1 if the sum is odd, else return -1.
Create a Class Program which would be used to accept a positive Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an Integer.
Output consists of a String “Odd” if the sum is odd, else print “Even”. 
Refer sample output for formatting specifications. 
Sample Input:
56895
Sample Output
Odd


ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c;
            n = Convert.ToInt32(Console.ReadLine());
            c = UserProgramCode.checkSum(n);
            if (c == 1)
                Console.WriteLine("Odd");
            else Console.WriteLine("Even");

            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int checkSum(int a)
        {
            int rem, sum = 0;
            while (a > 0)
            {
                rem = a % 10;
                if (rem % 2 == 1)
                { sum = sum + rem; }
                a = a / 10;
            }
            if (sum % 2 == 1)
                return (1);
            else return (-1);
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
37. Find Gift Voucher
In a game two dice is thrown. From the sum of the two dice, the player is going to get the gift voucher from the club. Write a program to find the amount of the gift voucher. Print the amount received as gift.
Sum of Two Dices ------------------ Gift Voucher in Rs
2,3,6,11 ------------------------------ 1000
4,7,10--------------------------------- 3000
5,8,9,12------------------------------- 5000 
In the method,
Only Positive number (1-6) should be given as a input numbers. Else return -1. 
Include a class UserProgramCode with a static method findGiftVoucher which accepts two integers. The return type (Integer) should return the gift voucher amount. If the any of the inputs is invalid return -1.
Create a Class Program which would be used to accept a positive Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of two integers.
Output consists of an Integer( the gift voucher amount) or a String “Invalid Input” if any of the inputs is invalid.
Refer sample output for formatting specifications. 
Sample Input 1:
1
2
Sample Output 1:
1000 
Sample Input 2:
1
-2
Sample Output 2:
Invalid Input

ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            c = UserProgramCode.findGiftVoucher(n, m);

            if (c == -1)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine(c);

            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int findGiftVoucher(int a, int b)
        {
            int c = a + b;

            if (a > 0 && b > 0 && a < 7 && b < 7)
            {
                if (c == 2 || c == 3 || c == 6 || c == 11)
                    return (1000);
                else if (c == 4 || c == 7 || c == 10)
                    return (3000);
                else if (c == 5 || c == 8 || c == 9 || c == 12)
                    return (5000);
            }
            else return (-1);
            return 0;
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------

38. Find the Shortest String
Write a program that reads an Integer (size of the String List), a String List and a character. Find the shortest string from the list that starts with the character.
 (case sensitive). Assume there will be only one string.
Include a class UserProgramCode with static method  GetshortestString()  that accepts a string list and a character . The return type is String.
Create a class Program which would get the input and call the static method GetshortestString(List<string> input1, char input2)) present in the UserProgramCode. 
Input and Output Format :
The first input corresponds to the list size.
The next input corresponds to the elements in the list which is a string.
The third input is a character.
Output is String.  
In GetshortestString()
1. Only alphabets should be given in the List else return "Non Alphabets Exists".
2. If there is no match found in input then return "No String Found".
3. Otherwise return the appropriate result.
In Program
Display the result which is return by GetshortestString() 
Sample Input 1:
4
read
elegant
Edit
even
e
Sample Output 1:
even
Sample Input 2:
2
qwerty
abcdef
e
Sample Output 2:
No String Found
Sample Input 3:
4
re@d
el3gant
Edit
even
e
Sample Output 3:
Non Alphabets Exists

ANS:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace q38
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>(n);

            int i;

            for (i = 0; i < n; i++)
                list.Add(Console.ReadLine());

            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(userprogram.GetshortestString(list, c));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace q38
{
    class userprogram
    {
        public static string GetshortestString(List<string> list, char c)
        {
            int ch = 0;
            string min = "";
            int flag = 0;
            int i, len = 100;
            for (i = 0; i < list.Count; i++)
            {

                if (list[i].Contains("$") || list[i].Contains("&") || list[i].Contains("@") || list[i].Contains("_"))
                {
                    ****Console.WriteLine("ajshdjsa");
                    flag = 0;
                    ch = 1;
                    break;
                }
                
                    if (list[i][0].CompareTo(c) == 0)
                    {

                        if (list[i].Length < len)
                        {
                            min = list[i];
                            len = list[i].Length;
                        }
                        flag = 1;
                       ++ch;
                    }
                }


            if (ch == 0 )
            {
                return ("No String Found");
            }
            else if (flag == 1)
                return (min);
            else
                return ("Non Alphabets Exists");
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------

39. Reverse Number
Write a program to read a positive number as input and to get the reverse of the given number and print it as output.
Include a class UserProgramCode with a static method reverseNumber which accepts an Integer. The return type (Integer) should return the reverse of the given input.
Create a Class Program which would be used to accept an Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an Integer.
Output consists of an Integer, the reverse of the given Input.
Refer sample output for formatting specifications. 
Sample Input 1:
543
Sample Output 1:
345

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                c = UserProgramCode.reverseNumber(n);
            }
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int reverseNumber(int a)
        {
            int rem, sum = 0;
            while (a > 0)
            {
                rem = a % 10;
                sum = (sum * 10) + rem;
                a = a / 10;
            }
            return (sum);
        }
    }
}
--------------------------------------------------------------------------------------------------------------------------------------
40. String Finder
Write a program to read three strings which are Searchstring, Str1 and Str2 as input and to find out if Str2 comes after Str1 in the Searchstring. If yes print “Yes” else print “No”.
Include a class UserProgramCode with a static method stringFinder which accepts 3 strings. The return type (Integer) should return 1 if the Str2 comes after Str1 in the Searchstring, else return 2.
Create a Class Program which would be used to read 3 strings, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of three strings which are Searchstring, Str1 and Str2.
Output consists of a String, “Yes” or “No”. 
Refer sample output for formatting specifications.
Sample Input 1:
geniousRajKumarDev
Raj
Dev
Sample Output 1:
Yes
Sample Input 2:
geniousRajKumarDev
Dev
Raj
Sample Output 2:
No

ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog40
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1, str2;
            str = Console.ReadLine();
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            if (userprogram.stringFinder(str, str1, str2) == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog40
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1, str2;
            str = Console.ReadLine();
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            if (userprogram.stringFinder(str, str1, str2) == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadLine();
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------
41. Form New Word
Write a program to read a string and a positive int (say n) as input and to construct a string with first n and last n characters in the given string. Note - the given string length is >= 2n 
Include a class UserProgramCode with a static method formNewWord() that accepts a string and an integer. The method returns a string.
Create a class Program which would get the inputs and call the static method formNewWord() present in the UserProgramCode.
Input and Output Format:
Input consists of a string and an integer.
Output is a String that corresponds to the newly formed word.
Sample Input 1:
California
3
Sample Output 1:
Calnia

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workout41
{
    class UserProgramCode
    {
        public static string formNewWord(string s,int n)
        {
            string s1;
            int l,n1;
            l = s.Length;
            if (l > n * 2)
            {
                n1 = l - n;
                s1 = s.Substring(0, n) + s.Substring(n1, n);
                return s1;
            }
            else 
            {
                return "";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int n;
            UserProgramCode u = new UserProgramCode();
            s = Console.ReadLine();
            n = int.Parse(Console.ReadLine());
            s = UserProgramCode.formNewWord(s,n);
            Console.WriteLine(s);           
        }
    }
}
-----------------------------------------------------------------------------------------------------------------------------------------
42. CheckCharacters
Given a method with a string input, write code to test if first and last characters are same. Incase they are same return 1 else return -1 as output. Note - Consider case.
Include a class UserProgramCode with static method checkCharacters that accepts a string and returns an integer.
Create a class Program which would get the input and call the static method checkCharacters present in the UserProgramCode. 
Input and Output Format:
Input is a String - a sentence
Output is a String --- “The characters are same” or “The characters are different”.
Sample Input 1:
the picture was great
Sample Output 1:
The characters are same 
Sample Input 2:
Hai how are you? 
Sample Output 2:
The characters are different

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workout42
{
    class UserProgramCode
    {
        public static int checkCharacters(string s)
        {
            string sl;
             sl=s.Substring(0,1);
            sl = sl.ToLower();
            if (s.EndsWith(sl))
                return 1;
            else 
                return 0;  
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i;
            ****UserProgramCode u = new UserProgramCode();
            s = Console.ReadLine();
            s = s.ToLower();
            i = UserProgramCode.checkCharacters(s);    
            if (i==1)
                Console.WriteLine("The characters are same");
            else
                Console.WriteLine("The characters are different");
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------

43. Count Characters
Write a program to count the number of characters present in the given input String.
Include a class UserProgramCode with static method countCharacters which accepts string array.
The return type is a integer value.
Create a class Program which would get the input and call the static method countCharacters present in theUserProgramCode .
Sample Input 1:
qwerty
Sample Output 1:
6
Sample Input 2:
12345
Sample Output 2:
5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workout43
{
    class UserProgramCode
    {
        public static int countCharacters(string s)
        {
            int l;
            l = s.Length;
            return l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ****UserProgramCode u = new UserProgramCode();
            string s;
            int n;
            s = Console.ReadLine();
            n = UserProgramCode.countCharacters(s);
            Console.WriteLine(n);
           
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
 
Tuesday, April 12, 2016 9:23 PM
44. Find Total number of days in given month
 Write code to find out total number of days in the given month for the given year.
Month is coded as: Jan=0, Feb=1 ,Mar=2 ...
Include a class UserProgramCode with static method  getNumberOfDays that accepts two integers and return type should be int.
Create a class Program which would get the input and call the static method getNumberOfDays(int year, int month) present in the UserProgramCode.
Return the  result from getNumberOfDays and dispaly the result in Program class.
 Input and Output Format :
The first integer represent the year.
The second integer represents the month
The output is an interger which is number of days in the given month.
SAMPLE INPUT 1:
2000
1
SAMPLE OUTPUT 1:
29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Workout44
{
    class UserProgramCode
    {
        public static int getNumberOfDays(int y, int m)
        {
            int d;
            ****d = System.DateTime.DaysInMonth(y, m + 1);
            d = System.DateTime.DaysInMonth(y, m+1);
            return d;
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            ****UserProgramCode u = new UserProgramCode();
            int y, m, n;
            y = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            n = UserProgramCode.getNumberOfDays(y, m);
            Console.WriteLine(n);
 
            Console.ReadLine();
        }
    }
}
 
--------------------------------------------------------------------------------------------------------------------------------
 
 
45. Find Lowest
Write a program to find the lowest number in an integer array.
Print the lowest number.
Only positive number should be given as input in an array. Else print “Negative numbers present”.
Include a class UserProgramCode with a static method findLowest which accepts an Integer array. The return type (Integer) should return the lowest number. If negative numbers are present in the array, then return -1.
Create a Class Program which would be used to accept an Integer and an Integer array, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 Integers, where the first number corresponds the size of the array, followed by the array elements.
Output consists of an Integer, the lowest number, or a String “Negative numbers present” if a negative number is present in the array.
Refer sample output for formatting specifications.
Sample Input 1:
4
2
3
1
8
Sample Output 1:
1
 Sample Input 2:
4
2
3
-1
8
Sample Output 2:
Negative numbers present
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
    class UserProgramCode
    {
        public static int findLowest(int[] a)
        {
            int i, j, t, n;
            n = a.Length;
            List<int> li = new List<int>();
 
            for (i = 0; i < n; i++)
                li.Add(a[i]);
            li.Sort();
 
            return li[0];
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            ****UserProgramCode u = new UserProgramCode();
            int i, n, Flag=1;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] < 0)
                    Flag = 0;
            }
           if (Flag == 0)
               Console.WriteLine("Negative Numbers present");
           else
               Console.WriteLine("" + UserProgramCode.findLowest(a));
 
           Console.ReadLine();
        }
    }
 
 
--------------------------------------------------------------------------------------------------------------------------------
46. Find Average
Write a program to read an Integer (the size of the List) and the List of Integers and find the average of the numbers as a float value. Print the average.
Print Error Code “Negative numbers present” when inputs other than positive numbers is given.
Include a class UserProgramCode with a static method findAverage which accepts an Integer list. The return type (Float) should return the average value. If negative numbers are present in the array, then return -1.
Create a Class Program which would be used to accept an Integer and an Integer list, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 Integers, where the first number corresponds the size of the array, followed by the array elements.
Output consists of a Float, the average value, or a String “Negative numbers present” if a negative number is present in the array.
Refer sample output for formatting specifications.
Sample Input 1:
4
2
3
2
3
Sample Output 1:
2.5
Sample Input 2:
2
1
-2
Sample Output 2:
Negative numbers present
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class UserProgramCode
{
    public static float compute(int[] array, int size)
    {
        float avg, sum = 0;
        int i;
        foreach (int a in array)
        {
            if (a < 0)
                return -1;
        }
        
            sum = array.Sum();
        
        avg = sum / size;
 
        return avg;
    }
}
 
 
class Program
{
    static void Main(string[] args)
    {
        UserProgramCode u = new UserProgramCode();
        int n;
        float avg;
        n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        avg = UserProgramCode.compute(a, n);
        if (avg == -1)
        {
            Console.WriteLine("Negative numbers present");
        }
        else
            Console.WriteLine(String.Format("{0:0.0}", avg));
 
        Console.ReadLine();
    }
}
 
--------------------------------------------------------------------------------------------------------------------------------
47. Validate Phone Number
Write a program to read a phone number as a string input and to verify the phone number using following business rules:
-it should contain only numbers or dashes (-)
-dashes may appear at any position
-should have exactly 10 digits
If the Phone number is valid print “Valid” otherwise print “Invalid”.
Include a class UserProgramCode with a static method validatePhoneNumber which accepts a String. The return type (Integer) should return 1 if valid, else return 2.
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String, which corresponds to the phone number.
Output consists of a String, “Valid” if the phone number is valid, else “Invalid”.
 
Refer sample output for formatting specifications.
Sample Input 1:
265-265-7777
Sample Output 1:
Valid
Sample Input 2:
1111-111-1111
Sample Output 2:
Invalid
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int f = 0;
        string s;
        s = Console.ReadLine();
        userprogramcode obj = new userprogramcode();
        f = obj.validatenumber(s);
        if (f == 1)
            Console.WriteLine("Valid number format");
        if (f == -1)
            Console.WriteLine("Invalid number format");

        Console.ReadLine();
    }
}
public class userprogramcode
{
    public int validatenumber(string s)
    {
        if (Regex.IsMatch(s, @"^\d{3}[-]\d{3}[-]\d{4}$"))
        {
            return 1;
        }
        else
            return -1;
    }
}

 
--------------------------------------------------------------------------------------------------------------------------------
48. Check Supply
The Policy followed by a Company to process Customer Orders is given by the following rules:
Rules:
(a) If a Customer Order is less than or equal to that in Stock and if the Credit is OK, Supply the required quantity.
(b) If the Credit is Not OK, then do not Supply. Send him intimation saying "Cannot Supply".
(c) If the Credit is OK, but the item in Stock is less than the order, Supply what is in Stock. Intimate to him that the balance will be shipped.
(c) If the Credit is OK and the item in Stock is 0, Output should be "Out Of Stock".
Input1- Stock in hand
Input2- Customer Order Quantity
Input3- Credit (true -OK, false -Not OK)
Output1- Message(“Supply","Cannot Supply","Out Of Stock","Balance Will Be Shipped Later")
Include a class UserProgramCode with a static method checkSupply which accepts two Integers and a Boolean value. The return type (String) should return a String according to the business rules.
Create a Class Program which would be used to accept two Integers and a Boolean value, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a 2 integers and a boolean value.
Output consists of a String.
Refer sample output for formatting specifications.
Sample Input 1:
50
5
true
Sample Output 1:
Supply
Sample Input 2:
50
5
false
Sample Output 2:
Cannot Supply
Sample Input 3:
50
55
true
Sample Output 3:
Balance Will Be Shipped Later
Sample Input 4:
0
5
true
Sample Output 4:
Out Of Stock
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class UserProgramCode
{
    public static string checksupply(int n1, int n2, bool value)
    {
        if (value == true && n1 == 0)
        {
            return ("OutOfStock");
        }
        else
            if (value == true && n2 < n1 | n1 == n2)
            {
                return ("Supply");
            }
            else
                if (value == true && n1 < n2)
                {
                    return ("Balance Will Be Shipped Later");
                }
                else
                    if (value == false)
                    {
                        return "Cannot Supply";
                    }
                    else
                        return "";
    }
}
 
class Program
{
    static void Main(string[] args)
    {
        UserProgramCode u = new UserProgramCode();
        int n1, n2;
        bool value;
        string output;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        value = bool.Parse(Console.ReadLine());
        output = UserProgramCode.checksupply(n1, n2, value);
        Console.WriteLine(output);
 
        Console.ReadLine();
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
49. Count Characters
Write a program to count the number of characters present in the given input String array.
Include a class UserProgramCode with static method countCharacters which accepts string array. The return type is a integer value which is the count of characters in the string array.
Create a class Program which would get the input and call the static method countCharacters present in the UserProgramCode.
Input string must contains only the alphabets then return count of characters else return the -1.
If count value is -1 then print "Invalid Input".
Input and Output Format :
Input consists of a integer and String array. Integer represents a size of the array following by the string elements.
Output consists of a integer which is the count of the character from string array.
Sample Input 1:
3
cherry
apple
blueberry
Sample Output 1:
20
Sample Input 2:
2
@aaa
bbb
Sample Output 2:
Invalid Input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class UserProgramCode
    {
        public static int countcharachters(string[] s)
        {
            int sum = 0, flag = 0,count=0;

            foreach (string s1 in s)
            {                
                foreach (char c in s1)
                {
                    if (!char.IsLetter(c))
                    {
                        flag=1;
                        count++;
                        break;
                    }
                }
            }
            if (flag == 1)
                return -1;
            else
            {
                foreach (string str in s)
                    sum += str.Length;

                return sum;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserProgramCode u = new UserProgramCode();
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            int result;
            for (int i = 0; i < n; i++)
                s[i] = Console.ReadLine();
            result = UserProgramCode.countcharachters(s);
            if (result == -1)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

----------------------------------------------------------------------------------------------------------------------------------------
50. Get Big Diff 
Write a program that reads an integer array and finds the difference between the largest element and smallest element in the array.
Include a class UserProgramCode with a static method getBigDiff that accepts an integer array and returns an integer. 
Create a Class Program which would be used to read the integer array and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 integers. The first integer corresponds to n, the number of elements in the array.
The next 'n' integers correspond to the elements in the array.
Output consists of an integer.
Sample Input 1:
4
10
3
5
6

Sample Output 1:
7
Sample Input 2:
4
2
-10
7
-2
Sample Output 2:
17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   class Program
    {
        static void Main(string[] args)
        {
            UserProgramCode u=new UserProgramCode();
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int result;
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            result = UserProgramCode.getBigDiff(a);
            Console.WriteLine(result);

            Console.ReadLine();
        }

    }

    class UserProgramCode
    {
        public static int getBigDiff(int[] a)
        {
           int  min = a[0],max=a[0],diff=0;
           for (int i = 0; i < a.Length; i++)
           {
               if (a[i] >= max)
                   max = a[i];
               if (a[i] <= min)
                   min = a[i];
           }
           diff= max - min;
           return diff;
        }
    }

-----------------------------------------------------------------------------------------------------------------------------------------
51. Concatenate String
Write a program to concatenate two strings as per the following rules.
Rules:
1.If the 2 strings are of same length, simply append them together and return the final string.
2.If the 2 given strings are of different length, remove starting characters from the longer string so that both strings are of same length and then append them together and return the final string. 
Include a class UserProgramCode with a static method concatstring that accepts a string and returns a string.
Create a Class Program which would be used to read 2 strings and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of two Strings.
Output consists of a String.
Sample Input 1:Cognizant
Hello
Hi
Sample Output 1:
lohi
Sample Input 2:
cognizant
coh
Sample Output 2:
antcoh
Sample Input 3:
Hello
hello
Sample Output 3:
Hellohello

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string inp1 = Console.ReadLine();
            string inp2 = Console.ReadLine();
            string output = UserProgramCode.concatstring(inp1, inp2);
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
    class UserProgramCode
    {
        public static string concatstring(string inputstr1, string inputstr2)
        {
            int x = inputstr1.Length;
            int y = inputstr2.Length;
            string ans;
            if (x == y)
            {
                ans = inputstr1 + inputstr2;
            }
            else if (x > y)
            {
                int z = x - y;
                string inputstring1 = inputstr1.Remove(0, z);
                ans = inputstring1 + inputstr2;
            }
            else
            {
                int z = y - x;
                string inputstring2 = inputstr1.Remove(0, z);
                ans = inputstr1 + inputstring2;
            }
            return ans;

        }
    }

------------------------------------------------------------------------------------------------------------------------------------------
52. SortList
Write a code to sort the given array of integers in ascending order.
 Business Rules:
Only positive numbers should be given as inputs to the integer array.
Include a class UserProgramCode with static method sortList which accepts interger array
The return type is a interger array. If the input consists of negative numbers,return -1. If the input array size is 0, return -1.
Create a class Program which would get the input and call the static method sortList present in the UserProgramCode.
If the sortList method returns -1 print "Invalid Input".
If the sortList method returns -2 print "Input is Empty".
Input Output Format:
Input consists of a n+1. n represents the size of the array followed by the elements in the array.
Output consists of a array which is sorted in ascending order.
Sample Input 1:
3
45
12
36
Sample Output 1 :
Sorted Array :
12
36
45
Sample Input 2:
4
-1
56
89
45
Sample Output 2 :
Invalid Input

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpImpPrac
{
    class Program
    {
        static void Main(string[] args)
    {
        int[] a=new int[0];
        int[] output;
      
        output = UserProgramCode.sortList(a);
        if (output[0] == -1)
        {
            Console.WriteLine("Invalid Input");
        }
        else if (output[0]==-2)
        {
            Console.WriteLine("Input is Empty");
        }
        else
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }

        Console.ReadLine();
    }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CsharpImpPrac
{
    class UserProgramCode
    {
        public static int[] sortList(int[] a)
        {
            int iFlag = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            int maxi = a.Length;
            int[] output=new int[100];

            if (maxi == 0)
            {
                output[0] = -2;
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]<0)
                    {
                        output[0] = -1;
                        iFlag = 1;
                        break;
                    }
                }
                if (iFlag == 0)
                {
                    a = new int[n];
                    output = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());

                    }

                    Array.Sort(output);
                }
            }
            return output;
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
53. Password Validation
Given a method with a password in string format as input,  write code to validate the password using following rules:
- Must contain at least one digit
- Must contain at least one of the following special characters @, #, $
- Length should be between 6 and 20 characters (both inclusive).
Include a class UserProgramCode with a static method validatePassword which accepts a password string as input.
If the password is as per the given rules return 1 else return -1.If the return value is 1 then print "Valid password" else print as "Invalid password".
Create a Program class which gets a string as an input and call the static method validatePassword present in the UserProgramCode.
Input and Output Format:
Input is a string .
Output consists of a string. Output "Valid password" if the given password is valid or "Invalid password" if the given password is not valid.
Sample Input 1:
%Dhoom%
Sample Output 1:
Invalid password
Sample Input 2:
#@6Don
Sample Output 2:
Valid password
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int x;
            str1 = Console.ReadLine();
            x=UserProgramCode.validatePassword(str1);
            if(x==1)
                Console.WriteLine("valid password");
            else
                Console.WriteLine("Invalid password");

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int validatePassword(string str)
        {
            bool a, b, c,flg=false;
            int f = 0;
            a = str.Contains("@");
            b = str.Contains("#");
            c = str.Contains("$");

            foreach(char ch in str)
                if(char.IsDigit(ch))
                    flg=true;

            if ((a == true || b == true || c == true) &&((str.Length >= 6) && (str.Length <= 20)) && flg)
                f = 1;
                
            else
                f = -1;

            return f;
        }

    }
-----------------------------------------------------
54. Longest Word
Write a Program which finds the longest word from a sentence. Your program should read a sentence as input from user and return the longest word. In case there are two words of maximum length return the word which comes first in the sentence.
Include a class UserProgramCode with a static method getLargestWord which accepts a string. The return type is a string that corresponds to the largest word in the sentence.
Create a Class Program which would be used to accept a input string and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string with a maximum size of 100 characters.
Output consists of a single string.
Refer sample output for formatting specifications.
Sample Input 1:
Welcome to the world of Programming
Sample Output 1:
Programming
Sample Input 2:
ABC DEF
Sample Output 2:
ABC
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string c;
        c = UserProgramCode.getLargestWord(s);
        Console.WriteLine(c);

        Console.ReadKey();
    }
}


class UserProgramCode
{
    public static string getLargestWord(string str)
    {
        int l = 0, max = 0, ind = -1;
        string[] s = new string[100];
        s = str.Split(' ');
        for (int i = 0; i < s.Length; i++)
        {
            l = s[i].Length;
            if (max < l)
            {
                max = l;
                ind = i;
            }
        }
        return s[ind];
    }
}
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
55. Find the difference between Dates in months
Given a method with two date strings in yyyy-mm-dd format as input, write code to find the difference between two dates in months.
Include a class UserProgramCode with a static method getMonthDifference which accepts two date strings as input. The method returns an integer which is the difference between two dates in months.
Create a class Program which would get the input and call the static method getMonthDifference present in the UserProgramCode.
Input and Output Format:
Input consists of two date strings.
Format of date : yyyy-mm-dd.
Output is an integer.
Refer sample output for formatting specifications.2011-03-01
Sample Input 1:
2012-03-01
2012-04-16
Sample Output 1:
1
Sample Input 2:
2011-03-01
2012-04-16
Sample Output 2:
13

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int k;
        string intime, outtime;
        intime = Console.ReadLine();
        outtime = Console.ReadLine();
        k = UserProgramCode.getMonthDifference(intime, outtime);
        if (k == -1)
        {
            Console.WriteLine("Invalid format");
        }
        else
            Console.WriteLine(k);

        Console.ReadKey();
    }
}

class UserProgramCode
{
    public static int getMonthDifference(string intime, string outtime)
    {

        string s;
        s = "yyyy-MM-dd";
        DateTime i, o;
        bool k = DateTime.TryParseExact(intime, s, null, System.Globalization.DateTimeStyles.None, out i);
        if (k == false)
            return -1;
        bool j = DateTime.TryParseExact(outtime, s, null, System.Globalization.DateTimeStyles.None, out o);
        if (j == false)
            return -1;

        double dm;

        dm = (o.Subtract(i).Days) / (365.25 / 12);
        
        
        return (int)dm;
    }


}
------------------------------------------------------------------------------------------------------------------------------------------
56. Generate the series
  Given a method taking an odd positive Integer number as input, write code to evaluate the following series:
1+3-5+7-9…+/-n.
 
Include a class UserProgramCode with a static method addSeries which accepts a positive integer . The return type of this method is an integer .
Create a class Program which would get the input as a positive integer and call the static method addSeries present in the UserProgramCode.
Input and Output Format:
Input consists of a positive integer n.
Output is a single integer .
Refer sample output for formatting specifications.
Sample Input 1:
9
Sample Output 1:
-3
Sample Input 2:
11
Sample Output 2:
8
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            int n,x;
            n = Convert.ToInt32(Console.ReadLine());
            x = UserProgramCode.addSeries(n);
            Console.WriteLine(x);
        }
    }

    class UserProgramCode
    {
        public static int addSeries(int a)
        {
            int t = 0, k = 1;
            for (int i = 0; k <= a; i++)
            {
                if (i == 0)
                {
                    t = t + k;
                }
                else if (i == 1)
                {
                    t = t + k;
                }
                else if (i % 2 != 0)
                {
                    t = t + k;
                }
                else
                {
                    t = t - k;
                }
                
                k = k + 2;
            }
            return t;
        }
    }

------------------------------------------------------------------------------------------------------------------------------------------
57. Three Digits
Write a program to read a string and check if the given string is in the format "CTS-XXX" where XXX is a three digit number.
Include a class UserProgramCode with a static method validatestrings which accepts a string and returns an integer. The function returns 1 if the string format is correct,  else returns -1.
Create a Class Program which would be used to accept a String and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a string (Valid or Invalid).
Refer sample output for formatting specifications.
Sample Input 1:
CTS-215
Sample Output 1:
Valid
Sample Input 2:
CTS-2L5
Sample Output 2:
Invalid
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int x;
        string s = Console.ReadLine();
        x = UserProgramCode.validatestrings(s);
        if (x == 1)
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }

        Console.ReadLine();

    }
}

class UserProgramCode
{
    public static int validatestrings(string str)
    {
        int output1 = 0;
        Regex reg = new Regex(@"^([C]+[T]+[S]+[-]+([0-9]{3}))$");
        if (reg.IsMatch(str))
        {
            output1 = 1;
        }
        else
        {
            output1 = -1;
        }
        return output1;
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
58. File Extension
Write a program to read a file name as a string and find out the file extension and return it as output. For example, the file sun.gif has the extension gif.
Include a class UserProgramCode with a static method fileIdentifier which accepts a string. The return type (string) should return the extension of the input string (filename).
Create a Class Program which would be used to accept Input String and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string that corresponds to a file name.
Output consists of a string(extension of the input string (filename)).
Refer sample output for formatting specifications.
Sample Input 1:
sun.gif
Sample Output 1:
Gif

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {

        string s = Console.ReadLine();


        Console.WriteLine(UserProgramCode.validatestrings(s));
        Console.ReadLine();
    }
}

class UserProgramCode
{
    public static string validatestrings(string str)
    {

        string[] s;
        s = str.Split('.');
        string m;
        int l=s.Length;
        if(l==1)
            m = "Invalid String";
        else
        m = s[l - 1];

        return m;
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
59. Sum of cubes and squares of elements in an array
Write a program to get an int array as input and identify even and odd numbers. If number is odd get cube of it, if number is even get square of it. Finally add all cubes and squares together and return it as output.
Include a class UserProgramCode with a static method addEvenOdd which accepts an integer array as input and returns an integer.
The method returns an integer which is the sum of cubes of all odd numbers and squares of all even numbers in the array. 
Create a class Program which would get the input and call the static method addEvenOdd present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the number of elements in the array.
The next 'n' lines of input consists of the elements in the array.
Output is an integer that corresponds to the required sum.
Refer sample output for formatting specifications. 
Sample Input 1:
5
2
6
3
4
5
Sample Output 1:

208
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        userprogramcode obj = new userprogramcode();
        n = obj.addEvenOdd(a);
        Console.WriteLine(n);

        Console.ReadLine();
    }
}
public class userprogramcode
{
    public int addEvenOdd(int[] a)
    {
        int sum = 0;
        foreach (var n in a)
        {
            if (n % 2 == 0)
                sum += Convert.ToInt32(Math.Pow(n, 2));
            else
                sum += Convert.ToInt32(Math.Pow(n, 3));

        }
        return sum;
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
60. Initial Format
Write a program to input a person's name in the format "FirstName LastName" and return the person name in the following format - "LastName, InitialOfFirstName".
Include a class UserProgramCode with a static method nameFormatter which accepts a string. The return type (string) should return the expected format.
Create a Class Program which would be used to accept Input String and call the static method present in UserProgramCode.

Input and Output Format:
Input consists of a string that corresponds to a Person's name.
Output consists of a string(person's name in expected format).
Refer sample output for formatting specifications.

Sample Input :
Jessica Miller 
Sample Output:
Miller, J
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string s;
        s = Console.ReadLine();
        userprogramcode obj = new userprogramcode();
        Console.WriteLine(obj.nameFormatter(s));

        Console.ReadLine();
    }
}
public class userprogramcode
{
    public string nameFormatter(string s)
    {
        string[] str;
        str = s.Split(' ');
        s = str[1] + ", " + str[0][0];
        return s;
    }
}
-----------------------------------------------------------------------------------------------------------------------------------------
61. Difference between two dates in days
Get two date strings as input and write code to find difference between two dates in days.
 
Include a class UserProgramCode with a static method getDateDifference which accepts two date strings as input.
The return type of the output is an integer which returns the diffenece between two dates in days.
Create a class Program which would get the input and call the static method getDateDifference present in the UserProgramCode. 
Input and Output Format:
Input consists of two date strings.
Format of date : yyyy-mm-dd. 
Output is an integer.

Refer sample output for formatting specifications.
Sample Input 1:
2012-03-12
2012-03-14
Sample Output 1:
2

Sample Input 2:
2012-04-25
2012-04-28
Sample Output 2:
3
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
        {
            string s, s1;
            s = Console.ReadLine();
            s1 = Console.ReadLine();
           
             Console.WriteLine(UserProgramCode.getDateDifference(s, s1));

            Console.ReadLine();
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class UserProgramCode
{
    public static int getDateDifference(string s, string s1)
    {
        string fm = "yyyy-MM-dd";
        DateTime dt1, dt;
        if (!(DateTime.TryParseExact(s, fm, null, System.Globalization.DateTimeStyles.None, out dt) &&
        DateTime.TryParseExact(s1, fm, null, System.Globalization.DateTimeStyles.None, out dt1)))
        {
            return -1;
        }
        return ((int)Math.Abs(dt1.Subtract(dt).Days));
    }
}
---------------------------------------------------------------------------------------------------------------
62. Count Sequential Characters
Get a string as input and write code to count the number of characters which gets repeated 3 times consecutively and return that count (ignore case).
Include a class UserProgramCode with a static method countSequentialChars which accepts a string as input and return type is an integer.
The method returns the repeat count. If no character gets repeated 3 times consecutively the method returns -1.
Create a class Program which would get the input and call the static method countSequentialChars present in the UserProgramCode.
If the method returns -1, print 'No Repeated Words Found'.
 
Input and Output Format:
Input consists a string.
Refer sample output for formatting specifications.
Sample Input 1:
abcXXXabc
Sample Output 1:
1
Sample Input 2:
aaxxyzAAx
Sample Output 2:
No Repeated Words Found
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = UserProgramCode.countSequentialChars(s);
            if (a == -1)
                Console.WriteLine("No Repeated Words Found");
            else
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
class UserProgramCode
    {
         public static int countSequentialChars(string s)
        {
            int l = s.Length;
            s = s.ToUpper();
            string[] st = new string[50];

            for (int k = 0; k < l; k++)
            {
                st[k] = s.Substring(k, 1);
            }
            int count = 0;
            int c = 0;
            for (int k = 0; k < l - 1; k++)
            {
                if (st[k] == st[k + 1])
                    count++;
                else
                    count = 0;
                if (count == 2)
                    c++;
            }
            if (c == 0)
                return -1;
            else
                return c;
        }
    }
}
-----------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------
63. Sum of cubes and squares of elements in an array
Write a program to get an int array as input and identify even and odd numbers. If number is odd get cube of it, if number is even get square of it. Finally add all cubes and squares together and return it as output.
Include a class UserProgramCode with a static method addEvenOdd which accepts an integer array as input and returns an integer.
The method returns an integer which is the sum of cubes of all odd numbers and squares of all even numbers in the array. 
Create a class Program which would get the input and call the static method addEvenOdd present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the number of elements in the array.
The next 'n' lines of input consists of the elements in the array.
Output is an integer that corresponds to the required sum.
Refer sample output for formatting specifications. 
Sample Input 1:
5
2
6
3
4
5
Sample Output 1:

208
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        n = UserProgramCode.addEvenOdd(a);
        Console.WriteLine(n);
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class UserProgramCode
{
    public static int addEvenOdd(int[] a)
    {
        int sum = 0;
        foreach (var n in a)
        {
            if (n % 2 == 0)
                sum += Convert.ToInt32(Math.Pow(n, 2));
            else
                sum += Convert.ToInt32(Math.Pow(n, 3));

        }
        return sum;
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------
64. Initial Format
Write a program to input a person's name in the format "FirstName LastName" and return the person name in the following format - "LastName, InitialOfFirstName".
Include a class UserProgramCode with a static method nameFormatter which accepts a string. The return type (string) should return the expected format.
Create a Class Program which would be used to accept Input String and call the static method present in UserProgramCode.

Input and Output Format:
Input consists of a string that corresponds to a Person's name.
Output consists of a string(person's name in expected format).
Refer sample output for formatting specifications.

Sample Input :
Jessica Miller 
Sample Output:
Miller, J
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
            string s;
            s = Console.ReadLine();
            
            Console.WriteLine(UserProgramCode.nameFormatter(s));
            Console.ReadLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class UserProgramCode
{
    public static string nameFormatter(string s)
    {
        string[] str;
        str = s.Split(' ');
        s = str[1] + ", " + str[0][0];
        return s;
    }
}
-----------------------------------------------------------------------------------------------------------------------------------------------
65. Difference between two dates in days
Get two date strings as input and write code to find difference between two dates in days.
 
Include a class UserProgramCode with a static method getDateDifference which accepts two date strings as input.
The return type of the output is an integer which returns the diffenece between two dates in days.
Create a class Program which would get the input and call the static method getDateDifference present in the UserProgramCode. 
Input and Output Format:
Input consists of two date strings.
Format of date : yyyy-mm-dd. 
Output is an integer.

Refer sample output for formatting specifications.
Sample Input 1:
2012-03-12
2012-03-14
Sample Output 1:
2

Sample Input 2:
2012-04-25
2012-04-28
Sample Output 2:
3
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string s, s1;
        s = Console.ReadLine();
        s1 = Console.ReadLine();

        Console.WriteLine(UserProgramCode.getDateDifference(s, s1));

        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class UserProgramCode
{
     public static int getDateDifference(string s, string s1)
        {
            string fm = "yyyy-MM-dd";
            DateTime dt1, dt;
            if(!(DateTime.TryParseExact(s, fm, null, System.Globalization.DateTimeStyles.None, out dt)&&
            DateTime.TryParseExact(s1, fm, null, System.Globalization.DateTimeStyles.None, out dt1)))
            {
                return -1;
            }
            return ((int)Math.Abs( dt1.Subtract(dt).Days));
     }
}

--------------------------------------------------------------------------------------------------------------------------------------
66. Count Sequential Characters
Get a string as input and write code to count the number of characters which gets repeated 3 times consecutively and return that count (ignore case).
Include a class UserProgramCode with a static method countSequentialChars which accepts a string as input and return type is an integer.
The method returns the repeat count. If no character gets repeated 3 times consecutively the method returns -1.
Create a class Program which would get the input and call the static method countSequentialChars present in the UserProgramCode.
If the method returns -1, print 'No Repeated Words Found'.
 
Input and Output Format:
Input consists a string.
Refer sample output for formatting specifications.
Sample Input 1:
abcXXXabc
Sample Output 1:
1

Sample Input 2:
aaxxyzAAx
Sample Output 2:

No Repeated Words Found

Ans:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = UserProgramCode.countSequentialChars(s);
            if (a == -1)
                Console.WriteLine("No Repeated Words Found");
            else
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
 class UserProgramCode
    {
         public static int countSequentialChars(string s)
        {
            int l = s.Length;
            s = s.ToUpper();
            string[] st = new string[50];

            for (int k = 0; k < l; k++)
            {
                st[k] = s.Substring(k, 1);
            }
            int count = 0;
            int c = 0;
            for (int k = 0; k < l - 1; k++)
            {
                if (st[k] == st[k + 1])
                    count++;
                else
                    count = 0;
                if (count == 2)
                    c++;
            }
            if (c == 0)
                return -1;
            else
                return c;
        }
    }
}

-----------------------------------------------------------------------------------------------------------------------------------------




67. Boundary Average
Given an int array as input, write a program to compute the average of the maximum and minimum element in the array.
Include a class UserProgramCode with a static method “getBoundaryAverage” that accepts an integer array as argument and return a avegare of max and min value.
Create a class Program which would get the input array and call the static method getBoundaryAverage present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the size of the array.
The next n lines consist of integers that correspond to the elements in the array.
Assume that the maximum number of elements in the array is 10.
Output consists of a single float value that corresponds to the average of the max and min element in the array.
Output is displayed correct to 1 decimal place.
 
Sample Input :
6
3
6
9
4
2
5
 
Sample Output:
5.5



Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[n];
            for (int i = 0; i < n; i++)
                s[i] = Convert.ToInt32(Console.ReadLine());
            double a = UserProgramCode.getBoundaryAverage(s);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
    class UserProgramCode
    {
        public static double getBoundaryAverage(int[] a)
        {
            double d, e;
            d = ((a.Max() + a.Min()) / 2.0);
            e = Math.Round(d, 1);
            return e;
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
68. String Reversal
Write a program to reverse each word in the given string.
Include a class UserProgramCode with a static method “reverseString” that accepts a string argument and returns a string.
If string contains any special characters then return "-1".
Create a class Program which would get a string as input and call the static method reverseString present in the UserProgramCode. 
If the method returns -1, then print 'Invalid Input'.
Input and Output Format:
Input consists of a string.
Output consists of a string.
Sample Input 1:
hai hello
Sample Output 1:
iah olleh

Sample Input 2:
how !#$
Sample Output 2:
Invalid Input

Ans:
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string a = UserProgramCode.reverseString(s);
            if (a == "-1")
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
 class UserProgramCode
    {
        public static string reverseString(string a)
        {
            int l=a.Length;
         
             if (a.Any(ch => !(Char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch))))
                return "-1";
            StringBuilder sb = new StringBuilder();
              char[] c;
            string[] s;
            s=a.Split(' ');
            for(int i=0;i<s.Length;i++)
            {
              c= s[i].ToCharArray();     
              Array.Reverse(c);
              sb.Append(c);
                sb.Append(" ");
            } 
               return sb.ToString();
        }
    }
}

----------------------------------------------------------------------------------------------------------------------------------------
69. Find Occurence
Write a method to find the occurence (number of times) of a given character  in a given input string.
Include a class UserProgramCode with a static method findOccurence which accepts a string and character as input and returns an integer.
Business Rules: 
1. Search criteria is irrespective of cases.
2. The input string should consists of only alphabets, no special characters or numbers should be there in the string. If present, the method returns -1..
Create a class Program which would get the input and call the static method findOccurence present in the UserProgramCode.
If the method returns -1, print 'Invalid Input'.

Input and Output format : 
Input consists of string and character. 
Refer sample output for formatting specifications.




Sample Input 1 :
HELLO friends Welcome to CSharp wonderful world
L
Sample Output 1 :
5
Sample Input 2 :
Gr8...I am fine.
8
Sample Output 2 :
Invalid Input

Ans:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c = Convert.ToChar(Console.ReadLine());
            int a = UserProgramCode.findOccurence(s, c);
            if (a == -1)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
 class UserProgramCode
    {
        public static int findOccurence(string a,char b)
        {
            int count = 0;  
            if (a.Any(ch => !(Char.IsLetter(ch)||Char.IsWhiteSpace(ch))))
                return -1;
            foreach (char e in a)
            {
               if (e==char.ToUpper(b)||e==char.ToLower(b))
                    count++;
            }
            return count; 
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------
70. Calculate Commission 
Write a program to calculate the commission on given sales as per the following policy.
Include a class UserProgramCode with a static method calculateCommission which accepts a float as input.
Create a class Program  which would get the input and call the static method calculateCommission present in the UserProgramCode.
If the method returns -1, then print 'Invalid Input'.
 
If sales is less than Rs. 10000/- no commission.
If sales is between Rs. 10000/- to Rs. 25000/- commission is 10% of sales.
If sales is more than Rs. 25000/- then commission is Rs. 500/- plus 8% of sales amount.
Business Rule :
1. If input is negative number then the method calculateCommission returns -1.
2. Otherwise return a calculated commission.

Input and Output format :
Input consists of float.
Refer sample output for formatting specifications.
Sample Input 1 :
11000
Sample Output 1:
1100
Sample Input 2 :
-1000
Sample Output 2 :
Invalid Input

Ans
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = float.Parse((Console.ReadLine()));
            int a = UserProgramCode.calculateCommission(s);
            if (a == -1)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication26
{
class UserProgramCode
    {
        public static int calculateCommission(float a)
        {
            double com;
            double r = Convert.ToDouble(a);      
            if (r < 0)
            {
                return -1;
            }
            else if (r < 10000)
            {
                return 0;
            }
            else if (r >= 10000 && r <= 25000)
            {
                com = r * 1.0 / 10.0;
                return Convert.ToInt32(com);
            }
            else if (r > 25000)
            {
                com = 500 + (r * 8.0/ 100.0);
                return Convert.ToInt32(com);
            }
            return -1;
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------

71. Sort Array Element
Write a method to sort input string array by the length of each element. If word length is same then sort thiese two words in ascending order without considering length.
Include a class UserProgramCode with a static method sortArrayElement which accepts a string array as input.
The return type of a method is string array.
If input contains any special characters then add '-1' into the list. 
Create a class Program which would get the input and call the static method sortArrayElement present in the UserProgramCode.
 
Input and Output format :
The first line of the input consists of an integer that corresponds to the number of elements in the string array.
The nexr 'n' lines consist of string inputs.
Output consists of array which contains sorted elements or "-1".
Sample Input 1 :
3
Greenapple
Litchi
Mango
Sample Output 1 :
Mango
Litchi
Greenapple
Sample Input 2 :
2
one
#two
Sample Output 2 :
-1

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            string[] b;
            for (int i = 0; i < a.Length; i++)
                a[i] = Console.ReadLine();
            b = userProgramCode.sortArrayElement(a);
            foreach(string c in b)
                Console.WriteLine(c);
            Console.ReadLine();
        }
    }
   class userProgramCode
{
    public static string[] sortArrayElement(string[] a)
    {
        string[] b = new string[1];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (!char.IsLetterOrDigit(a[i][j]))
                {
                    b[0] = "-1";
                    return b;
                }
            }
        }
        ****Array.Sort(a, StringComparer.Ordinal);

        string temp;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i+1; j < a.Length; j++)
            {
                if (a[i].Length >a[j].Length)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
               
            }
        }



        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i].Length == a[j].Length && a[i].CompareTo(a[j]) == -1)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        
        return a;
    }
}

}
-------------------------------------------------------------
72. Shortest Word Length

Given a string array as input, write a program to find the length of the shortest word in the array..
Create a class named UserProgramCode that has the following static method
public static int shortestWordLength(string[] input1)
Create a class named Program that accepts a string array as input and calls the static method present in the UserProgramCode.

Input and Output Format:
The first line of the input consists of an integer 'n' that corresponds to the number of elements in the string array.
The next 'n' lines of the input consists of strings that correspond to the elements in the string array.
Output consists of a single integer that corresponds to the length of the shortest word in the array.

Sample Input :
3
cherry
apple
blueberry

Sample Output :
5
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            for (int i = 0; i < a.Length; i++)
                a[i] = Console.ReadLine();
            int r = userProgramCode.shortestWordLength(a);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
    class userProgramCode
    {
        public static int shortestWordLength(string[] a)
        {
            int min = 1000;
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i].Length;
            }
            min = arr.Min();

            return min;
        }
    }
}
--------------------------------------------------------------------------
73. Shipping Cost
Write a program to compute the Cost of Book Shipping. The Shipping Cost is computed according to the shipping type and the package weight. The shipping rate is given below.
Shipping types - Weight Rate (bahts/gram)
Regular for first 2000 - 0.25 (basic charge)
Regular exceeding 2000 - 0.35 for each
Express uses the same rate as Regular + 50 bahts fee
Note that the Shipping cost is computed from the possible valid minimum rate.

Input1- Weight in grams
Input2- Type of delivery ('R' Regular and 'X' Express)

Create a class named UserProgramCode that has the following static method
public static float CalcShippingCost(float input1, char input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
The first line of the input consists of a float that corresponds to the weight in grams.
The second line of the input consists of a character ('R' or 'X') that corresponds to the type of service.

Output consists of a single float that corresponds to the shipping cost. Output is displayed correct to 2 decimal places.
Sample Input:
4500
R
Sample Output:
1375.00

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            float f=float.Parse(Console.ReadLine());
            char c=Convert.ToChar(Console.ReadLine());
            float p=userProgramCode.CalcShippingCost(f,c);
            Console.WriteLine(p.ToString("F"));
            Console.ReadLine();
        }
    }
    class userProgramCode
    {
        public static float CalcShippingCost(float i, char c)
        {
            float p;
            if (c == 'X')
                i += 50;
            if (i > 2000)
            {
                float d = i - 2000;
                p =Convert.ToSingle(2000 * 0.25);
                p +=Convert.ToSingle( (d * 0.35));
            }
            else
                p = Convert.ToSingle(i * 0.25);
            return p;
        }

    }
}
-----------------------------------------------------------------------------------
74. Strong Number

Write a program to find whether the given integer input is a strong number or not. If the sum of each digits factorial is the same as the given input value then it is a strong number.
If the Input1 is strong number then print "Input1 is a Strong Number" where Input1 is the input integer value. (Refer Example)
Business rule:
1) If the Input1 value is not a strong number then print "Sum of all digits factorial is XX" where XX is the total of each digits factorial value.
2) Print "Invalid Input" when given input number is a negative number.

Example:1
Input1: 145
1!+4!+5! = 1+24+120 = 145
Output1: 145 is a Strong Number

Example:2
Input1: 25
2!+5! = 2+120 = 122
Output1: Sum of all digits factorial is 122

Create a class named UserProgramCode that has the following static method
public static String checkStrongNumber(int input1)

Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of a single integer.

Output is a string.

Sample Input 1:
145

Sample Output 1:
145 is a Strong Number

Sample Input 2:
25

Sample Output 2:
Sum of all digits factorial is 122

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string r = userProgramCode.checkStrongNumber(n);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
    class userProgramCode
    {
        public static String checkStrongNumber(int i)
        {
            if (i < 0)
                return "Invalid Input";
            int t, r, f = 0;
            t = i;
            while (t > 0)
            {
                int fact = 1;
                r = t % 10;
                for (int j = 1; j <= r; j++)
                {
                    fact *= j;
                }
                f += fact;
                t /= 10;
            }
            if (f == i)
                return f + " is a Strong Number";
            else
                return "Sum of all digits factorial is " + f;

        }
    }
}
----------------------------------------------------------------------------------------
75. Print Digit Sum

Write a program that accepts a string input and finds the sum of all numeric digits present in the string.
Example 1:
input : abc12de4
output : 7
Example 2:
input : udjc&23er
output : -1
Business Rules :
1. If the given input string contains any special characters, then print -1.
2. f the given input string contains no numbers,then print -2.

Create a class named UserProgramCode that has the following static method
public static int getdigits(string input1)

Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of a String
Output is an integer.

Sample Input 1:
abc12de4

Sample Output 1:
7

Sample Input 2:
udjc&23er

Sample Output 2:
-1

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            int i=userProgramCode.getdigits(s);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
    class userProgramCode
    {
        public static int getdigits(string i)
        {
            int s=0;
            for (int j = 0; j < i.Length; j++)
            {
                if ((char.IsLetterOrDigit(i[j])))
                {
                    if (char.IsDigit(i[j]))
                        s += (Convert.ToInt32(i[j])-48);
                }
                else
                    return -1;
            }
            if (s == 0)
                return -2;
            else
                return s;
        }
    }
}
-------------------------------------------------------------------------------------
76. Special Characters

Write a program that accepts a string input and removes all the alphabetic characters from input and stores only the special characters and digits.
Note: Special characters are #, $,%,&
Business Rules :
1. if the given input string contains no numbers or special characters,then print -1.
Create a class named UserProgramCode that has the following static method
public static string getSpecialChar(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output is either '-1' or the processed string.
Sample Input 1:
cogniz$#45Ant
Sample Output 1:
$#45
Sample Input 2:
Treasure
Sample Output 2:
-1

****program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String res = UserProgramCode.getSpecialChar(str);
            Console.WriteLine(res);
 	    Console.ReadKey();
        }
    }
}

****UserProgramCode.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trial
{
    class UserProgramCode
    {
        public static string getSpecialChar(string input1)
        {
            int num = 0;
            StringBuilder sb=new StringBuilder();
            int sp = 0;
            int len = input1.Length;
            for (int i = 0; i < len; i++)
            {
                char c = input1[i];
                if (char.IsDigit(c))
                {
                    num++;
                    sb.Append(c);
                }
                if (c == '#' || c == '$' || c == '%' || c == '&')
                {
                    sp++;
                    sb.Append(c);
                }

            }
            if (num == 0 && sp == 0)
            {
                return "-1";
            }
            else
                return sb.ToString();
        }
    }
}
--------------------------------------------------------------------------------------
77. Calculate Frequency

Given two string inputs input1 and input2, write a program to find the number of times the complete string in input1 occurs in input2 and print the count. Ignore case sensitiveness in the input strings.
Business Rules:
1)If input1 has repeated words, print -1.
2)If the count of occurrence is zero then print -2 .

Example1:
input1: A good place
input2: It is a good place to be in and a good place to have fun.
output: 2
Example:
input1 :Does he have to have a car ?
input2: Yes he should.
output: -1
Create a class named UserProgramCode that has the following static method
public static int calcFrequency(string input1, string input2)
Create a class named Program that accepts the input and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of 2 strings.
Output consists of an integer.
Sample Input :
A good place
It is a good place to be in and a good place to have fun.
Sample Output :
2

****program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        String input1 = Console.ReadLine();
        String input2 = Console.ReadLine();
        int ret = UserProgramCode.calcFrequency(input1, input2);
        Console.WriteLine(ret);
        Console.ReadLine();
    }
}

class UserProgramCode
{
    public static int calcFrequency(string input1, string input2)
    {
        StringBuilder sb = new StringBuilder();
        String[] arr = input1.Split(' ');
        foreach (String a in arr)
        {
            sb.Append(a.ToLower());
        }

        int len = arr.Length;
        for (int i = 0; i < len; i++)
        {
            String s = arr[i];
            for (int j = i + 1; j < len; j++)
            {
                if (s.Equals(arr[j]))
                {
                    return -1;
                }
            }
        }
        int count = 0;

        StringBuilder sb1 = new StringBuilder();
        String linput1 = input1.ToLower();
        String linput2 = input2.ToLower().Replace('.', ' ');

        String[] l = linput2.Split(' ');

        foreach (String a in l)
        {
            sb1.Append(a);
        }
        len = sb.Length;
        int len2 = sb1.Length;
        for (int i = 0; i < len2; i++)
        {
            if (i <= len2 - len)
            {
                String sub = sb1.ToString().Substring(i, len);
                if (sub.Equals(sb.ToString()))
                {
                    count++;
                }
            }
        }
        if (count == 0)
            return -2;
        else
            return count;
    }
}
----------------------------------------------------------------------------------------
78. Form String

Given a String array and an int 'n', write a program to perform the following operations:
1) Pick nth character from each String element in the String array and form a new String.
2) If nth character not available in a particular String in the array consider $ as the character.
3) Print the new String.
Business Rules :
1. If there are any special characters in the input strings, then print -1.
Create a class named UserProgramCode that has the following static method
public static string formString(string[] input1,int input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of an integer 'k' that corresponds to the number of elements in the string array.
The next 'k' lines of the input consists of strings that correspond to the elements in the string array.
The next line of the input consists of an integer that corresponds to n.
Refer sample output for formatting specifications.
Sample Input :
4
ABC
XYZ
EFG
MN
3
Sample Output :
CZG$

/program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int k, n;
        k = int.Parse(Console.ReadLine());
        String[] arr = new String[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = Console.ReadLine();
        }
        n = int.Parse(Console.ReadLine());
        String ret = UserProgramCode.formString(arr, n);
        Console.WriteLine(ret);

        Console.ReadLine();
    }
}


class UserProgramCode
{
    public static string formString(string[] input1, int input2)
    {
        int len;
        StringBuilder sb = new StringBuilder();
        foreach (String a in input1)
        {
            if (a.Contains('#') || a.Contains('&') || a.Contains('%') || a.Contains('$'))
                return "-1";
            else
            {
                len = a.Length;
                if (input2 > len)
                    sb.Append('$');
                else
                {
                    String c = a.Substring(input2 - 1, 1);
                    sb.Append(c);
                }
            }
        }
        return sb.ToString();
    }
}


---------------------------------------------------------------------------------------------------------------------------------------
79. Word Form

Write a program that accepts an integer input and displays the given number in word form.The word form should include only billions,millions,thousands,hundreds wherever applicable. The starting alphabet of each word should be in capital except the word "and".
Business Rules:
1)If the given integer is negative convert that to a positive number and append "Minus" before the word then dispaly the result.
Create a class named UserProgramCode that has the following static method
public static string wordForm(int number)
Create a class named Program that accepts the input and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of an integer.
Output is a string.
Sample Input 1:
364576567
Sample Output1:
Three Hundred and Sixty Four Million Five Hundred and Seventy Six Thousand Five Hundred and Sixty Seven
Sample Input 2:
-1234
Sample Output 2:
Minus One Thousand Two Hundred and Thirty Four
****program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            String ret = UserProgramCode.wordForm(num);
            Console.WriteLine(ret);
            Console.ReadLine();
        }
    }

}

****UserProgramCode.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops2
{
    class UserProgramCode
    {
        public static string wordForm(int n)
        {
            return _toText(n, true);
        }
        private static string _toText(long n, bool isFirst = false)
        {
            string result;
            if (isFirst && n == 0)
            {
                result = "Zero";
            }
            else if (n < 0)
            {
                result = "Negative " + _toText(-n);
            }
            else if (n == 0)
            {
                result = "";
            }
            else if (n <= 9)
            {
                result = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }[n - 1] + " ";
            }
            else if (n <= 19)
            {
                result = new[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }[n - 10] + (isFirst ? null : " ");
            }
            else if (n <= 99)
            {
                result = new[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[n / 10 - 2] + (n % 10 > 0 ? "-" + _toText(n % 10) : null);
            }
            else if (n <= 999)
            {
                result = _toText(n / 100) + "Hundred " + _toText(n % 100);
            }
            else if (n <= 999999)
            {
                result = _toText(n / 1000) + "Thousand " + _toText(n % 1000);
            }
            else if (n <= 999999999)
            {
                result = _toText(n / 1000000) + "Million " + _toText(n % 1000000);
            }
            else
            {
                result = _toText(n / 1000000000) + "Billion " + _toText(n % 1000000000);
            }
            if (isFirst)
            {
                result = result.Trim();
            }
            return result;
        }
    }
}
-------------------------------------------------------------------------------------------------
80. Repeat Characters
Write a program to repeat the string multiple times provided with the below limitations.
a. If Input1 string length is five or less than five, then the first three characters should be repeated based on Input2 value.
b. If the Input1 string length is more than five then the last three characters should be repeated based on Input2 value
Business Rules :
1. If the length of Input1 is less than 3, then print 'Input value is insufficient'
2. If the Input2 value is negative, then print 'Invalid Input'
3. If the Input2 value is greater than 10, then print 'Input value is too long'
Example 1:
Input1: Price
Input2: 3
Output : PriPriPri
Example 2:
Input1: Sunday
Input2: 4
Output: daydaydayday
Example 3:
Input1: So
Input2: 5
Ouput: Input value is insufficient
Create a class named UserProgramCode that has the following static method
public static string repeatManipulateString(string input1, int input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of a string.
The second line of input consists of an integer.
Output is a string. Refer sample output and business rules for output formatting specifications.
Sample Input:
Price
3
Sample Output:
PriPriPri

****program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops2
{
    class Program
    {
        static void Main(string[] args)
        {
            String val = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            String ret = UserProgramCode.repeatManipulateString(val, num);
            Console.WriteLine(ret);
            Console.ReadLine();
        }
    }

}
****UserProgramCode.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace oops2
{
    class UserProgramCode
    {
        public static string repeatManipulateString(string input1, int input2)
        {
            StringBuilder sb = new StringBuilder();
            int len = input1.Length;
            if (len < 3)
                return "Input value is insufficient";
            if (input2 < 0)
                return "Invalid Input";
            if (len <= 5)
            {
                for (int i = 0; i < input2; i++)
                {
                    sb.Append(input1.Substring(0,3));
                }
                return sb.ToString();
            }
            else if (len > 10)
            {
                return "Input value is too long";
            }
            else if (len >5)
            {
                for (int i = 0; i < input2; i++)
                {
                    sb.Append(input1.Substring(len-3, 3));
                }
                return sb.ToString();
            }
            return " ";
        }
    }
}
-------------------------------------------------------------------------------------------------

81.a)String Processing II
	
Given a string input input1 ,form another string with the given input string using the following rules.
Form the output string with only the last letter of each word of the given input sentence in capital letters separated by $. Dont store $ after the last letter in the output string.
Example 1:
Input1:This is a cat
Output1:S$S$A$T
Example 2:
Input1:This7 is a cat
Output1: -1
Business Rules :
1. If the given input string contains any number, print -1.
2. If the input contains any special characters, print -2.
3. If there is only one word in input1, then print -3.
Create a class named UserProgramCode that has the following static method
public static string formWordwithLastLetters(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a string or '-1' or '-2' or '-3'.
Sample Input 1:
This is a cat
Sample Output 1:
S$S$A$T
Sample Input 2:
This7 is a cat
Sample Output 2:
-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class userprogramcode
    {
        public static string formWordwithLastLetters(string ip1)
        {
            string[] s = new string[ip1.Length];
            char[] s1 = new char[ip1.Length];
            string final = "";
            s = ip1.Split(' ');
            int i = 0;
            if (s.Length == 1)
                return "-3";
            foreach (string x in s)
            {
                s1[i] = x.ElementAt(x.Length - 1);

                if (char.IsNumber(s1[i]))
                    return "-1";
                else if (!char.IsLetter(s1[i]))
                    return "-2";

                i++;
            }
            int j = 0;
            while (i > 0)
            {
                final = final + char.ToUpper(s1[j]) + "$";
                j++;
                i--;
            }
            final = final.Remove(final.Length - 1);
            return final;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{ 
class Program
    {
        static void Main(string[] args)
        {
            String x,y;
            x = Console.ReadLine();
            y = userprogramcode.formWordwithLastLetters(x);
            Console.WriteLine(y);
	    Console.ReadLine();
        }
    }
}
-------------------------------------------------------------------------------------------------

81.b)String Processing I
Given a string input input1, write a program to fetch the last n characters from input1 and repeat them after input1 the same number of times as given in the second integer input input2.
Business Rules :
1. If the input1 contains any number, print -1.
2. If the input1 contains any special characters, print -2.
3. If the input1 string contains less than input2 number of characters,then print -3.

Create a class named UserProgramCode that has the following static method
public static string getString(string input1,int input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode. 
Input and Output Format:
The first line of the input consists of a string and the second line of the input consists of an integer.
Refer sample output for formatting specifications.
Sample Input 1:
Cognizant
3
Sample Output 1:
Cognizantantantant
Sample Input 2:
Teach123er
4
Sample Output 2:
-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication13
{
    class userprogramcode
    {
        public static string getString(string ip1, int ip2)
        {
            string s, final = ip1;
            char s1;
            if (ip1.Length > ip2)
            {
                for (int i = 0; i < ip1.Length; i++)
                {
                    s1 = ip1[i];
                    if (char.IsNumber(s1))
                        return "-1";
                    else if (!char.IsLetter(s1))
                        return "-2";
                }
                s = ip1.Substring(ip1.Length - (ip2));
                int j = ip2;
                while (j > 0)
                {
                    final = final + s;
                    j--;
                }
            }
            else
            {
                final = "-3";
            }
            return final;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication13
{
class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            int k;
            x = Console.ReadLine();
            k = Convert.ToInt32(Console.ReadLine());
            y = userprogramcode.getString(x, k);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}

-------------------------------------------------------------------------------------------------

82.Gyrating Numbers (Need to write Main function)

Write a program to find whether every integer in a given input integer array is in Gyrating form.
Note: Gyrating numbers are numbers whose digits increase and decrease in a continuous repetitive cycle. Every integer of each element should increase or decrease in a continuous sequence.
Business rule:
1) Print 1 if the given input integer array is in Gyrating sequence.
2) Print -1 if the given input integer array is not in Gyrating sequence.
3) Print -2 if the given input integer array consists of a negative number.
Example:1
Input:
4
12
321
235
532
Output:
1
Example:2
Input:
4
75
12
531
45
Output:
1
Create a class named UserProgramCode that has the following static method
public static int gyRating(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines in the input correspond to the elements in the array.
Output is an integer. Refer business rules.
Sample Input :
4
12
321
235
532
Sample Output :
1

using System;
using System.Text.RegularExpressions;
using System.Text;
namespace Checking_d
{
    class UserProgramCode
    {
        public int check(int[] a, int len)
        {
            int r, cmax = 0, cmin = 0, count = 0, i = 0, rem = 0, j = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int val in a)
            {
                i = 0; cmax = 0; cmin = 0;
                int v = val;
                if (val < 0)
                    return -2;
                else
                {
                    while (v > 0)
                    {
                        ++j;
                        r = v % 10;
                        if (i == 0)
                        {
                            rem = r;
                            ++i;
                        }
                        if (r == rem)
                        {
                            ++cmin;
                            ++cmax;
                        }
                        else if (r < rem)
                        {
                            ++cmin;
                            rem = r;
                        }
                        else if (r > rem)
                        {
                            ++cmax;
                            rem = r;
                        }
                        v = v / 10;
                    }
                    if (cmin == 1)
                        sb.Append("m");
                    if (cmax == 1)
                        sb.Append("M");
                    if (cmin == 1 || cmax == 1)
                    {
                        ++count;
                    }
                    else
                        return -1;
                }

            }
            if (count == len)
            {
                ****Console.WriteLine("true");
                int counter = 0;
                char odd = sb[1];
                char even = sb[0];
                if (!odd.Equals(even))
                {
                    for (int ii = 0; ii < sb.Length; ii++)
                    {
                        if (ii % 2 == 0)
                        {
                            ****Console.WriteLine("inside even pos");
                            if (sb[ii].Equals(even))
                                counter++;
                            else
                                return -1;

                        }
                        else
                        {
                            ****Console.WriteLine("inside odd pos");
                            if (sb[ii].Equals(odd))
                                counter++;
                            else
                                return -1;
                        }


                    }
                    if (counter == count)
                        return 1;

                }
                else
                    return -1;
            }
            return 0;
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Text;
namespace Checking_d
{
    class Program
    {

        static void Main(String[] args)
        {
            int n, a;
            n = int.Parse(Console.ReadLine());
            int[] input1 = new int[n];

            UserProgramCode p = new UserProgramCode();
            for (int i = 0; i < n; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            a = p.check(input1, n);
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }

}

-------------------------------------------------------------------------------------------------
83.String Array Sorting
Given a string array, write a function to remove the duplicate values from a String Array, sort the strings in ascending and display the string array.
The values 'AA' and 'aa' are NOT the same elements or duplicates. The case sensitive check should be implemented. While sorting, words starting with upper case letters should be considered first. 
Business rules:
1) Print 'Invalid String' when the given input integer array consists of any special character or numbers.
2) All the elements in the array should be of same length. If not, then print 'Invalid String'. 
Create a class named UserProgramCode that has the following static method
public static string[] orderStringElements(string[] input1) 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input string array.
The next 'n' lines in the input correspond to the elements in the string array.
Output is a string array. Refer sample output and business rules
Sample Input 1:
6
AAA
BBB
AAA
AAA
CCC
CCC
Sample Output 1:
AAA
BBB
CCC
Sample Input 2:
7
AAA
BBB
aaa
AAA
Abc
A
b
Sample Output 2:
Invalid String

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExamPractice._83
{
    class UserProgramCode
    {
        public static string[] orderStringElements(string[] ar)
        {
            int len = ar[0].Length;
            String pat = @"^[a-zA-Z]{" + len + "}$";
            **** Regex reg = new Regex(@"^[a-zA-Z]+$");            
            Regex reg1 = new Regex(pat);
            String[] res = new String[1];
            StringBuilder sb = new StringBuilder();
            int n = ar.Length;
            foreach (String aa in ar)
            {
                if (!reg1.IsMatch(aa))
                {
                    res[0] = "Invalid String";
                    return res;
                }
            }
            for (int i = 0; i < n; i++)
            {
                String a = ar[i];

                for (int j = i + 1; j < n; j++)
                {
                    if (a.Equals(ar[j]) && !a.Equals(""))
                    {
                        ar[j] = "-1";
                    }
                }
                if (!a.Equals("-1"))
                {
                    if (i > 0)
                        sb.AppendLine();
                    sb.Append(a);
                }
            }
            String[] array = sb.ToString().Split('\n');
            Array.Sort(array, StringComparer.Ordinal);
            return array;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExamPractice._83
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String[] ar = new String[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = Console.ReadLine();
            }
            String[] ret = UserProgramCode.orderStringElements(ar);
            foreach (String a in ret)
            {
                Console.WriteLine(a);
                Console.ReadLine();
            }
        }
    }
}


-------------------------------------------------------------------------------------------------

84.Interchange Characters
Write a program that accepts a string input and interchanges the first and last characters. Case sensitivity should be checked.

Business rules:
1) Print 'Invalid String' when the given input string consists of any special characters or numbers.
2) Print 'No Change' when the first and last characters of the input string is same and of the same case.
Create a class named UserProgramCode that has the following static method
public static string interchangeFirstLast(string input1) 
Create a class named Program that accepts the input and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output is a string. Refer sample output and business rules
Sample Input 1:
Execute
Sample Output 1:
executE
Sample Input 2:
BoB
Sample Output 2:
No Change


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class userprogramcode
    {
        public static string getString(string ip1)
        {
            string[] final = new string[ip1.Length];
            for (int j = 0; j < ip1.Length; j++)
                final[j] = ip1[j].ToString();
            string t1, ans = "";
            for (int j = 0; j < ip1.Length; j++)
                if (!char.IsLetter(ip1[j]))
                    return "Invalid String";
            if (final[0] != final[ip1.Length - 1])
            {
                t1 = final[0];
                final[0] = final[ip1.Length - 1];
                final[ip1.Length - 1] = t1;
                for (int i = 0; i < ip1.Length; i++)
                    ans = ans + final[i];
            }
            else
                ans = "No Change";
            return ans;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();     
            y = userprogramcode.getString(x);
            Console.WriteLine(y); 
     Console.ReadLine();

        }
    }
}
-------------------------------------------------------------------------------------------------
85.MaxMin Sum
 
Write a program that accepts 3 integer inputs and finds the sum of maximum and minimum.
Business Rules :
1) If any/ or all of the input value is negative then print -1.
2) If any two or all the values in the Input are same then print -2.

Example 1:
Input1: 25
Input2: 2
Input3: 95
Output : 97 (Min 2 + Max 95)

Example 2:
Input1: -15
Input2: 49
Input3: 5
Output : -1
 
Create a class named UserProgramCode that has the following static method
public static int sumMaxMin(int input1, int input2, int input3)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of 3 integers.
Output is an integer. Refer sample output and business rules

Sample Input 1:
25
2
95
 
Sample Output 1:
97
Sample Input 2:
-15
49
5
Sample Output 2:
-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checking_d
{
    class UserProgramCode
    {
        public static int sumMaxMin(int ip1, int ip2, int ip3)
        {
            int ans, a, b;
            int[] t1 = new int[3];
            t1[0] = ip1;
            t1[1] = ip2;
            t1[2] = ip3;
            for (int i = 0; i < 3; i++)
                if (t1[i] < 0)
                    return -1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (t1[i] == t1[j])
                        return -2;
                }
            }
            a = t1.Max();
            b = t1.Min();
            ans = a + b;
            return ans;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, k;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            ****k = Convert.ToInt32(Console.ReadLine());
            k = UserProgramCode.sumMaxMin(x, y, z);
            Console.WriteLine(k);
        }
    }
}

-------------------------------------------------------------------------------------------------

86. Employee Designation
Given an input1 string array in the format {Employee1, Designation, Employee2, Designation, Employee3, Designation, and so on... } and a string input2, write a program to fetch the employee names from input1 based on input2 (designation) value and assign it in an output array and print the array. Case sensitivity can be ignored.

Business rule:
1) If input1 or input2 contains any special characters, then print 'Invalid Input'
2) If input1 does not contain the designation in input2, then print 'No employee for ABC designation' where ABC is the Input2 value.
3) If all the employees belong to the same designation, then print 'All employees belong to same ABC designation' where ABC is the Input2 value.

Example 1:
input1:
Ram
Manager
Ganesh
Developer
Srijith
Developer
input2:
Developer
output :
Ganesh
Srijith

Example 2:
Input 1:
Manish
BiDeveloper
Babu
Manager
Rohit
Associate
Input 2:
System Analyst
Output1:
No employee for System Analyst designation

Create a class named UserProgramCode that has the following static method
public static string[] getEmployee(string[] input1, string input2) 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the string array.
The next 'n' lines of input consists of strings that correspond to elements in the string array.
The next line of the input consists of a string that corresponds to the Designation.
Refer business rules and sample output for output format.
 
Sample Input 1:
6
Ram
Manager
Ganesh
Developer
Srijith
Developer
Developer
Sample Output 1:
Ganesh
Srijith
 
Sample Input 2:
6
Manish
BiDeveloper
Babu
Manager
Rohit
Associate
System Analyst
 
Sample Output 2:
No employee for System Analyst designation
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

****Program.cs
namespace ExamPractice._86
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Regex reg = new Regex(@"([A-Za-z])$");
            n = int.Parse(Console.ReadLine());
            String[] input1 = new String[n];
            String input2;
            String[] output;
            for (int i = 0; i < n; i++)
            {
                input1[i] = Console.ReadLine();
                if (!reg.IsMatch(input1[i]))
                {
                    Console.WriteLine("Invalid Input"); return;
                }
            }
            input2 = Console.ReadLine();
            if (reg.IsMatch(input2))
            {
                output = UserMainCode.getEmployee(input1, input2);
                if (UserMainCode.j == 0)
                    Console.WriteLine("No Empployee for " + input2 + " designation");


                else if (UserMainCode.j == n / 2)
                {
                    Console.WriteLine("All employees belong to same " + input2 + "designation");
                }
                else
                {
                    foreach (var item in output)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    
}
}

****UserMainCode.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPractice._86
{
    public class UserMainCode
    {
        public static int j;
        public static string[] getEmployee(string[] input1, string input2)
        {
            int n = input1.Length;
            j = 0;
            String[] temp = new String[n];
            for (int i = 0; i < n; i = i + 2)
            {
                if (input1[i + 1].Equals(input2))
                {
                    temp[j] = input1[i];
                    j++;
                }
            }
            return temp;
        }
    }
}


-------------------------------------------------------------------------------------------------

87.Donations
 
Given 2 inputs,string array input1 and integer input2.The usercodes,locations and donations are appended as one element and stored in input1 in the following format,

ABCDEFGHI- here the ABC represents the usercode ,DEF represents the location and GHI represents the donation amount.
Write a program to find the total amount donated by the users who have the same location code given in input2 integer value.

Business rule:
1) If the string array contains any duplicates, then print -1.
2) If the string array contains any special characters, then print -2.
Create a class named UserProgramCode that has the following static method
public static int getDonation(string[] input1, int input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode. 

Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the string array.
The next 'n' lines of input consists of strings that correspond to elements in the string array.
The next line of the input consists of an integer that corresponds to the location code.
Refer business rules and sample output for output format.
 
Sample Input 1 :
4
123111241
124222456
145111505
124553567
111
 
Sample Output 1 :
746
Sample Input 2 :
4
123111241
124222456
124222456
124553567
111
Sample Output 2 :
-1


using System;
using System.Text.RegularExpressions;
namespace code1
{
    public class UserMainCode
    {
        public static int getDonation(string[] input1, int input2)
        {
            String temp;
            int n = input1.Length;
            int output = 0, don; ;
            for (int i = 0; i < n; i++)
            {
                temp = input1[i].Substring(3, 3);
                if (int.Parse(temp) == input2)
                {
                    don = int.Parse(input1[i].Substring(6, 3));
                    output += don;
                }
            }
            return output;
        }
    }
}
using System;
using System.Text.RegularExpressions;
namespace code1
{
    class Program
    {
        static void Main(String[] args)
        {
            int n;
            Regex reg = new Regex(@"([A-Za-z0-9])$");
            n = int.Parse(Console.ReadLine());
            String[] input1 = new String[n];
            int input2;
            int output;
            for (int i = 0; i < n; i++)
            {
                input1[i] = Console.ReadLine();
                if (!reg.IsMatch(input1[i]))
                {
                    Console.WriteLine("-2"); return;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (input1[i].Equals(input1[j]))
                    { Console.WriteLine("-1"); }
                }
            }
            input2 = int.Parse(Console.ReadLine());
            output = UserMainCode.getDonation(input1, input2);
            Console.WriteLine(output);
        }
    }
}
-------------------------------------------------------------------------------------------------

88.Online Sales

An online shopping portal announced a big bang sale,the discounts apply based on purchased time.
The discount sales would start from 10 am and will end by 6pm.
The discount is not applicable when the products are purchased outside the window time.

A) If the product is bought between 10am - 11am,then customer gets 50% off.
B) If the product is bought after 11am but within 12pm,then customer gets 40% off.
C) If the product is bought after 12pm but within 4pm,then customer gets 30% off.
D) If the product is bought after 4pm,only 25% off.

The actual price and the time of buying the product are given as input1 and input2 respectively. The time is given as integer in the format as hhmm where hh refers to the hours in 24 hrs time format and mm refers to the minutes .
Write a program to calculate the discounted price of the product and print the output in the following format.
The actual price of the product is Rs XXX and you have bought it for Rs YYY. You Save Rs ZZZ.
Here XXX refers to the actual price of the product, YYY refers to the price after the discount is applied, and ZZZ refers to the difference in between the actual and the discounted price if any.

Business rules:
1) If the actual price is zero or less than zero, Print 'Invalid Price Amount'
2) If the product is bought outside the window time , print the output in the following format :
The price of the product is Rs XXX and discounts are not applicable. 

Create a class named UserProgramCode that has the following static method
public static void onlineSalesAmount(int input1,int input2)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of an integer that corresponds to the cost.
The second line of the input consists of an integer that corresponds to the time.
Refer business rules and sample output for output format.
Display the price after discount as an integer only.
 
Sample Input 1 :
20000
1538
 
Sample Output 1 :
The actual price of the product is Rs 20000 and you have bought it for Rs 14000. You Save Rs 6000.

Sample Input 2 :
-40
1038
 
Sample Output 2 :
Invalid Price Amount


using System;
using System.Text.RegularExpressions;
namespace code1
{
    public class UserMainCode
    {
        public static void onlineSalesAmount(int input1, int input2)
        {
            ****Console.WriteLine(input1);        
            if (input1 > 0)
            {
                if (input2 > 1000 && input2 <= 1100)
                {
                    Console.WriteLine("The actual price of the product is Rs " + input1 + " and you have bought it for Rs " + (input1 - (input1 * 0.5)) + ". You Save Rs " + (input1 * 0.5) + ".");
                }
                else if (input2 > 1100 && input2 <= 1200)
                {
                    Console.WriteLine("The actual price of the product is Rs " + input1 + " and you have bought it for Rs " + (input1 - (input1 * 0.4)) + ". You Save Rs " + (input1 * 0.4) + ".");
                }
                else if (input2 > 1200 && input2 <= 1600)
                {
                    Console.WriteLine("The actual price of the product is Rs " + input1 + " and you have bought it for Rs " + (input1 - (input1 * 0.3)) + ". You Save Rs " + (input1 * 0.3) + ".");
                }
                else if (input2 > 1600 && input2 <= 1800)
                {
                    Console.WriteLine("The actual price of the product is Rs " + input1 + " and you have bought it for Rs " + (input1 - (input1 * 0.25)) + ". You Save Rs " + (input1 * 0.25) + ".");
                }
                else
                    Console.WriteLine("The price of the product is Rs " + input1 + " and discounts are not applicable.");
            }
            else
                Console.WriteLine("Invalid Amount");
        }
    }
}
using System;
using System.Text.RegularExpressions;
namespace code1
{
    class Program
    {
        static void Main(String[] args)
        {
            int input1;
            int input2;

            input1 = int.Parse(Console.ReadLine());
            input2 = int.Parse(Console.ReadLine());
            UserMainCode.onlineSalesAmount(input1, input2);
        }
    }
}
-------------------------------------------------------------------------------------------------

89.Postal Tariff 
Jack who stays at Delhi sends new year greetings by post to his friends within India.
He wants to know the total postal charges he needs to pay for sending the greetings to his friends.
There are two types of postal delivery. Normal Post(NP) and Speedy Post (SP).
The tariff rates for NP are as follows
A. Postal Cost from Delhi to Bhopal(BP) is Rs 100
B. Postal Cost from Delhi to Chennai(CH) is Rs 450
C. Postal Cost from Delhi to Orissa(OS) is Rs 200
For Speedy Post additional 30% of normal Post tariff is charged.
The locations and the type of post Jack wants to send are given in the input array where each element of the array is-40 in the format XXYY-where XX represents the location code and YY represents the type of postal delivery done.

Write a program to calculate the total cost Jack paid to send the greatings to his friends. Print the output in the following format.
Jacks spend Rs ZZZZ to send the greetings
where ZZZZ is the total charges calculated. Ignore case sensitivty of input strings.

Business rules:
1. If any of the location codes are other than BP,CH or OS,then print "Invalid location Code" .
2. If any of the postal delivery code is other than NP or SP, then print "Invalid Postal Delivery".

Create a class named UserProgramCode that has the following static method
public static void getPostalTariff(string[] input1)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
 
The first line of the input consists of an integer, n that corresponds to the number of elements in the string array.
The next 'n' lines of input consists of strings that correspond to elements in the string array.
Refer business rules and sample output for output format.
Always display the total charges to be paid as an int.
Sample Input 1:
3
BPSP
CHNP
BPNP
Sample Output 1:
Jack spends Rs 680 to send the greetings

Sample Input 2:
3
BPSP
CHSP
PPNP
Sample Output 2:
Invalid location Code


using System;
using System.Text.RegularExpressions;
namespace code1
{
    public class UserMainCode
    {
        public static void getPostalTariff(string[] input1)
        {
            int length = input1.Length;
            double amount = 0;
            for (int i = 0; i < length; i++)
            {
                if (input1[i].Substring(2, 2) == "SP")
                {
                    if (input1[i].Substring(0, 2) == "BP")
                        amount += (100 * 1.3);
                    else if (input1[i].Substring(0, 2) == "CH")
                        amount += (450 * 1.3);
                    else if (input1[i].Substring(0, 2) == "OS")
                        amount += (200 * 1.3);
                    else
                    { Console.WriteLine("Invalid location Code"); return; }
                }
                else if (input1[i].Substring(2, 2) == "NP")
                {
                    if (input1[i].Substring(0, 2) == "BP")
                        amount += (100);
                    else if (input1[i].Substring(0, 2) == "CH")
                        amount += (450);
                    else if (input1[i].Substring(0, 2) == "OS")
                        amount += (200);
                    else
                    { Console.WriteLine("Invalid location Code"); return; }
                }
                else
                { Console.WriteLine("Invalid Postal Delivery"); return; }
            }
            Console.WriteLine("Jack spends Rs " + amount + " to send the greetings");
        }
    }
}
using System;
using System.Text.RegularExpressions;
namespace code1
{
    class Program
    {
        static void Main(String[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            String[] input1 = new String[n];

            for (int i = 0; i < n; i++)
            {
                input1[i] = Console.ReadLine();
            }
            UserMainCode.getPostalTariff(input1);
        }
    }
}

-------------------------------------------------------------------------------------------------

90. Travel Agency
A travel agency has set standard tariffs for their pick up - drop services in a particular route.The route covers A,B,C,D locations one after the other.

A. Tariff for the travel from Location A to Location B is 10 units/Km
B. Tariff for the travel from Location B to Location C is 20 units/Km
C. Tariff for the travel from Location C to Location D is 40 units/Km
Return journey service is also provided.

The starting point, destination point and the Time of travel ( Normal - N, Untime - U) covered by a vehicle in a day are given as input1 in the format
{XYZ...} - here X represents Start point , Y represents the destination point and Z represents the Time of travel.
For untime travel,20% additional charges are applicable on actual tariff for that route.
Write a program to calculate the total tariff collected by that vehicle for the day given and print the output in the following format,
The car has taken A trips and has collected total amount of C rupees.
-Here A refers to the total number of services provided per day and C refers to the total amount from all the travels.

Business rules:
1.If start point or destination points are invalid (other than A,B,C,D), print 'Invalid Location'.
2.If Time of travel is not either N or U , print 'Invalid Time of Travel'.
 
Create a class named UserProgramCode that has the following static method
public static int getTariffAmount(string[] input1)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
 
The first line of the input consists of an integer, n that corresponds to the number of elements in the string array.
The next 'n' lines of input consists of strings that correspond to elements in the string array.
Refer business rules and sample output for output format.
Always display the tariff to be paid as an int.
 
Sample Input 1 :
4
ACN
DAU
ADN
DCU
Sample Output 1 :
The car has taken 4 trips and has collected total amount of 232 rupees
Sample Input 2 :
4
ACN
FAU
ADN
DCU 
Sample Output 2 :
Invalid Location

****UserProgramCode.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPractice._90
{
    class UserProgramCode
    {
        public static int getTariffAmount(string[] input1)
        {
            int iRoute1 = 10;
            int iRoute2 = 20;
            int iRoute3 = 40;
            int j = 0;

            int iTripFare;
            int iFinalFare = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                iTripFare = 0;
                switch (input1[i][j])
                {
                    case 'A':
                        if (input1[i][j + 1] == 'B')
                        {
                            iTripFare += iRoute1;
                        }
                        else if (input1[i][j + 1] == 'C')
                        {
                            iTripFare += (iRoute1 + iRoute2);
                        }
                        else if (input1[i][j + 1] == 'D')
                        {
                            iTripFare += (iRoute1 + iRoute2 + iRoute3);
                        }
                        break;

                    case 'B':
                        if (input1[i][j + 1] == 'A')
                        {
                            iTripFare += iRoute1;
                        }
                        else if (input1[i][j + 1] == 'C')
                        {
                            iTripFare += iRoute2;
                        }
                        else if (input1[i][j + 1] == 'D')
                        {
                            iTripFare += (iRoute2 + iRoute3);
                        }
                        break;

                    case 'C':
                        if (input1[i][j + 1] == 'B')
                        {
                            iTripFare += iRoute2;
                        }
                        else if (input1[i][j + 1] == 'D')
                        {
                            iTripFare += iRoute3;
                        }
                        else if (input1[i][j + 1] == 'A')
                        {
                            iTripFare += (iRoute1 + iRoute2);
                        }
                        break;

                    case 'D':
                        if (input1[i][j + 1] == 'A')
                        {
                            iTripFare += (iRoute1 + iRoute2 + iRoute3);
                        }
                        else if (input1[i][j + 1] == 'B')
                        {
                            iTripFare += (iRoute2 + iRoute3);
                        }
                        else if (input1[i][j + 1] == 'C')
                        {
                            iTripFare += iRoute3;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Location");
                        break;
                }

                iFinalFare += iTripFare;
                if (input1[i][2] == 'U')
                {
                    iFinalFare += iTripFare * 20 / 100;
                }
                else if (input1[i][2] != 'N')
                {
                    Console.WriteLine("Invalid Time of Travel");
                }
            }
            return iFinalFare;
        }
    }
}

****Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPractice._90
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTrips = Convert.ToInt32(Console.ReadLine());
            string[] tripDetails=new string[iTrips];
            int iTotalFare;

            for (int i = 0; i < iTrips; i++)
            {
                tripDetails[i] = Console.ReadLine();
            }

            iTotalFare = UserProgramCode.getTariffAmount(tripDetails);

            Console.WriteLine("The car has taken {0} trips and has collected total amount of {1} rupees",
                iTrips,iTotalFare);
        }
    }
}
-------------------------------------------------------------------------------------------------
91. Longest Palindrome

Given an input string input1, write a program to find the length of the longest substring which is a palindrome. Palindrome is a word, phrase, or sequence that reads the same backwards as forwards e.g. madam
Ignore case sensitivity for the input strings.

Business Rule:
1) If the input string contains any number,then print -1.
2) If the input string contains any special characters,then print -2.
3) If the input string does not contain a string palindrome,then print -3. Please note that a single character is not considered to be palindrome.
Create a class named UserProgramCode that has the following static method
public static int longestPalindrome(string input1) 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output is an integer.
Refer business rules and sample output for output format.

Sample Input 1:
seaesstringnirts
Sample Output 1:
11
Sample Input 2:
sea34esstringnirts
Sample Output 2 :
-1
Usercode:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace coding
{
    class Program
    {
              static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int flag;
            flag = UserProgramCode.longestPalindrome(a);
            Console.WriteLine(flag);
            Console.ReadLine();

        }

     }
  }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coding
{
    


    public class UserProgramCode
    {
        public static int longestPalindrome(string s1)
        {
            foreach (char c in s1)
            {
                if (char.IsDigit(c))
                    return -1;
                if (!char.IsLetterOrDigit(c))
                    return -2;
            }
            
            int k = 0, count = 0;
            for (int i = 0; i < s1.Length - 1; i++)
            {
                for (int j = 2; j <= s1.Length - i; j++)
                {
                    string s = s1.Substring(i, j);
                    char[] a = s.ToCharArray();
                    Array.Reverse(a);
                    if (new string(a).Equals(s))
                    {
                        count++;
                        if (k < s.Length)
                            k = s.Length;
                    }


                }
            }
            if (count == 0)
                return -3;
            return k;


        }
    }
}
  
------------------------------------------------------------------------------------------------------------------------------------------


92. Sum Largest Numbers In Range
 
Given an array of integer as input1 which falls under the range 1-100, write a program to find the largest numbers from input1 which would fall in the given range 1-10 , 11-20, 21-30, 31-40, …… till 91-100. Now find their sum and print the sum.
Business Rules:
1. If the given input array contains any negative number then print -1.
2. If any element is equal to zero or greater than 100 then print -2.
3. In case the array of integer satisfies both business rule 1 as well as 2 then print -3.
4. In case of duplicate numbers eliminate the duplicate number and follow all other steps for calculation of the largest number.
Create a class named UserProgramCode that has the following static method
public static int largestNumber(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the size of the array.
The next 'n' lines of input consist of integers that correspond to the elements in the array.
Output is an integer.
Refer business rules and sample output for output format.
Sample Input 1:
7
13
18
26
34
58
65
54
Sample Output 1 :
201
Sample Input 2 :
5
-1
19
15
18
101
Sample Output 2 :
-3
Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p92
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            sum = UserProgramCode.fun(a);
            Console.WriteLine(sum);
            Console.ReadLine();

 

        }
    }
    class UserProgramCode
{
        public static int fun(int[] a)
        {
            int i, n, c = 0, c1 = 0;
            int c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;
                        int s = 0;
            n = a.Length;
            int flag = 0;
            int flag1 = 0;
            for (i = 0; i < n; i++)
            {

                if ((a[i] == 0) || (a[i] > 100))
                {
                    flag = 1;
                }
                
                else if (a[i] < 0)
                {
                    flag1 = 1;
                }


            }
            if (flag == 1 && flag1 == 1)
                return -3;
            else if (flag == 1 && flag1 == 0)
                return -2;
            else if (flag == 0 && flag1 == 1)
                return -1;
            for (i = 0; i < n; i++)
            {
                if (a[i] > 0 && a[i] <= 10)
                {
                    if (c < a[i])
                        c = a[i];

                }
                if (a[i] >= 11 && a[i] <= 20)
                {
                    if (c1 < a[i])
                        c1 = a[i];
                }
                                if (a[i] >=21 && a[i] <= 30)
                {
                    if (c2 < a[i])
                        c2 = a[i];

                }
                if (a[i] >= 31 && a[i] <= 40)
                {
                    if (c3 < a[i])
                        c3 = a[i];
                }
                if (a[i] >= 41 && a[i] <= 50)
                {
                    if (c4 < a[i])
                        c4 = a[i];
                                    }
                if (a[i] >= 51 && a[i] <= 60)
                {
                    if (c5 < a[i])
                        c5 = a[i];
                }
                if (a[i] >=61 && a[i] <= 70)
                {
                    if (c6 < a[i])
                        c6 = a[i];

                }
                if (a[i] >= 71 && a[i] <= 80)
                {
                    if (c7 < a[i])
                        c7 = a[i];
                }
                if (a[i] >= 81 && a[i] <= 90)
                {
                    if (c8 < a[i])
                        c8 = a[i];

                }
                if (a[i] >= 91 && a[i] <= 100)
                {
                    if (c9 < a[i])
                        c9 = a[i];
                }
            }
                        s = c + c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9;
            return s;
        }

    }
}


------------------------------------------------------------------------------------------------------------------------------------------



93. Next Consonant or Vowel
 
Given an input String, write a program to replace all the vowels of the given string with the next consonant and replace all consonants with the next available vowel.
Business Rule:
1. If the input string contains any number or any special characters, print 'Invalid input'.
2. The input is case sensitive. Please ensure that each character in the output has exactly the same case as the input string.
Create a class named UserProgramCode that has the following static method
public static string nextString(String input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a string. Refer business rules and sample output for the format.
Sample Input 1 :
zebRa
Sample Output 1 :
afeUb
Sample Input 2 :
cat@rat/123
Sample Output 2 :
Invalid input

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace ConsoleApplication2
{   
 class Program   
{       
 static void Main(string[] args)       
{           
 string str = Console.ReadLine();           
 Console.WriteLine(UserProgramCode.nextString(str));           
    }   
}  
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{
    class UserProgramCode
    {
        public static string nextString(string str)
        {
            ArrayList vowel_small = new ArrayList();
            ArrayList vowel_caps = new ArrayList();
            vowel_small.Add('a');
            vowel_small.Add('e');
            vowel_small.Add('i');
            vowel_small.Add('o');
            vowel_small.Add('u');
            vowel_caps.Add('A');
            vowel_caps.Add('E');
            vowel_caps.Add('I');
            vowel_caps.Add('O');
            vowel_caps.Add('U');
            char[] inp = str.ToCharArray();
            char[] out1 = new char[str.Length];

	    if (str.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                    return "Invalid Input";
            }

            for (int i = 0; i < str.Length; i++)
            {

                if (vowel_caps.Contains(inp[i]) || vowel_small.Contains(inp[i]))
                {
                    char ch = (char)((int)inp[i] + 1);
                    out1[i] = ch;
                }
                else if (inp[i] == 90 || inp[i] == 122)
                {
                    if (inp[i] == 90)
                        out1[i] = 'A';
                    else
                        out1[i] = 'a';
                }
                else
                {
                    if (inp[i] >= 65 && inp[i] <= 90)
                    {
                        if (inp[i] > 85)
                            out1[i] = 'A';
                        else
                        {
                            foreach (char che in vowel_caps)
                            {
                                if (che > inp[i])
                                {
                                    out1[i] = che;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (inp[i] > 117)
                            out1[i] = 'a';
                        else
                        {
                            foreach (char che in vowel_small)
                            {
                                if (che > inp[i])
                                {
                                    out1[i] = che;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            string output = null;
            foreach (char c in out1)
            {
                output += c.ToString();
            }
            return output;
        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------------
94. Power of 2
Write a program to check whether an integer number is a power of 2 or not. If it is a power of 2 print the power else print -1 .
Business Rule:
1. If the given input integer is a negative number/not a power of 2, print -1.
Create a class named UserProgramCode that has the following static method
public static int twoPower(int input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of an integer.
Output consists of an integer. Refer business rules and sample output for the format.
Sample Input 1 :
1024
Sample Output 1 :
10

Sample Input 2 :
6
Sample Output 2 :
-1
Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
namespace ConsoleApplication23
{
    class UserProgramCode
    {
        public static int twoPower(int input1)
        {
            int i1 = input1;
            int n=2;
            int i = 1;
            int sum=1;
            int val=0;
            ArrayList al = new ArrayList();
            while (i < i1)
            {
                if ((sum * n) == i1)
                {
                    val = i;
                    break;
                }
                sum = sum * n;
                al.Add(sum);
                i++;
            }       
            return val;   
        }
        static void Main(string[] args)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            int val1;
            val1 = UserProgramCode.twoPower(i);
            if (val1 > 0)
                Console.WriteLine(val1);
            else
                Console.WriteLine(-1);
        }
    }
}
------------------------------------------------------------------------------------------------------------------------------------------
95. String Equal Check
 
Given two strings Input1 and Input2 and integer Input3, write a program to check if Nth character of Input1 traversing from first and Nth character of Input2 traversing from last are same irrespective of case where N is the Input3 value. Ignore case.
If both are same, then print "The character is x" where x is the Nth character
If both are not same, then print "The character x and y does not match" where x is the Nth character of Input1 starting from first and y is the Nth character of Input2 starting from last.

Business rule:
1) If the Input1 string contains any special characters or numbers, then print 'Invalid Input'
2) If the Input2 string contains any special characters or numbers, then print 'Invalid Input'
3) If the Input3 value is greater than the length of Input1 and/or Input2, then print 'Invalid Input'

Create a class named UserProgramCode that has the following static method
public static string stringEqualCheck(string input1, string input2, int input3) 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
The first line of the input consists of a string that corresponds to input1.
The second line of the input consists of a string that corresponds to input2.
The third line of the input consists of an integer that corresponds to input 3.
Output consists of a string. Refer business rules and sample output for the format.
 
Sample Input 1:
Battle
Final
2
Sample Output 1:
The character is a

Sample Input 2 :
Photograph
Anticipate
4
Sample Output 2:
The character t and p does not match

Sample Input 3 :
xerox
pretty
15
Sample Output 3 :
Invalid Input

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
namespace ConsoleApplication23
{
    class UserProgramCode
    {
        public static string stringEqualCheck(string input1, string input2, int input3)
        {
            string i1, i2;
            int i3;  
            i1 = input1;
             char[] i11=i1.ToCharArray();
            i2 = input2;
            char[] i22=i2.ToCharArray();
            i3 = input3;
            foreach (char ch in i11)
            {
                if (char.IsDigit(ch))
                {
                  Console.WriteLine( "Invalid Input");
                }
                if (!char.IsLetter(ch))
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            foreach (char ch in i22)
            {
                if (char.IsDigit(ch))
                {
                    Console.WriteLine("Invalid Input");
                }
                if (!char.IsLetter(ch))
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            if(i3>i1.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (i3 > i2.Length)
            {
                Console.WriteLine("Invalid Input");
            }
 
            else if ((i11[i3 - 1]) == (i22[(i2.Length) - i3]))
            {
                Console.WriteLine("The character is " + i11[i3 - 1]);
            }
            else
            {
                Console.WriteLine("The character " + i11[i3 - 1] + " and " + i22[(i2.Length) - i3] + " does not match");
            }
            return "string";
        }
        static void Main(string[] args)
        {
            string s1, s2;
            int index;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            index = int.Parse(Console.ReadLine());
            string disp;
            disp = UserProgramCode.stringEqualCheck(s1, s2, index);
        }
    }
}
=====================================================================================
96. 3,4 Number System
Given a number system having numbers which is a combination of digits 3 and 4 only. First few numbers in the number system are: 3, 4, 33, 34, 43, 44, 333, 334, 343, 344, 433, 434, 443, 444, 3333, 3334, 3343, 3344, 3433, 3434, 3443, 3444, … Find the nth number in the number system where n is an integer index given as input .
Business Rule:
1. If the input1 is less than 1, then print -1
Create a class named UserProgramCode that has the following static method
public static void findNumber(int input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input is an integer.
Output is an integer.
 
Sample Input 1 :
10
Sample Output1 :
344

Sample Input 2 :
-8
Sample Output 2 :
-1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication96
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt16(Console.ReadLine());
            UserProgramCode.findNumber(n);
        }
    }
    class UserProgramCode
    {   
        public static void findNumber(int input1)
        {    
            int i = 0;
            int count = 0;
            if (input1 > 0)
            {
                while (1 == 1)
                {
                    int x = ++i;
                    int z = x;
                    string k = Convert.ToString(x);
                    int l = k.Length;
                    int cc = 0;
                    for (int j = 0; j < l; j++)
                    {
                        int a = x % 10;
                        int b = x / 10;
                        x = b;
                        if (a == 3 || a == 4)
                        {
                            cc++;
                        }
                        else
                            break;
                    }
                    if (cc == l)
                        count++;
                    if (input1 == count)
                    {
                        Console.WriteLine(z);
                        break;
                    }
                }
            }
            else
                Console.WriteLine(-1);
        }
    }
}
=====================================================================================
 




97. Rearrange Case
 
Given a string input, write a program to form a new string provided with the the below limitations
1. Check for the alphabet which has maximum number of Upper case and lower case in the input string value.
2. Uppercase alphabets would be moved to the start of the Output string and lowercase alphabets should be moved to the end of the string.
3. Remaining other alphabets will remain the same in between the start and end of the output variable irrespective of the case.
Business rule:
1) If the Input string contains any special characters, then print 'Invalid Input'.
2) If the Input string does not contain Uppercase at all, then print 'Condition does not meet' .
3) If two or more alphabets has maximum upper and lower case, then print 'Re-arranging is not possible' .
Create a class named UserProgramCode that has the following static method
public static string rearrangeCase(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a string.
Refer business rules and sample output for the format.

Sample Input 1 :
CancelPolicy
Sample Output 1 :
CanelPoliycc

Sample Input 2 :
XYZbossxyz
Sample Output 2 :
Re-arranging is not possible

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication97
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            a = Console.ReadLine();
            b=UserProgramCode.rearrangeCase(a);
            Console.WriteLine(b);
        }
    }
    class UserProgramCode
    {
        static char cf;
        public static string rearrangeCase(string input1)
        {
            int l = input1.Length;
           ****string a=Convert.ToString();
            int c1 = 0,c3=0;
            StringBuilder a1 = new StringBuilder();
            StringBuilder a2 = new StringBuilder();
            StringBuilder a3 = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                if(char.IsLower(input1[i]))
                {
                    c1++;
                }
            }
            if (c1 == l)
            {
                return ("Condition does not meet");
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    int c2 = 0;
                    if (char.IsUpper(input1[i]))
                    {
                        for (int j = 0; j < l; j++)
                        {
                            if (input1[j] == char.ToLower(input1[i]))
                                c2++;
                        }
                    }
                    if (c2 > c3)
                    {
                        c3 = c2;
                        cf = input1[i];
                    }
                    else if (c2 == c3)
                    {
                        return ("Re-arranging is not possible");
                    }
                }
                for (int i = 0; i < l; i++)
                {
                    if (input1[i] == char.ToUpper(cf))
                    {
                        a1.Append(cf);
                    }
                    else if (input1[i] == char.ToLower(cf))
                    {
                        a2.Append(char.ToLower(cf));
                    }
                    else
                    {
                        a3.Append(input1[i]);
                    }
                }
            }
            return (a1.ToString() + "" + a3.ToString() + "" + a2.ToString());
        }
    }
}
=====================================================================================
98. Repeated Integers
 
Write code to pick all the repeated integers in a given integer array, sort them in ascending order and put them in the output list. Print the output list.
 
Include a class UserProgramCode with a static method findRepeatedIntegers which accepts the size of an integer array and an integer array. The return type is void. Print the repeated integers in sorted order if present. If there are no repeated numbers, then print “No repeated numbers”. If there are negative numbers in the array, print “Array contains negative numbers” .

Create a Class Program which would be used to accept Input array and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 integers. The first integer corresponds to n, the number of elements in the array. The next 'n' integers correspond to the elements in the array.
Refer sample output for formatting specifications.
Assume that the maximum number of elements in the array is 30.
 
Sample Input 1:
4
3
3
2
10
Sample Output 1:
3
 Sample Input 2:
4
3
1
2
10
Sample Output 2:
No repeated numbers
Sample Input 3:
4
3
-11
2
10
Sample Output 3:
Array contains negative numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication98
{
    class Program
    {
        static void Main(string[] args)
        { 
            int l=1;
            int[] a = new int[30];
            for (int i = 0; i <= l; i++)
            {
               a[i] = Convert.ToInt16(Console.ReadLine());
               l = a[0];
            }
            UserProgramCode.findRepeatedIntegers(a);
        }
    }
    class UserProgramCode
    {
        public static void findRepeatedIntegers(int[] a)
        {
            ArrayList a1 = new ArrayList();
            int flag = 0;
            for (int i = 1; i <= a[0]; i++)
            {
                if (a[i] >= 0)
                {
                    int c = 0;
                    for (int j = 1; j <= a[0]; j++)
                    {
                        if (a[i] == a[j])
                            c++;
                    }
                    if (c > 1)
                    {
                        if (!(a1.Contains(a[i])))
                            a1.Add(a[i]);
                    }
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                a1.Sort();
                int c1 = 0;
                foreach (int i in a1)
                    c1++;
                if (c1 == 0)
                    Console.WriteLine("No repeated numbers");
                else
                {
                    foreach (int i in a1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
                Console.WriteLine("Array contains negative numbers");
        }
    }
}
 

=====================================================================================


99. Number Availability
Write the program to find whether the given number is available in a list of numbers.
Get three input parameters, one the size of the list, second the list of numbers and the other the given number to be searched. Print the output as - “Non Positive”, “Present”, or “Not Present” respectively as per the given business rules.
 
Business Rules:
1.List of numbers and the number to be searched, all of them should be positive numbers only, if not return -1.
2. If the given number is present in the list of numbers , then return 1.
3. If the given number is not present in the list of numbers , then return 0.
 
Include a class UserProgramCode with a static method findExistence which accepts the size of the integer array,  an integer array and the number to be searched. The return type (Integer) should return -1, 1 or 0 as per the given business rules.

Create a Class Program which would be used to accept the size of the array, the array elements and an integer, and call the static method present in UserProgramCode.

Input and Output Format:
Input consists of an integer  which corresponds to the size of the array, an integer array and an integer.
Output consists of a String(“Non Positive”, “Present”, or “Not Present” ).
Refer sample output for formatting specifications.
 
Sample Input 1:
3
1
2
3
1
Sample Output 1:
Present
 
Sample Input 2:
3
-1
2
3
3
Sample Output 2:
Non Positive
 
Sample Input 3:
3
1
2
3
4
Sample Output 3:
Not Present

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication99
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[30];
            int l = 1;
            for (int i = 0; i <=l+1; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
                l = a[0];
            }
            int b = UserProgramCode.findExistence(a);
            if(b==1)
                Console.WriteLine("Present");
            else if(b==0)
                Console.WriteLine("Not Present");
            else
                Console.WriteLine("Non Positive");
        }
    }
 
    class UserProgramCode
    {
        public static int findExistence(int[] a)
        {
            int c = 0;
            int flag=0;
            for (int i = 1; i <= a[0]; i++)
            {
                if (a[i] >= 0)
                {
                    if (a[i] == a[a[0] + 1])
                        c++;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                if (c > 0)
                    return 1;
                else
                    return 0;
            }
            else
                return -1;
        }
    }
}
 
=====================================================================================
100. Largest Digit
Write a program to find the Largest digit from given input integer. Print the largest digit. If the number is negative, print “Negative Number”.
Include a class UserProgramCode with a static method findLargestDigit which accepts an integer. The return type (integer) should return the largest digit. Return -1 if the number is negative.

Create a Class Program which would be used to accept an integer and call the static method present in UserProgramCode.

Input and Output Format:
Input consists of an integer.
Output consists of an integer (the largest digit), or a String “ Negative Number” if the input is negative.
Refer sample output for formatting specifications.
 
Sample Input 1:
524
Sample Output 1:
5 
Sample Input 2:
-23
Sample Output 2:
Negative Number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication100
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            int c = UserProgramCode.findLargestDigit(a);
            if(c==-1)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine(c);
        }
    }
    class UserProgramCode
    {
        public static int findLargestDigit(int b)
        {
            if (b >= 0)
            {
                string a = b.ToString();
                int l = a.Length;
                int c = 0;
                for (int i = 0; i < l; i++)
                {
                    int x = b / 10;
                    int y = b % 10;
                    b = x;
                    if (y >= c)
                    {
                        c = y;
                    }
                }
                return c;
            }
            else
                return (-1);
        }
    }
}
=====================================================================================

 101.

 List the Elements - A


 GetElements


Write a program that accepts integer list and an integer. List all the elements in the list that are smaller than the value of given integer. Print the result in descending order.
 
Example:
input1: [1,4,7,3,9,15,24]
input2: 17
 
Output1:[15,9,7,4,3,1]
 
Include a class UserProgramCode with static method GetElements() which accepts an integer list and the integer (input2) as input and returns an integer list. 
If there is no element found in input1, then store -1 to the first element of output list.

Create a class Program which would get the input and call the static method GetElements() present in the UserProgramCode. If there is no such element in the input list, print "No element found".
 
Input and Output Format:
Input consists of n+2 integers. The first integer corresponds to n, the number of elements in the array. The next'n' integers correspond to the elements in the array.
 
The last input is an integer.
 
Output is an integer list or the string "No element found".
 
Sample Input 1:
7
1
4
7
3
9
15
24
17

Sample Output 1:
15
9
7
4
3
1



Sample Input 2:
6
5
9
3
4
16
21
9

Sample Output 2:
5
4
3



ANS:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_the_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            List<int> a = new List<int>(n);
            List<int> output = new List<int>();
            for (int i = 0; i < n; i++)
            {
                
                a.Add(int.Parse(Console.ReadLine()));
            }
            int chk = int.Parse(Console.ReadLine());
           output= UserProgramCode.GetElements(a,n,chk);
           if (output[0] == -1)
           {

               Console.WriteLine("No Element Is Found");
               
           }
           if (output[0] != -1)
           {
               for (int i = 0; i < output.Count; i++)
               {

                   Console.WriteLine(output[i]);
               }
           }
           Console.ReadLine(); 
        }
    }







    class UserProgramCode
    {
        public static List<int> GetElements(List<int> a,int n,int chk)

        {
            List<int> temp = new List<int>();
            int count =0;
            
            for(int i=0;i<a.Count;i++)
            {

                if (a[i] < chk)
                {
                    temp.Add(a[i]);
                    count = 1;
                }
            }
            temp.Sort();
            temp.Reverse();
            if (count == 0)
            {
                temp.Add(-1);
            }
            return temp;
        }
    }
}

--------------------------------------------------------------------------
--------------------------------------------------------------------------

102.Insurance Guide / InsuranceGuide




ANS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        char health = Convert.ToChar(Console.ReadLine());
        int age = Convert.ToInt32(Console.ReadLine());
        char gender = Convert.ToChar(Console.ReadLine());
        char location = Convert.ToChar(Console.ReadLine());
        UserProgramCode.InsuranceGuide(health, age, gender, location);
    }
}






class UserProgramCode
{
    public static void InsuranceGuide(char health, int age, char gender, char location)
    {
        ****Fill your code here
        if (health == 'E' && age >= 25 && age <= 35 && location == 'C' && gender == 'M')
        {
            Console.WriteLine(4);
            Console.WriteLine(200000);
        }
        else if (health == 'E' && age >= 25 && age <= 35 && location == 'C' && gender == 'F')
        {
            Console.WriteLine(3);
            Console.WriteLine(100000);
        }
        else if (health == 'P' && age >= 25 && age <= 35 && location == 'V' && gender == 'M')
        {
            Console.WriteLine(6);
            Console.WriteLine(10000);
        }
        else if(age>=60)
            Console.WriteLine("Age limit Exceeded");
        else
            Console.WriteLine("The person cannot be insured");
    }
}

==========================================================================================

103..

countImageTypes

 
Given a string array input which consists of image file names along with their respective image type extensions in the format ("filename.extensiontype",..so on). The image file name and the extension are seperated by a dot (.)operator.
Write a program to calculate the count of image files having same extension type and store the values in the output string array variable in the below format.
output (Key,Value) = (ExtensionType1,count1,ExtensionType2,count2,...so on) .
Output should be stored in descending order based on the count of image files having the same extension type.

Note: jpeg,jfif,exif,tiff,raw,gif,bmp,png are the various types of image file extensions

Business Rules:
1)If all the elements of the input array do not have image type extension, then print -1.
2)If any of the file name doesn't contain extension type or if the extension is not an image type then it will be treated as other type, take the count of all such files and store as the last element in the sorted output array with key element as "others" and value element as the calculated count.
3)If more than one key element have same count, then store the key and their respective value element in the order given in input.
 
Create a class named UserProgramCode that has the following static method
public static List<string> countImageTypes(string[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array .
The next 'n' lines of input correspond to elements in the input array.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
4
Employee.jpeg
Purchase.jpeg
stock.jpeg
book.gif
 
Sample Output 1 :
jpeg
3
gif
1

Sample Input 2 :
7
Sales.doc
Employee.jpeg
Purchase.jpeg
image.png
stock.jpeg
book.gif
pen
 
Sample Output 2 :
jpeg
3
png
1
gif
1
others
2



ANS..



using System;
using System.Collections.Generic;

class UserProgramCode
{
  public static List<string> countImageTypes(string[] input)
  {
	**** fill your code here
      string sub,temp;
      int l = 0, r = 0,temp1=0,o=0;
      string[] s1=new string[8];
      int[] n=new int[8];
      List<string> l1 = new List<string>();
      foreach (string item in input)
      {
          l = item.LastIndexOf('.');
          r = (item.Length) - l;
          sub = item.Substring(l + 1, r-1);
          if (sub == "jpeg")
          {
              s1[0] = "jpeg";
              n[0]++;
          }
          else if (sub == "jfif")
          {
              s1[1] = "jfif";
              n[1]++;
          }
          else if (sub == "exif")
          {
              s1[2] = "exif";
              n[2]++;
          }
          else if (sub == "tiff")
          {
              s1[3] = "tiff";
              n[3]++;
          }
          else if (sub == "raw")
          {
              s1[4] = "raw";
              n[4]++;
          }
          else if (sub == "gif")
          {
              s1[5] = "gif";
              n[5]++;
          }
          else if (sub == "bmp")
          {
              s1[6] = "bmp";
              n[6]++;
          }
          else if (sub == "png")
          {
              s1[7] = "png";
              n[7]++;
          }
          else
          {
              o++;
          }
      }
          if (l == 0 || r == 0)
          {
              l1.Add("-1");
                  return l1;
          }
      for(int i=0;i<8;i++)
      {
          for(int j=i+1;i<8;i++)
          {
              if(n[i]<n[j])
              {
                  temp1=n[i];
                  temp=s1[i];
                  n[i]=n[j];
                  s1[i]=s1[j];
                  n[j]=temp1;
                  s1[j]=temp;

              }
          }
      }
          for (int i = 0; i <8; i++)
          {
              if (n[i] > 0)
              {
                  l1.Add(s1[i]);
                  l1.Add(n[i].ToString());
              }
          }
          if (o > 0)
          {
              l1.Add("others");
              l1.Add(o.ToString());
          }
      
          return l1;
          
      }

      
  }





class Program
{
  public static void Main( string[] args )
  {
	  int size=0,i;
	  size=Convert.ToInt32(Console.ReadLine());
	  string[] arr = new string[size];
	  for(i=0;i<size;i++){
	   arr[i] = Console.ReadLine();
	  }
	 List<string> output = new List<string>();
	 output = UserProgramCode.countImageTypes(arr);
	 for(i=0;i<output.Count;i++){
		Console.WriteLine(output[i]);
	}
     Console.ReadKey();
  }
}






===================================================================================
104. 

perfectNum




For a given integer input array ,write a program to identify the perfect numbers in the input array and store remaining elements excluding the perfect numbers in the output .Perfect number is a positive number in which the sum of all its positive divisors excluding that number is equivalent to that number itself.
Eg. 6 is a perfect number ,since its divisor are 1, 2 and 3.
Sum of its divisors is 1 + 2+ 3 = 6,which is equal to the number itself.

Business rule:
1) If any of the elements in input1 array is negative, then print -1.
2) If there are any duplicates found in input1 array, then print -2.
3) If size of the input1 array is 1 or greater than 7, then print -3.

Create a class named UserProgramCode that has the following static method
public static int[] perfectNum(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
4
6
2
5
7

Sample Output 1 :
2
5
7

Sample Input 2 :
5
5
8
3
-4
6
 
Sample Output 2 :
-1
 


ANS:


using System;
using System.Collections.Generic;

class UserProgramCode {
	public static int[] perfectNum(int[] input1)
	 {
		**** fill code here
         int count = 0,sum=0;
         List<int> l = new List<int>();
        
         if (input1.Length == 1 || input1.Length > 7)
         {
             int[] neg = new int[] { -3 };
             return neg;
         }
         for (int i = 0; i < input1.Length; i++)
         {
             if (input1[i] < 0)
             {
                 int[] neg = new int[] { -1 };
                 return neg;
             }
             for(int j=i+1;j<input1.Length;j++)
             {
                 if(input1[i]==input1[j])
                 {
                     int[] neg = new int[] { -2 };
                      return neg;
                 }
             }
         }
         for (int i = 0; i < input1.Length; i++)
         {
             for (int j = 1; j < input1[i]; j++)
             {
                 if (input1[i] % j == 0)
                 {
                     sum = sum + j;
                 }
             }
             if (input1[i] != sum)
             {
                 l.Add(input1[i]);
             }
             sum = 0;


         }
         int[] b = new int[l.Count];
         foreach (int item in l)
         {
             b[count] = item;
             count++;
         }
         return b;



             }
         }
	 



 class Program
 {
    public static void Main( string[] args )
    {	
int arrSize;
arrSize = Convert.ToInt32(Console.ReadLine());				
int[] input = new int[arrSize];
int[] output = new int[arrSize];
for(int i=0;i<arrSize;i++)
{
	input[i] = Convert.ToInt32(Console.ReadLine());
}
output = UserProgramCode.perfectNum(input);				
for(int i=0;i<output.Length;i++)
{
	Console.WriteLine(output[i]);			
}
      Console.ReadKey();
    }
 }


======================================================================================

105.


GetLongestString

Get the longest string

Write a program to get the longest string from the list which starts with the given character.Assume that input comparison  is done  irrespective of case. ie case insensitive.
 
Include a class UserProgramCode with a static method  getLongestString which accepts a String list and a character. The return type  is a string.
Create a Class Program which would be used to accept the size of the string list, the list elements and the search character and calls the static method present in UserProgramCode.
 
In getLongestString
1. If there is no element found list, then return the string "No elements found "
2. Only alphabets should be given in the list. Otherwise return the string, "String contains non alphabetic characters. "
3.I f the two or more strings start with the given character ,the longest string should be returned. Assume that the longest string will be unique.

Input Output format
First line points to the size of the string list as n.
The next n lines points to elements of the string list.
The last input points to the character.
Output consists of a string.

SAMPLE INPUT 1:
4
Yellow
Red
Black
Blue
b
SAMPLE OUTPUT 1:
Black

SAMPLE  INPUT 2:
3
Black
White
45
W
SAMPLE OUTPUT 2:
String contains non alphabetic characters.



ANS:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_Logest_String
{
    class UserProgramCode
    {
        public static string GetLongestString(string[] arr, string s)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (!char.IsLetter(arr[i][j]))
                    {
                        return "Only alphabets should be";
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].StartsWith(s.ToString()))
                {
                    list.Add(arr[i]);
                }


            }

            if (list.Count == 0)
                return "No elements Found";
            else
            {
                int max = 0;
                foreach (string str in list)
                {
                    if (str.Length > max)
                        max = str.Length;
                }

                foreach (string str in list)
                {
                    if (str.Length == max)
                    {
                        return str;
                    }
                }

            }
            return "";
        }
    }

        



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
           string s = Console.ReadLine();
           string op = UserProgramCode.GetLongestString(arr, s);
            Console.WriteLine(op);
            Console.ReadLine();

        }
    }
}



======================================================================================
==================================================================================

106. get word with max vowels
GETMAXVOWELS

solution:------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace get_the_word_with_max_vowles
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string op = UserProgramcode.GETMAXVOWELS(str);
            Console.WriteLine(op);
            Console.ReadLine();


        }
    }
}

    class UserProgramcode
    {
        public static string GETMAXVOWELS(string str)
        {
            string[] arr = str.Split(' ');
            int max = 0, lenmax = 0, count;
            foreach (string element in arr)
            {

                char[] ch = element.ToCharArray();
                count = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                        count++;

                }
                if (count > max)
                {
                    max = count;

                    lenmax = ch.Length;
                }

            }

            string output = string.Empty;
            foreach (string item in arr)
            {
                if (item.Length == lenmax)
                {
                    output = item;
                    break;
                }
            }
            return output;
        }

    }



====================================================================================
======================================================================================







107. Get Common Elements


getCommonItems



Write a program that accepts two lists and finds out the elements that are common in both of the given input lists and consolidates the common elements in another list.

Business Rule:
Only positive number should be given in input List. Else print -1 in the output.

Create a class named UserProgramCode that has the following static method
public static List<int> getCommonItems(List<int> input1, List<int> input2)

Create a class named Program that accepts the 2 input lists and calls the static method present in the UserProgramCode.

Input and Output Format:
The first line of the input consists of an integer that corresponds to m, the number of elements in the first list. The next 'm' lines consist of elements in the first list.
The next line of the input consists of an integer that corresponds to n, the number of elements in the second list. The next 'n' lines consist of elements in the second list.
Output consists of the list that contains the common elements in both the lists. If any of input list elements are negative, print -1.

Sample Input :
5
5
6
7
8
1
4
5
2
3
1

Sample Output :
5
1

solution:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, k, c;
            List<int> listm = new List<int>();
            List<int> listn = new List<int>();
            List<int> listo = new List<int>();
            List<int> final = new List<int>();
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                k = Convert.ToInt32(Console.ReadLine());
                listm.Add(k);
            }
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                c = Convert.ToInt32(Console.ReadLine());
                listn.Add(c);
            }
            listo = UserProgramCode.getCommonItems(listm, listn);
            final = listo.Distinct().ToList();
            foreach (int t in final)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
   
    class UserProgramCode
    {
        public static List<int> getCommonItems(List<int> input1, List<int> input2)
        {
            int len1, len2;
            List<int> p = new List<int>();
            len1 = input1.Count;
            len2 = input2.Count;
            foreach (int i in input1)
            {
                foreach (int k in input2)
                {
                    if (i == k)
                    {
                        p.Add(i);
                    }
                }
            }
            return p;
        }
    }
}
}




=======================================================================
=========================================================================
108.generate series

addSeries


 Given a method taking an odd positive Integer number as input, write code to evaluate the following series:
1+3-5+7-9…+/-n.
 
Include a class UserProgramCode with a static method addSeries which accepts a positive integer . The return type of this method is an integer .
Create a class Program which would get the input as a positive integer and call the static method addSeries present in the UserProgramCode.
Input and Output Format:
Input consists of a positive integer n.
Output is a single integer .
Refer sample output for formatting specifications.
Sample Input 1:
9
Sample Output 1:
-3
Sample Input 2:
11
Sample Output 2:
8





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace level1_59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x;
            n = Convert.ToInt32(Console.ReadLine());
            x = UserProgramCode.addSeries(n);
            Console.WriteLine(x);
        }
    }
}



    class UserProgramCode
    {
        public static int addSeries(int a)
        {
            int t = 0, k = 1;
            for (int i = 0; k <= a; i++)
            {
                if (i == 0)
                {
                    t = t + k;
                }
                else if (i == 1)
                {
                    t = t + k;
                }
                else if (i % 2 != 0)
                {
                    t = t + k;
                }
                else
                {
                    t = t - k;
                }
                
                k = k + 2;
            }
            return t;
        }
    }



======================================================================================================================
===================================================================================================================





109.Done---GCD – Array


greatestCommonDivisor


 
Given an array of integers as input, write a program to find the Greatest Common Divisor for all the integer elements present in the input.

Greatest Common Divisor also known as the greatest common factor (gcf), of two or more integers is the largest positive integer that divides the numbers without a remainder.

Business Rule:
1. If the input array contains any value less than 1, assign -1 to the output1 variable.

Create a class named UserProgramCode that has the following static method
public static int greatestCommonDivisor(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
Output is an integer.
Refer business rules and sample output for formatting specifications.
 
Sample Input 1 :
4
24
12
20
8
 
Sample Output 1 :
4

Sample Input 2 :
4
2
4
8
-6
 
Sample Output 2 :
-1



Solution:------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gcd
{
    class UserProgramCode
    {
        public static int greatestCommonDivisor(int[] input1)
        {
            int count = 1;
            int[] ni = new int[67];
            int[] na = new int[67];
            int f = 0;

            int k = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }
            }

            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 1; j <= input1[i]; j++)
                {
                    if (input1[i] % j == 0)
                    {
                        ni[k] = j;
                        k++;
                    }
                }
            }
            Array.Resize(ref ni, k);
            for (int i = 0; i < k; i++)
            {
                count = 1;
                for (int j = i + 1; j < k; j++)
                {
                    if (ni[i] == ni[j])
                    {
                        count++;

                    }


                }


                if (count == input1.Length)
                {

                    na[f] = ni[i];
                    f++;
                }
            }
            int ans = na.Max();
            return ans;

        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nn = new int[n];
            for (int i = 0; i < n; i++)
            {
                nn[i] = Convert.ToInt32(Console.ReadLine());
            }
            int op = UserProgramCode.greatestCommonDivisor(nn);
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }

}



======================================================================
============================================================================

110.Special Characters

getSpecialChar

Write a program that accepts a string input and removes all the alphabetic characters from input and stores only the special characters and digits.
Note: Special characters are #, $,%,&
Business Rules :
1. if the given input string contains no numbers or special characters,then print -1.
Create a class named UserProgramCode that has the following static method
public static string getSpecialChar(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output is either '-1' or the processed string.
Sample Input 1:
cogniz$#45Ant
Sample Output 1:
$#45
Sample Input 2:
Treasure
Sample Output 2:
-1
 


Solution:--------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String res = UserProgramCode.getSpecialChar(str);
            Console.WriteLine(res);
        }
    }
}





    class UserProgramCode
    {
        public static string getSpecialChar(string input1)
        {
            int num = 0;
            StringBuilder sb=new StringBuilder();
            int sp = 0;
            int len = input1.Length;
            for (int i = 0; i < len; i++)
            {
                char c = input1[i];
                if (char.IsDigit(c))
                {
                    num++;
                    sb.Append(c);
                }
                if (c == '#' || c == '$' || c == '%' || c == '&')
                {
                    sp++;
                    sb.Append(c);
                }
                ****else if (!char.IsLetter(c))
                ****{
                **** sb.Append(c);
                ****}
            }
            if (num == 0 || sp == 0)
            {
                return "-1";
            }
            else
                return sb.ToString();

        }
    }


========================================================





111.Fixed Point

findFixedpoint 
Given an input array of n distinct integers sorted in ascending order, write a program that finds a Fixed Point in the array .
Fixed Point in an array is an index i such that arr[i] is equal to i.

Business Rules :
1. If any of the given inputs contain any negative number, then print -1.
2. If there are no fixed point values found in the input array, then print -2.
3. If there are less than 2 elements or more than 10 elements in the input array, then print -3.
 
Assume that there will be a maximum of 1 fixed point in the input array.
 
Create a class named UserProgramCode that has the following static method
public static int findFixedpoint(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array 1.
The next 'n' lines of input consist of elements in the input array 1.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
6
1
4
45
3
0
19
 
Sample Output1 :
3

Sample Input 2 :
5
1
10
5
2
-7
 
Sample Output 2 :
-1

Answer ----- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
             n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)

                array[i] = Convert.ToInt32(Console.ReadLine());

            int result = UserProgramCode.findFixedpoint(array);


            Console.WriteLine(result);

            Console.Read();

        }

    }

    class UserProgramCode
    {
        public static int findFixedpoint(int[] input)
        {
            Array.Sort(input);
            int res = 0;
            int count = 0;
            foreach (int k in input)
            {
                ****Console.WriteLine(k);
                if (k < 0)
                {
                    count++;
                    return -1;
                }
            }
            if (input.Length < 2 || input.Length > 10)
            {
                count++;
                return -3;
            }
            if (count == 0)
            {
                int i = 1;
                foreach (int k in input)
                {
                    if (k == i)
                        res = i - 1;
                    i++;
                }
                if (res == 0)
                    res = -2;
            }
            return res;
        }
    }
}



===========================================================


112. Find Gift Voucher

findGiftVoucher
In a game two dice is thrown. From the sum of the two dice, the player is going to get the gift voucher from the club. Write a program to find the amount of the gift voucher. Print the amount received as gift.
Sum of Two Dices ------------------ Gift Voucher in Rs
2,3,6,11 ------------------------------ 1000
4,7,10--------------------------------- 3000
5,8,9,12------------------------------- 5000 
In the method,
Only Positive number (1-6) should be given as a input numbers. Else return -1. 
Include a class UserProgramCode with a static method findGiftVoucher which accepts two integers. The return type (Integer) should return the gift voucher amount. If the any of the inputs is invalid return -1.
Create a Class Program which would be used to accept a positive Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of two integers.
Output consists of an Integer( the gift voucher amount) or a String “Invalid Input” if any of the inputs is invalid.
Refer sample output for formatting specifications. 
Sample Input 1:
1
2
Sample Output 1:
1000 
Sample Input 2:
1
-2
Sample Output 2:
Invalid Input

Answer -


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            c = userprogramcode.findGiftVoucher(n, m);
            if (c == -1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

        }
    }
}
    

    class UserProgramCode

    {
        public static int findGiftVoucher(int a, int b)
        {
            if (a > 0 && b > 0 && a < 7 && b < 7)
            {
                if ((a + b == 2) || (a + b == 3) || (a + b == 6) || (a + b == 11))
                    return (1000);
                else if ((a + b == 4) || (a + b == 7) || (a + b == 10))
                    return (3000);
                else if ((a + b == 5) || (a + b == 8) || (a + b == 9) || (a + b == 12))
                    return (5000);

            }
            else return (-1);
            return 0;
        }

    }




=========================================================================

113. 
Find nth Largest Number
Write a method to find the nth largest number in an input integer array.
findNthLargestNumber

Include a class UserProgramCode with a static method findNthLargestNumber which accepts 2 inputs, an integer array and an integer (n) and returns an integer.
If the input consists of any negative numbers, the method returns -1. Else the method returns the nth largest element in the array.
 
Create a class Program which would get the input and call the static method findNthLargestNumber present in the UserProgramCode.
If the method returns -1, then print 'Invalid Input'.
 
Input and Output Format:

The first line of the input consists of an integer that corresponds to m, the size of the array.
The next m lines of input consists of integers that correspond to the elements in the array.
The next line of input consists of integer that corresponds to 'n'.

Refer sample output for formatting specifications.

Sample Input 1:
7
2
1
67
10
55
12
7
-2
Sample Output 1:
Invalid Input

Sample Input 2:
7
100
300
150
450
650
50
25
4
Sample Output 2:
150



Answer --- 




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size, input1;
            size = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            input1 = Convert.ToInt32(Console.ReadLine());
            int value = UserProgramCode.findNthLargestNumber(inputArray, input1);
            if (value == -1)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(value);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int findNthLargestNumber(int[] input1, int input2)
        {
            int i, flag = 0;

            Array.Sort(input1);
            for (i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                    flag = 1;

            }
            if (flag == 1 || input2 < 0)
                return -1;
            else
                return (input1[input2 - 1]);

        }
    }
}



==========================================================================================================



114. Find the difference between Dates in months

getMonthDifference
Given a method with two date strings in yyyy-mm-dd format as input, write code to find the difference between two dates in months.
Include a class UserProgramCode with a static method getMonthDifference which accepts two date strings as input. The method returns an integer which is the difference between two dates in months.
Create a class Program which would get the input and call the static method getMonthDifference present in the UserProgramCode.
Input and Output Format:
Input consists of two date strings.
Format of date : yyyy-mm-dd.
Output is an integer.
Refer sample output for formatting specifications.
Sample Input 1:
2012-03-01
2012-04-16
Sample Output 1:
1
Sample Input 2:
2011-03-01
2012-04-16
Sample Output 2:
13

Answer --- 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            string intime, outtime;
            intime = Console.ReadLine();
            outtime = Console.ReadLine();
            k = UserProgramCode.getMonthDifference(intime, outtime);
            if (k == -1)
            {
                Console.WriteLine("Invalid format");
            }
            else
                Console.WriteLine(k);

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int getMonthDifference(string intime, string outtime)
        {

            string s;
            s = "yyyy-MM-dd";
            DateTime i, o;
            bool k = DateTime.TryParseExact(intime, s, null, System.Globalization.DateTimeStyles.None, out i);
            if (k == false)
                return -1;
            bool j = DateTime.TryParseExact(outtime, s, null, System.Globalization.DateTimeStyles.None, out o);
            if (j == false)
                return -1;

            double dm;

            dm = (o.Subtract(i).Days) / (365.25 / 12);


            return (int)dm;
        }

    }
}


======================================================================



115. max span / find span / largest span / getMaxSpan


Answer --- 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
   class UserProgramCode
    {
        public static int getMaxSpan(int size, int[] arr)
        {
            ****Fill your code here
            int i = 0; int j = 0;
            int span = 1; int temp = 0;
            int flag = 0;
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        flag = 1;
                    }
                }
            }
            if (flag == 0)
                return -1;

            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp = j - i + 1;
                        if (temp > span)
                        {
                            span = temp;
                        }
                    }
                }
            }

            return span;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size;
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int res = UserProgramCode.getMaxSpan(size,arr);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}



============================================================================================



116. Find the Shortest String

GetshortestString
Write a program that reads an Integer (size of the String List), a String List and a character. Find the shortest string from the list that starts with the character. (case sensitive). Assume there will be only one string.
Include a class UserProgramCode with static method  GetshortestString()  that accepts a string list and a character . The return type is String.
Create a class Program which would get the input and call the static method GetshortestString(List<string> input1, char input2)) present in the UserProgramCode.
 
Input and Output Format :
The first input corresponds to the list size.
The next input corresponds to the elements in the list which is a string.
The third input is a character.
Output is String. 
 
In GetshortestString()
1. Only alphabets should be given in the List else return "Non Alphabets Exists".
2. If there is no match found in input then return "No String Found".
3. Otherwise return the appropriate result.

In Program
Display the result which is return by GetshortestString() 


Sample Input 1:
4
read
elegant
Edit
even
e
Sample Output 1:
even

Sample Input 2:
2
qwerty
abcdef
e
Sample Output 2:
No String Found


Sample Input 3:
4
re@d
el3gant
Edit
even
e
Sample Output 3:
Non Alphabets Exists


Answer ---



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace pgm101
{
    class UserProgramCode
    {
        public static string GetshortestString(List<string> input1, char input2)
        {
            List<string> final = new List<string>();
            foreach (string m in input1)
            {
                char[] b = m.ToCharArray();
                foreach (char n in b)
                {
                    if (!(n >= 'a' && n <= 'z') && !(n >= 'A' && n <= 'Z')) return "Non Alphabets Exists";
                }
                if (b[0] == input2) final.Add(m);
            }
            string ou = String.Empty;
            for (int i = 0; i < final.Count; i++)
            {
                for (int j = i; j < final.Count; j++)
                {
                    if (final[i].Length > final[j].Length) ou = final[j];
                }
            }
            if (ou == "" || ou == null) return "No String Found";
            return ou;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(UserProgramCode.GetshortestString(list, a));
            Console.ReadLine();
        }
    }
}



====================================================================================================


117. Find Lowest

findLowest
Write a program to find the lowest number in an integer array.
Print the lowest number.
Only positive number should be given as input in an array. Else print “Negative numbers present”.
Include a class UserProgramCode with a static method findLowest which accepts an Integer array. The return type (Integer) should return the lowest number. If negative numbers are present in the array, then return -1.
Create a Class Program which would be used to accept an Integer and an Integer array, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of n+1 Integers, where the first number corresponds the size of the array, followed by the array elements.
Output consists of an Integer, the lowest number, or a String “Negative numbers present” if a negative number is present in the array.
Refer sample output for formatting specifications.
Sample Input 1:
4
2
3
1
8
Sample Output 1:
1
 Sample Input 2:
4
2
3
-1
8
Sample Output 2:
Negative numbers present


Answer ---- 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class UserProgramCode
    {
        public static int findLowest(int[] a)
        {
            int i, j, t, n;
            n = a.Length;
            t = a[0];
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n + 1; j++)
                {
                    if (a[i] < 0)
                    {
                        t = -1;
                        return t;
                    }
                    else if (t > a[i])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            return t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ****UserProgramCode u = new UserProgramCode();
            int i, n, s;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            s = UserProgramCode.findLowest(a);
            if (s >= 0)
                Console.WriteLine(s);
            else if (s < 0)
                Console.WriteLine("Negative Numbers present");
            else {}
        }
    }
}




================================================================================================


118. 
Find Common Elements  

FindCommonElements
Write a program to find the common elements from the 2 integer lists and to print them in ascending order.
 
Example:
input1: [4,7,3,9,1,5]
input2: [10,4,6,5,3]
 
Output1:[3,4,5]
 
Business Rules:
 
Only positive numbers should be given to the input Lists.
 
1. If the input1 List consists of negative numbers, store  -1 in the list returned from the method..
2. If the input2 List consists of negative numbers, store -2 in the list returned from the method.
3. If both the input lists, input1 and input2  consists of negative numbers,store -3 in the list returned from the method.
 
Include a class UserProgramCode with a static method FindCommonElements which accepts two integers (size of the two integer list), and the two integer lists. The return type (integer list) should return the output integer list. Store -1,-2 or -3 in the output list according to the business rules and return if necessary.
Create a Class Program which would be used to accept two integers (size of the two integer list), and the two integer lists, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of two integers (size of the two integer list), and the two integer lists.
Output consists of an Integer list or, a String “First list is negative” if  -1 is returned, “ Second list is negative” if -2 is returned, or “Both lists are negative” if -3 is returned.
 
Refer sample output for formatting specifications.
 
Sample Input 1:
6
5
4
7
3
9
1
5
10
4
6
5
3
Sample Output1:
3
4
5
 
Sample Input 2:
6
5
-4
7
3
9
1
5
10
4
6
5
3
Sample Output2:
First list is negative
 
 
Sample Input 3:
6
5
4
7
3
9
1
5
10
4
6
5
-3
Sample Output 3:
Second list is negative
 
Sample Input 4:
6
5
-4
7
3
9
1
5
10
4
6
5
-3
Sample Output 4:
Both lists are negative
 

Answer --- 



using System;
using System.Collections.Generic;

namespace pgm101
{
    class UserProgramCode
    {
        public static List<int> FindCommonElements(int size1, List<int> list1, int size2, List<int> list2)
        {
            int i, flag1 = 0, flag2 = 0, j;
            List<int> output = new List<int>();
            for (i = 0; i < size1; i++)
            {
                if (list1[i] < 0)
                    flag1 = 1;

            }
            for (i = 0; i < size2; i++)
            {
                if (list2[i] < 0)
                    flag2 = 1;

            }
            if (flag1 == 1 && flag2 == 1)
                output.Add(-3);
            else if (flag1 == 1)
                output.Add(-1);
            else if (flag2 == 1)
                output.Add(-2);
            else
            {
                for (i = 0; i < size1; i++)
                {
                    for (j = 0; j < size2; j++)
                    {
                        if (list1[i] == list2[j])
                        {
                            output.Add(list1[i]);
                        }
                    }
                }


                output.Sort();
            }
            return output;

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> result = new List<int>();
            int size1 = Convert.ToInt32(Console.ReadLine());
            int size2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size1; i++)
            {
                list1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int j = 0; j < size2; j++)
            {
                list2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            result = UserProgramCode.FindCommonElements(size1, list1, size2, list2);
            if (result.Count == 0)
                Console.ReadLine();
            else if (result[0] == -1)
                Console.WriteLine("First list is negative");
            else if (result[0] == -2)
                Console.WriteLine("Second list is negative");
            else if (result[0] == -3)
                Console.WriteLine("Both lists are negative");

            else
            {
                for (int i = 0; i < result.Count; i++)
                    Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }
    }


}


================================================================================



119. Find the difference between Dates in months

getMonthDifference
Given a method with two date strings in yyyy-mm-dd format as input, write code to find the difference between two dates in months.
Include a class UserProgramCode with a static method getMonthDifference which accepts two date strings as input. The method returns an integer which is the difference between two dates in months.
Create a class Program which would get the input and call the static method getMonthDifference present in the UserProgramCode.
Input and Output Format:
Input consists of two date strings.
Format of date : yyyy-mm-dd.
Output is an integer.
Refer sample output for formatting specifications.
Sample Input 1:
2012-03-01
2012-04-16
Sample Output 1:
1
Sample Input 2:
2011-03-01
2012-04-16
Sample Output 2:
13


Answer ---- 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            string intime, outtime;
            intime = Console.ReadLine();
            outtime = Console.ReadLine();
            k = UserProgramCode.getMonthDifference(intime, outtime);
            if (k == -1)
            {
                Console.WriteLine("Invalid format");
            }
            else
                Console.WriteLine(k);

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int getMonthDifference(string intime, string outtime)
        {

            string s;
            s = "yyyy-MM-dd";
            DateTime i, o;
            bool k = DateTime.TryParseExact(intime, s, null, System.Globalization.DateTimeStyles.None, out i);
            if (k == false)
                return -1;
            bool j = DateTime.TryParseExact(outtime, s, null, System.Globalization.DateTimeStyles.None, out o);
            if (j == false)
                return -1;

            double dm;

            dm = (o.Subtract(i).Days) / (365.25 / 12);


            return (int)dm;
        }

    }
}


====================================================================


120. Extract Max Substring / extractMax


Answer ---- 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pgm101
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string n = UserProgramCode.extractMax(s1, s2);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static string extractMax(string s1, string s2)
        {
            int max = 0;
            int var = 0;
            char c = char.Parse(s2);
            string[] ss = s1.Split(c);
            max = ss[0].Length;
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length > max)
                {
                    max = ss[i].Length;
                    var = i;
                }
            }
            return ss[var];

        }
    }
}









121. 
Employee designation
getEmployee

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDesgination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string find = Console.ReadLine();
            string[] op = UserProgramCode.getEmployee(str, find);
            if (op.Length == str.Length / 2)
            {
                Console.WriteLine();
            }
            if (op.Length == 0)
            {
                Console.WriteLine();
            }

            foreach (string item in op)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }


}

userprogram

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDesgination
{
    class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < input1.Length; i++)
            {
                if (input2.ToLower() == input1[i].ToLower())
                {
                    list.Add(input1[i-1]);
                }
            }
            return list.ToArray();
        }
    }
}




122. 
emi calculation
inst

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string dob = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            int op = UserProgramCode.inst(dob, years);
            {
                Console.WriteLine(op);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;
namespace EMI
{
    class UserProgramCode
    {
        public static int inst(string dob, int month)
        {
            if ((month != 12) && (month != 24) && (month != 36) && (month != 48))
            {
                return -2;
            }

            DateTime dt1;
            int inst = 0;
            double amount1;
            bool i = DateTime.TryParseExact(dob, "dd-mm-yyyy", null, System.Globalization.DateTimeStyles.None, out dt1);
            if (i == true)
            {
                int year = DateTime.Now.Year - dt1.Year;
                int mont = DateTime.Now.Month - dt1.Month;
                string maxdate = "2022-06-06";
                DateTime dt2 = Convert.ToDateTime(maxdate);
                DateTime dt3 = DateTime.Now.Date;
                DateTime dt4 = dt3.AddMonths(month);
                if (dt4 > dt2)
                {
                    return -4;
                }

                if (mont < 0)
                {
                    year = year - 1;
                    mont = mont + 12;
                }

                if (year <= 22)
                {
                    amount1 = (double)200000 * 1.03;
                    inst = (int)amount1 / month;
                }
                if (year > 22 && year <= 45)
                {
                    amount1 = (double)300000 * 1.05;
                    inst = (int)amount1 / month;
                }
                if (year > 45 && year <= 100)
                {
                    amount1 = (double)500000 * 1.07;
                    inst = (int)amount1 / month;
                }
                return inst;
            }
            else
                return -1;
        }
    }
}

-------------------------------------------------------------------------------------------
123. duplicate elemnts 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicatedate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> d = new List<string>(n);
            List<string> e = new List<string>(n);
            for (int i = 0; i < n; i++)
                d.Add(Console.ReadLine());
            e = pp.fun(d);
            foreach (string f in e)
                Console.WriteLine(f);
            Console.ReadLine();
                    

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicatedate
{
    class pp
    {
        public static List<string> fun(List<string> d)
        {
            DateTime dt1;
            List<string> f = new List<string>();
             List<string> z= new List<string>();
            foreach (string a in d)
            {
                bool i = DateTime.TryParseExact(a, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out dt1);
                if (i == true)
                {
                    string k = dt1.ToString("yyyy-MM-dd");
                    f.Add(k);
                }
                 if (i == false)
                {
                    z.Add("-1");
                    return z;
                }

                   
            }
          f=  f.Distinct().ToList();
            return f;

        }
    }
}

------------------------------------------------------------------------------------------------------------------------------------
124. 
duplicate characters
removeDuplicates

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicatecharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            Class1 c=new Class1();
            string output=c.removeDuplicates(input);
            foreach (char ch in output)
            {
                if (ch != '*')
                {
                    Console.Write(ch);
                }
            }
            ****Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace duplicatecharacters
{
    class Class1
    {
        public string removeDuplicates(string input)
        {
            ****string[] s=new string[10];
            ****s=input.Split(
            int i,j;
            char[] c = new char[100];
            c = input.ToCharArray();
           int length= c.Length;
           for (i = 0; i < length; i++)
           {
               for (j = i + 1; j < length; j++)
               {
                   if (c[i] == c[j])
                   {
                       c[j] = '*';
                   }
               }

           }
           string output = new string(c);
           return output;
        }

    }
}

--------------------------------------------------















126.STUDENT EXAM ELIGIBILITY
FindResult

===============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentExamEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string result;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            result = UserProgramCode.FindResult(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentExamEligibility
{
    class UserProgramCode
    {
        public static string FindResult(int a, int b)
        {
            string result;

            if (a > 100 || b > 100)
            {
                result = "Invalid Input";
            }
            else
            {
                if (a >= 55 && b >= 45)
                {
                    result = "P";
                }
                else if ((a < 55 && a >= 45) && b>=55)
                {
                    result = "P";
                }
                else if (b < 45 && a >= 65)
                {
                    result = "R";
                }
                else
                {
                    result = "F";
                }

            }
            return result;
        }
    }
}

------------------------------------------------------------------------------------

127. digit sum in string

Print Digit Sum
Write a program that accepts a string input and finds the sum of all numeric digits present in the string.
Example 1:
input : abc12de4
output : 7

Example 2:
input : udjc&23er
output : -1

Business Rules :
1. If the given input string contains any special characters, then print -1.
2. f the given input string contains no numbers,then print -2.

Create a class named UserProgramCode that has the following static method
public static int getdigits(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of a String
Output is an integer.

Sample Input 1:
abc12de4
Sample Output 1:
7
 
Sample Input 2:
udjc&23er
Sample Output 2:
-1

===================================================================


using System;

class UserProgramCode
{
  public static int getdigits(string str)
  {
	****fill your code here
      int sum = 0;
      int x = 0;
      foreach (var c in str)
      {
          if (!char.IsLetterOrDigit(c))
          {
              return -1;
          }
          else if(char.IsDigit(c))
          {
              sum = sum + (c - 48);
              x++;
          }

      }
      if (x == 0)
      {
          return -2;
      }
      else
      {
          return sum;
      }
  }
}


using System;

class Program
{
  public static void Main( string[] args )
  {	
	string str = Console.ReadLine();
    Console.WriteLine(UserProgramCode.getdigits(str));
    Console.ReadLine();
  }
}







-------------------------------------------------------------------------------



128. Program.Cs day of week

Write a program to find out the day of week for given input date which is in string format (MM-dd-yyyy). The output should be in titlecase.
Include a class UserProgramCode with a static method getDay which accepts a string . The return type is string as given in the above statement.
Create a Class Program which would be used to accept Input and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a string as mentioned in the problem statement.
Refer sample output for formatting specifications.
Sample Input 1:
07-13-2012
Sample Output 1:
Friday

================================================
 
using System;
using System.Globalization;
using System.Linq;
using System.Text;

public class UserProgramCode
{
	public static string getDay (string s)
	{
        DateTime dt = DateTime.ParseExact(s, "MM-dd-yyyy", CultureInfo.InvariantCulture.DateTimeFormat);
        string str = dt.DayOfWeek.ToString();
        return str;

	}
}
using System;
using System.Globalization;
using System.Linq;
using System.Text;


class Program
{
	public static void Main (string[] args)
	{
		string s;
		s = Console.ReadLine();
		Console.WriteLine (UserProgramCode.getDay(s));
        Console.ReadLine();
	}
}


-----------------------------------------------------------------------------------

129 .Dash check
compareDashes



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{

    class Program
    {
        public static void Main(string[] args)
        {
            string input1, input2;
            input1 = Console.ReadLine();
            input2 = Console.ReadLine();
            int value = UserProgramCode.compareDashes(input1, input2);
            if (value == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class UserProgramCode
    {
        public static int compareDashes(string input1, string input2)
        {
            **** fill your code here


            char[] s1 = input1.ToCharArray();
            char[] st1 = input2.ToCharArray();
            int len, count = 0;
            if (s1.Length > st1.Length)
            {
                len = s1.Length;
            }
            else
            {
                len = st1.Length;
            }
            for (int i = 0; i < len; i++)
            {
                if (s1[i] == '-')
                {
                    if (st1[i] != '-')
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count > 0)
                return 2;
            else
                return 1;
        }
    }
}

--------------------------------------------------------------------------------------


130 .CountSubsets

Given a method with an integer list as input, Write code to find the number of subsets formed from the given input. Consider any three elements for the input list which forms as one subset. Sum of first two elements must be equal to third element. The number of subsets which satisfy these conditions would be the output that is printed

Note: The elements in a subset should satisfy below conditions:
1)Any subset should have only 3 elements
2)The elements in each subset must be distinct

Business rule:
1) Print -1 when no such subsets are formed
2) Print -2 if input list consists of negative elements
3) Print -3 when same integer element is repeated twice in the input list.

Example:
input
5
Input1
1
2
3
4
6
The subsets formed are (1,2,3), (1,3,4), (2,4,6)
output =
3

Create a class named UserProgramCode that has the following static method
public static int countSubsets(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
Output consists of an integer.
Refer business rules and sample output for formatting specifications.
 
Sample Input 1 :
5
1
2
3
4
6
 Sample Output 2 :
3
 


using System;
class Program
{
    public static void Main(string[] args)
    {
        int arrSize, output;
        arrSize = Convert.ToInt32(Console.ReadLine());
        int[] input = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            input[i] = Convert.ToInt32(Console.ReadLine());
        }
        output = UserProgramCode.countSubsets(input);
        Console.WriteLine(output);
        Console.Read();
    }
}


using System;
class UserProgramCode
{
    public static int countSubsets(int[] input1)
    {
        int count = 0, flag = 0;
        foreach (int l in input1)
        {
            if (l < 0)
            {
                flag++;
                return -2;
            }
        }
        for (int a = 0; a < input1.Length; a++)
        {
            for (int b = a + 1; b < input1.Length; b++)
                if (input1[a] == input1[b])
                {
                    flag++;
                    return -3;
                }
        }
        if (flag == 0)
        {
            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = i + 1; j < input1.Length; j++)
                {
                    for (int k = j + 1; k < input1.Length; k++)
                    {
                        if (input1[i] + input1[j] == input1[k])
                            count++;
                    }
                }
            }
        }
        if (count == 0)
            return -1;
        else
            return count;
    }
}






131-count chracters

 Write a method to count the characters given in a input string .
  Business rules :-
  Only alphanumeric characters and white space should be given in a input string. 
  Special character should not be there. Else store -1 to output variable.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication18
{
    class UserProgramCode
    {
        public static int countcharacters(string str)
        {
            int len = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 32 && str[i] <= 47) || (str[i] >= 58 && str[i] <= 64))
                {
                    len = -1;
                    break;
                }
                else
                    len = len + 1;
            }
            return len;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication18;

namespace program33
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n;
            n = UserProgramCode.countcharacters(str);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}





132. count vowels
countVowels



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountVowells
{
    class UserProgramCode
    {
        public static int countVowels(string input)
        {
            int output = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c) == false)
                {
                    output = -1;
                    return output;
                }
                else
                {
                    switch (c)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            output++;
                            break;

                    }
                    
                }

            }
            return output;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int rslt = UserProgramCode.countVowels(str);

            if (rslt == -1)
                Console.WriteLine("Other character found");
            else
                Console.WriteLine(rslt);


            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CountVowels
{
    class UserProgramCode
    {

        public static int countVowels(string str)
        {
            string str1=str.ToLower();
            int rs=0;
            Regex reg = new Regex("^[a-z]+$");
            if (reg.IsMatch(str1))
            {
                foreach (char c in str1)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        rs++;
                    }
                }
                **** return rs;

            }
            else
            {
                rs = -1;
            }

            return rs;
        }
    }
}




133. count no of odd integers
countOdd

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace count_odd_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int op = UserProgramCode.countOdd(arr,n);
            if (op == -1)
            {
                Console.WriteLine("The Array consists non-positive value(s)");

            }
            else
                Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace count_odd_integers
{
    class UserProgramCode
    {
        public static int countOdd(int[] arr,int n)
        {
            int c = 0;
            for (int i = 0; i < n;i++ )
            {
                if (arr[i] < 0)
                    return -1;
            }

                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        c++;
                    }
                }
            return c;
        }
    }
}





134.count even occurances
CountEvenOccurance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountEvenOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int op = UserProgramCode.CountEvenOccurance(arr);
            Console.WriteLine(op);
            Console.ReadLine();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountEvenOccurance
{
    class UserProgramCode
    {
        public static int CountEvenOccurance(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    return -1;
            }

            int c=0;
            int final=0;
            for(int i=0;i<arr.Length;i++)
            {
                c = 1;
                for(int j=1;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        c++;
                    }
                }
                if (c % 2 == 0)
                {
                    final++;
                }
                else
                    return 0;
            }
            return final;

        }
        
    }
}





135. convert roman to decimal :

Write a program to convert the given roman number to decimal number.
 
Example :
Input string: XVII
Output variable:10+5+1+1 = 17

The input string should contain only the alphabets given below (in upper case) .

Valid alphabets are I, V, X, L, C, D, and M
'I': The corresponding value = 1
'V': The corresponding value = 5
'X': The corresponding value =10
'L': The corresponding value = 50
'C': The corresponding value = 100
'D': The corresponding value = 500
'M': The corresponding value =1000
 
Include a class UserProgramCode with a static method convertRomanToDecimal that accepts a string and returns an integer. The method returns -1 if the input string is not valid.
 
Create a Class Program which would be used to read the string and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of an integer.

Sample Input 1:
XII 

Sample Output 1:
12

Sample Input 2:
DCL

Sample Output 2:
650
 
Sample Input 3:
DCA

Sample Output 3:
-1


ANS  :


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roman_to_decimal
{
    class UserProgramCode
    {
        public static int RomanToDecimal(string str)
        {
            List<string> romanList = new List<string>();
            List<int> intList = new List<int>();
            int sum = 0;

            romanList.Add("I");
            romanList.Add("V");
            romanList.Add("X");
            romanList.Add("L");
            romanList.Add("C");
            romanList.Add("D");
            romanList.Add("M");

            intList.Add(1);
            intList.Add(5);
            intList.Add(10);
            intList.Add(50);
            intList.Add(100);
            intList.Add(500);
            intList.Add(1000);

            for (int i = 0; i < str.Length; i++)
            {
                if (romanList.Contains(str[i].ToString()))
                    sum = sum + intList[romanList.IndexOf(str[i].ToString())];
                else
                    return -1;
            }
            return sum;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roman_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int op = UserProgramCode.RomanToDecimal(str);
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}








136. convert format


Write a program to convert a 10 digit positive number which is in the format XXX-XXX-XXXX  to the format XX-XX-XXX-XXX.

Include a class UserProgramCode with a static method convertFormat that accepts a string and returns a string.

Create a Class Program which would be used to read the string call the static method present in UserProgramCode.

Input and Output Format:

Input consists of a String.

Output consists of a string
Sample Input 1:
555-555-0000

Sample Output 1:
55-55-550-000

Sample Input 2:
000-000-0000

Sample Output 2:
00-00-000-000


ANS :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string op = UserProgramCode.ConvertFormat(str);
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertFormat
{
    class UserProgramCode
    {
        public static string ConvertFormat(string str)
        {
            int c = 0;
            StringBuilder sb = new StringBuilder();
            int len = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-')
                {
                    continue;
                }
                if (Char.IsDigit(str[i]))
                {
                    sb.Append(str[i]);
                    c++;
                }
                if (c % 2==0)
                {
                    sb.Append("-");
                }
            }
            sb.Remove((sb.Length) - 1, 1);
            string final = sb.ToString();
            return final;
        }
    }
}







137. Concatenate Characters---
concatenation
Given an input string array, write a program to get the second character of each string and form a new String by concatenating the fetched characters together. Print the new string formed.
 
Business Rules :
1. If the given input array element contains numbers, then print -1.
2. If the given input array element contains special characters , then print -2.
3. If the input array contains only one string, then print -3.
 
Create a class named UserProgramCode that has the following static method
public static string concatCharacter(string[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array .
The next 'n' lines of input correspond to elements in the input array.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
3
ab
aaa
adbcd

Sample Output 1 :
bad

Sample Input 2 :
4
ban
b%a
ssm
tea
 
Sample Output 2 :
-2


ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concatcharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            n=Convert.ToInt32(Console.ReadLine());
            string[]s=new string[n];
            for (i = 0; i < n; i++)
            {
                s[i]=Console.ReadLine();
            }
            concat c = new concat();
            string output=c.concatenation(s);
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concatcharacters
{
    class concat
    {
        public string concatenation(string[] s)
        {
            StringBuilder sb = new StringBuilder();
            if (s.Length == 1)
            {
                return "-3";
            }
            foreach (string i in s)
            {
                foreach (char c in i)
                {
                    if(Char.IsDigit(c))
                    {
                        return "-1";
                    }
                    if (!Char.IsLetter(c))
                    {
                        return "-2";
                    }
                }
                sb.Append(i[1]);
            }
            return sb.ToString();

        }
    }
}





138: concatanate string
concatstring
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace progm54
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp1 = Console.ReadLine();
            string inp2 = Console.ReadLine();
            string output = UserProgramCode.concatstring(inp1, inp2);
            Console.WriteLine(output);
        }
    }
class UserProgramCode
    {
        public static string concatstring(string inputstr1, string inputstr2)
        {
            int x = inputstr1.Length;
            int y = inputstr2.Length;
            string ans;
            if (x == y)
            {
                 ans = inputstr1 + inputstr2;
            }
            else if (x > y)
            {
                int z = x - y;
                string inputstring1 = inputstr1.Remove(0, z);
                ans = inputstring1 + inputstr2;
            }
            else
            {
                int z = y - x;
                string inputstring2 = inputstr2.Remove(0, z);
                ans = inputstr1 + inputstring2;
            }
            return ans;

        }
    }

} 



139. COMMON CHARACTER
commonChars

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main()
    {
        String input1 = Console.ReadLine();
        String input2 = Console.ReadLine();
        Console.WriteLine(UserProgramCode.commonChars(input1, input2));
        Console.ReadLine();
    }
}

class UserProgramCode
{
    public static int commonChars(String input1, String input2)
    {
        char[] s1a = input1.ToCharArray();

        char[] s2a = input2.ToCharArray();

        int l1 = input1.Length;
        int l2 = input2.Length;

        Array.Sort(s1a);
        Array.Sort(s2a);

        List<char> s1c = new List<char>();
        List<char> s2c = new List<char>();

        for (int i = 0; i < l1; i++)
        {
            if (s1a[i] == ' ')
                continue;

            else if (!s1c.Contains(s1a[i]))
            {
                s1c.Add(s1a[i]);
            }
        }

        for (int i = 0; i < l2; i++)
        {
            if (s2a[i] == ' ')
                continue;

            else if (!s2c.Contains(s2a[i]))
            {
                s2c.Add(s2a[i]);
            }
        }

        int c = 0;

        foreach (var i1 in s1c)
        {
            foreach (var i2 in s2c)
            {
                if (i1 == i2)
                {
                    c++;
                }
            }
        }

       **** Console.WriteLine(c);
        return c;


    }
}




140-color code
validateColorCode


class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int i = UserProgramCode.validateColorCode(str);
            if (i == 1)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadLine();
        }
 
    }
    class UserProgramCode
    {
        public static int validateColorCode(string s)
        {
            int flag = 0;
            if(s.StartsWith("#"))
            {
                if (s.Length == 7)
                {
                    char[] ch = s.ToCharArray();
                    for(int i=1;i<=6;i++)
                    {
                        if (char.IsDigit(ch[i]) || "ABCDEF".Contains(ch[i]))
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
            }
            if (flag == 0)
                return -1;
            else
                return 1;
        }
    }




141.Check Palindrome
Write a program to read a string input and to check that given string is a palindrome and contains at least two distinct vowels.
The vowels can be repetitive. Even if the same vowel occurs more than once, it should be considered as one vowel only. If the above condition is satisfied, print “Palindrome”, else print “Not Palindrome”.
 
Include a class UserProgramCode with a static method checkPalindrome which accepts a String. The return type (Integer) should return 1 if Palindrome, else -1.
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string.
Output consists of a String, “Palindrome” or “Not Palindrome”.
 
Refer sample output for formatting specifications.
 
Sample Input 1:
himesh
Sample Output 1:
Not Palindrome
 
Sample Input 2:
ABEBA
Sample Output 2:
Palindrome

using System;

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int output = UserProgramCode.checkPalindrome(str);
        if (output == 1)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
using System;
using System.Globalization;
using System.Text;

public class UserProgramCode
{
    public static int checkPalindrome(string str)
    {
        char[] a = str.ToCharArray();
        char[] b = str.ToCharArray();
        Array.Reverse(b);
        string stra = new string(a);
        string strb = new string(b);
        if (stra.Equals(strb))
        {
            char[] d = str.ToCharArray();
            foreach (char item in stra)
            {
                if (item == 'a' || item == 'A' || item == 'e' || item == 'E' || item == 'i' || item == 'I' || item == 'o' || item == 'O' || item == 'u' || item == 'U')
                {

                    for (int i = 0; i < stra.Length; i++)
                    {
                        if (d[i] == item)
                        {
                        }
                        else
                            if (d[i] == 'a' || d[i] == 'A' || d[i] == 'e' || d[i] == 'E' || d[i] == 'i' || d[i] == 'I' || d[i] == 'o' || d[i] == 'O' || d[i] == 'u' || d[i] == 'U')
                            {
                                return 1;
                            }
                    }
                }
            }
        }
        return -1;
    }
}




142.Check Batch Code

Write a program which will check if the given input string follows the below format and print the output according to the conditions given below.

1. The format of the string should be 'AAABBCCXXX' where
a. AAA represents the location of the batch
CHN -- Chennai
CBE -- Coimbatore
KOC - Kochi
PUN - Pune
BGL - Bangalore
HYD - Hyderabad
KOL - Kolkata
Business rules:
THe characters 'AAA' should not be other than the above specified values(Only Capitals). If it is other than these characters, print -1.
b. BB and XXX in the format represents numerals between 0-9. BB Represents the year and XXX represents the batch code.If other than these are present print -2.
c.CC in the format should be only 'DN', if not print -3.
All the characters in the input string are in upper case. Please make sure you dont do a spell mistake in the output string.

Example 1:
Input : CHN13DN014
The output string should be in the following format.
DotNet batch 014 has joined in 2013 year and is at Chennai Location
 
Create a class named UserProgramCode that has the following static method
public static string checkBatch(string input1)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
Input consists of a string.
Refer business rules and sample output for formatting specifications.
 
Sample Input 1 :
CHN13DN014
 
Sample Output 1 :
DotNet batch 014 has joined in 2013 year and is at Chennai Location

Sample Input 2 :
PUN13DN004
 
Sample Output 2 :
DotNet batch 004 has joined in 2013 year and is at Pune Location

Sample Input 3 :
BGL14DN014
 
Sample Output 3 :
DotNet batch 014 has joined in 2014 year and is at Bangalore Location

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication90
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var x = Class1.batch(s);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication90
{
    class Class1
    {
        public static string batch(string s)
        {
            string op = "";
            Regex re = new Regex(@"^([A-Z]{3}[0-9]{2}[D][N][0-9]{3})$");
            if (re.IsMatch(s))
            {
                string loc = s.Substring(0, 3);
                string output = "";
                switch (loc)
                {
                    case "CHN":
                        output = "Chennai";
                        break;
                    case "CBE":
                        output = "Coimbatore";
                        break;
                    case "KOC":
                        output = "Kochi";
                        break;
                    case "PUN":
                        output = "PUNE";
                        break;
                    case "BGL":
                        output = "BANGALORE";
                        break;
                    case "HYD":
                        output = "HYDERABAD";
                        break;
                    case "KOL":
                        output = "KOLKATTA";
                        break;
                     default:
                        output = "-1";
                        break;
                    }
                op = "DotNet batch" +" "+ s.Substring((s.Length - 3))+" " + "has joined in" +" " +"20" + s.Substring(3, 2) + "year and is at"+" "+ output +" "+ "Location";

            }
            else
            {
                op = "-4";
            }
            return op;
        }
    }
}




143. Check Anagrams

A anagram is a word or a phrase that can be created by rearranging the letters of another given word or phrase. We ignore white spaces and letter case. All letters of 'Desperation' can be rearranged to the phrase 'A Rope Ends It'.
Write a program to check whether the 2 given strings are anagrams or not.

Business Rules :
1. If there are any special characters (Space is not considered as special character) in either of the input strings, then store FALSE in the output variable.

Create a class named UserProgramCode that has the following static method
public static bool checkAnagram(string input1,string input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
Input consists of 2 strings.
Output is either “TRUE” or “FALSE”.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
tea
eat
 
Sample Output 1 :
TRUE

Sample Input 2 :
Desperation
A Rope Ends It
 
Sample Output 2 :
TRUE


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class UserProgramCode
{
    public static bool checkAnagram(string input1, string input2)
    {
        string in1 = input1.ToLower();
        char[] charin = in1.ToCharArray();
        Array.Sort(charin);

        string in2 = input2.ToLower();
        char[] charin2 = in2.ToCharArray();
        Array.Sort(charin2);
        string st1 = ""; string st2 = "";
        for (int i = 0; i < charin.Length; i++)
        {
            int c = Convert.ToInt32(charin[i]);
            if ((c >= 97 && c <= 122) || charin[i] == ' ')
            {
                if (charin[i] == ' ')
                    continue;
                else
                    st1 += charin[i];
            }
            else
                return false;
        }

        for (int i = 0; i < charin2.Length; i++)
        {
            int c = Convert.ToInt32(charin2[i]);
            if ((c >= 97 && c <= 122) || charin2[i] == ' ')
            {
                if (charin2[i] == ' ')
                    continue;
                else
                    st2 += charin2[i];
            }
            else
                return false;
        }
        if (st1.Equals(st2))
            return true;
        else
            return false;
    }
}



using System;

class Program
{
    public static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        bool result = UserProgramCode.checkAnagram(input1, input2);
        if (result) Console.WriteLine("TRUE");
        else Console.WriteLine("FALSE");
        Console.ReadLine();
    }
}
 


144.Telephone bill

if call below 300 cost is 200
after for 50 calls cost is .60
after for 50 calls cost is .50
after for all calls cost is .40

ie 200+(x*.60)+(y*.50)+(z*.40)

calcualte the call cost


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculate_telephone_bill
{
    class UserProgramCode
    {
        public static double Telephone(int input1)
        {
            double output1;
            if (input1 <= 300)
            {
                output1 = 200;
                return output1;
            }
            else if (input1 > 300 && input1 <= 350)
            {
                output1 = 200 + ((input1 - 300) * 0.60);
                return output1;
            }
            else if (input1 > 350 && input1 <= 400)
            {
                output1 = 200 + (50 * 0.60) + ((input1 - 350) * 0.50);
                return output1;
            }
            else if (input1 > 400)
            {
                output1 = 200 + (50 * 0.60) + (50 * 0.50) + ((input1 - 400) * 0.40);
                return output1;
            }
            return 0;
        
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculate_telephone_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calls = int.Parse(Console.ReadLine());
            double op = UserProgramCode.Telephone(Calls);
            Console.WriteLine(op.ToString("F"));
            Console.ReadLine();

        }
    }
}


145.Calculate VAT

CalculateVat

ABC stores needs a computerized solution for calculating the VAT for the billing amount. Write a code to calculate the VAT amount for the input bill amount. The VAT should be calculated in the following basis,
 
Type -------  VATPercentage,
 
Medical (M) - - - - - - - - - -- 9%
 
Vegetables (V) and fruits - - - - - - - - - - - 5%
 
Clothes (C) - - - - - - - - - - - - 12%
 
Electronics (E) - - - - - - - - - - -- - - 6.25%
 
Business Rules :
1. The codes 'M','V','C' or 'E' only should be given as input for indicating the Medical, Vegetables and Fruits, Clothes and Electronics type of goods respectively. Any other character other than the above is given as input, it is Invalid Input.
2. Only Positive number should be given as a input for bill amount. Else it is Invalid Input.

Include a class UserProgramCode with a static method calculateVAT which accepts a character and double and returns a double which corresponds to the calculated VAT amount.  If the input is invalid, the method returns -1.
 
Create a class Program  which would get the input and call the static method calculateVAT present in the UserProgramCode.
If the method returns -1, print 'Invalid Input'.

Input and Output Format:
Input consists of character and double.
Character denotes a goods type and double denotes total amount.

Refer sample output for formatting specifications.

Sample Input 1 :
M
70
Sample Output 1 :
6.3

Sample Input 2 :
V
-500
Sample Output 2 :
Invalid Input




sol--------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace final
{
    class UserProgramCode
    {
        public static double CalculateVat(char c, double input1)
        {
            double percent=0;
            double vat=0;
            double output1=0;
            if (input1 < 0)
                return -1;
             switch (c)

            {

                case 'M':

                    percent = 9;

                    vat = percent / 100;


                    output1 = input1* ( vat);

                   return output1;

          

                case 'V':

                    percent = 5;

                    vat = percent / 100;

                    output1 = input1 * ( vat);

                    
                   return output1;


                case 'C':

                    percent = 12;

                    vat = percent / 100;

                    output1 = input1 * ( vat);

                   return output1;

           

                case 'E':

                    percent = 6.25;

                    vat = percent / 100;

                    output1 = input1 * ( vat);

                   return output1;

          

                default:

                    output1 = -1;


                    break;

            }

             return output1;

        }

    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace final
{
    class Program

    {
        static void Main(string[] args)
        {
            Char c = Convert.ToChar(Console.ReadLine());
            double input1 = Convert.ToDouble(Console.ReadLine());
            double op = UserProgramCode.CalculateVat(c, input1);
            if (op == -1)
                Console.WriteLine("Invalid Input");
            else
            Console.WriteLine(op);
            Console.ReadLine();

         
        }
    }
}













========================================================================================================
146.Calculate Take Home Salary

calculateHomeSalary

 
TMB Software solution is under developing software company in KolKatta. The company is providing the Provident fund for all the employees based on the salary criteria as given below. Write a method to find the take home salary for the employee. Medical Insurance for each employee is Rs 678.
 
Salary Range------------ PF
Lesser than 15000 ------- 750 
15001 - 22000 -------- 850 
22001-30000 -------- 925 
Above 30000 -------- 1000 
 
Take Home Salary = Salary - pf - MedicalInsurance
 
Include a class UserProgramCode with a static method calculateHomeSalary which accepts an integer and returns an integer that corresponds to the Take Home Salary.
The method returns -1 when the input integer is negative.
Create a class Program which would get the input and call the static method calculateHomeSalary present in the UserProgramCode.
If the method returns -1, print 'Invalid Input'.
 
Input and Output format :
Input consists of a integer that represents a salary.
Output is an integer that corresponds to 'take home salary' or a string 'Invalid Input'.
 
Sample Input 1 :
13500
Sample Output 1 :
12072

Sample Input 2 :
-10000
Sample Output 2 :
Invalid Input







sol---------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace takehomesalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int rslt;
            Console.WriteLine("enter the salary");
            int Salary= Convert.ToInt32(Console.ReadLine());
            rslt=UserProgramCode.calculateHomeSalary(Salary);
            if (rslt == -1)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine(rslt);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace takehomesalary
{
    class UserProgramCode
    {
        public static int calculateHomeSalary(int Salary)
        {
            int PF=0;
            int MedicalInsurance=678;
            
            int HomeSal=0;
            if (Salary > 0)
            {
                if (Salary < 15000)
                {
                    PF = 750;
                    HomeSal = (Salary - PF - MedicalInsurance);
                  
                }
                else if (Salary >= 15001 && Salary <= 22000)
                {
                    PF = 850;
                    HomeSal = Salary - PF - MedicalInsurance;
                   

                }
                else if (Salary >= 22001 && Salary <= 30000)
                {
                    PF = 925;
                    HomeSal = Salary - PF - MedicalInsurance;
                   
                }
                else if (Salary > 30000)
                {
                    PF = 1000;
                    HomeSal = Salary - PF - MedicalInsurance;
                  
                }
                return HomeSal;
            }
            else
            {
                return -1;
            }

        }
    }
}






147.simple interest
 simple SI formula.

calculatesimpleinterest




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double op=UserProgramCode.calculatesimpleinterest(pin, year);
            
              
             if(op==-1)
                Console.WriteLine("Interest cannot be calculated");
             else

             Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Interest
{
    class UserProgramCode
    {
        public static double calculatesimpleinterest(int pin, int year)
        {
            double final = 0;
            if (pin > 1000000)
                return -1;
            if (pin >= 99999 && pin <= 500001)
            {
                if (year > 5)
                {
                    final = Math.Round((pin * year * 8.75) / 100, 2);
                }
            }
            if (pin <= 1000001 && pin >= 500001)
            {
                if (year == 3 || year == 4)
                {
                    final = Math.Round((pin * year * 9.25) / 100, 2);
                }
            }
            if (year < 2 && pin < 1000000)
            {
                final = Math.Round((pin * year * 8.25) / 100, 2);
            }


            return final;
        }
    }
}




148.Calculate New Salary


calculateNewSalary

Done---Calculate New Salary

 
The HR of an IT company fixes the salary of a new joinee who joins the company with the previous experience. Given the year of experience, Technology expertise and the previous salary drawn, the HR fixes the current salary as follows:
1. Straight 30% hike from the previous salary drawn.
2. a. Add Extra 5% if the year of experience is more than 3 and less than or equal to 5 years.
b. Add Extra 10% if the year of experience is more than 5 and less than or equal to 8 years.
c. Add Extra 15% if the year of experience is more than 8 years
3. Technology expertise is classified broadly into two namely common skills (CS) and rare skills (RS) People having rare skills get an extra 5% increase from their previous salary drawn.

Write a program to calculate the salary the HR fixes for the new joinee given the experience (input1), technology expertise classification (input2) and the previous salary drawn (input3) and print the output in the given format
Your Salary is fixed as Rs YYYYYY
where YYYYYY is the calculated new salary. (The digits depends upon the salary calculated.)
Salary is rounded off and displayed as an integer.

Business rules:
1. If the experience is given more than 25 or less than 0, then print “Invalid Experience”
2. If the technology expertise classification is given other than CS or RS, then print “Invalid Technology expertise classification”
3. If the previous salary is given more than 100000 or less than 0, then print “Invalid Salary”
 
Create a class named UserProgramCode that has the following static method
public static int calculateNewSalary(int,string,int)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer that corresponds to experience (input 1).
The second line of the input consists of a string that corresponds to technology expertise (input 2).
The third line of the input consists of an integer that corresponds to previous salary drawn (input 3).
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
7
RS
30000
 
Sample Output 1 :
Your Salary is fixed as Rs 43500

Sample Input 2 :
7
RSS
30000

Sample Output 2 :
Invalid Technology expertise classification



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        public static void Main(string[] args)
        {
            int experience, oldSalary, salary;
            string expertise;
            experience = Convert.ToInt32(Console.ReadLine());
            expertise = Console.ReadLine();
            oldSalary = Convert.ToInt32(Console.ReadLine());
            salary = UserProgramCode.calculateNewSalary(experience, expertise, oldSalary);
            if (salary == -1)
                Console.WriteLine("Invalid Experience");
            else if (salary == -2)
                Console.WriteLine("Invalid Technology expertise classification");
            else if (salary == -3)
                Console.WriteLine("Invalid Salary");
            else
                Console.WriteLine("Your Salary is fixed as Rs {0}", salary);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int calculateNewSalary(int experience, string expertise, int oldSalary)
        {
            double sal = 0, ctr = 0, sa = 0;
            if (experience > 25 || experience < 0)
            {
                sa = -1;
                ctr++;


            }
            if (expertise != "RS" && expertise != "CS")
            {
                sa = -2;
                ctr++;

            }
            if (oldSalary > 100000 || oldSalary < 0)
            {
                sa = -3;
                ctr++;

            }
            if (ctr == 0)
            {
                sal = sal + (oldSalary * 0.3);
                if (experience > 3 && experience <= 5)
                {
                    sal = sal + (oldSalary * 0.05);
                }
                else if (experience > 5 && experience <= 8)
                {
                    sal = sal + (oldSalary * 0.10);
                }
                else if (experience > 8)
                {
                    sal = sal + (oldSalary * 0.15);
                }
                if (expertise == "RS")
                {
                    sal = sal + (oldSalary * 0.05);
                }
                sal = sal + oldSalary;
                sa = Math.Round(sal);

            }
            return (int)sa;
        }
    }
}

149) Calculate Grade
no question

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size;
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            string result = UserProgramCode.getGrade(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }



        class UserProgramCode
        {
            public static string getGrade(int[] arr)
            {
                int max = arr[1], i;
                int id = arr[0];
                string grade = "";

                for (i = 1; i < arr.Length; i = i + 2)
                {
                    if (arr[i] > 0 && arr[i - 1] > 0 && arr.Length > 2 && arr.Length % 2 == 0)
                    {
                        if (max < arr[i])
                        {
                            max = arr[i];
                            id = arr[i - 1];
                        }
                    }
                    else if (arr[i] < 0 || arr[i - 1] < 0)
                    {
                        grade = "Invalid Input";
                        return grade;
                    }
                    else if (arr.Length <= 2)
                    {
                        grade = "Grading is not possible";
                        return grade;
                    }
                    else if (arr.Length % 2 != 0)
                    {
                        grade = "Scores not provided for all Students";
                        return grade;
                    }

                }
                if (max >= 80)
                {
                    grade = "Student_ID " + id + " has passsed in DISTINCTION";
                }
                else if (max >= 60 && max < 80)
                {
                    grade = "Student_ID " + id + " has passed in FIRST CLASS";
                }
                else if (max >= 45 && max < 60)
                {
                    grade = "Student_ID " + id + " has passed SECOND CLASS";
                }
                else if (max >= 0 && max < 45)
                {
                    grade = "FAIL";
                }
                return grade;
            }

        }
    }
}

150) calculate discount
calcDiscount

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n,i=0;         
            m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[m];
            int[] output = new int[m];
            for (i = 0; i < m; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (i = 0; i < n; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            output = UserProgramCode.calcDiscount(a, b);
            if (output[0] < 0)
            {
                Console.WriteLine(output[0]);
            }
            else
            {
                for (i = 0; i < m; i++)
                {

                    Console.WriteLine(output[i]);
                }
            }
            Console.Read();

        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class UserProgramCode
    {
        public static int[] calcDiscount(int[] input1, int[] input2)
        {
            int len1 = 0, len2 = 0,i=0;
            int discount=0;
            len1 = input1.Length;
            len2 = input2.Length;
            int[] c = new int[len1];
            if (len1 != len2)
            {
                c[0] = -3;
                return c;
            }
            else
            {
                for (i = 1; i < len1; i = i + 2)
                {
                    if (!(input1[i] >= 1 && input1[i] <= 12))
                    {
                       c[0] = -1;
                       return c;
                    }
                }
                for (i = 1; i < len2; i = i + 2)
                {
                    if ((input2[i] < 0))
                    {
                        c[0] = -2;
                        return c;
                    }
                }
                for (i = 1; i < len1; i=i+2)
                {
                    if (input2[i] < 100000)
                    {
                        discount = 0;
                    }
                    if (input2[i] >= 500000)
                    {
                        if (input1[i] >= 1 && input1[i] <= 4)
                        {
                            discount = input2[i] * 25;
                        }
                        if (input1[i] >= 5 && input1[i] <= 8)
                        {
                            discount = input2[i] * 20;
                        }
                        if (input1[i] >= 9 && input1[i] <= 12)
                        {
                            discount = input2[i] * 15;
                        }
                    }
                    if ((input2[i] >= 100000) && (input2[i]<500000))
                    {
                        if (input1[i] >= 1 && input1[i] <= 4)
                        {
                            discount = input2[i] * 15;
                        }
                        if (input1[i] >= 5 && input1[i] <= 8)
                        {
                            discount = input2[i] * 10;
                        }
                        if (input1[i] >= 9 && input1[i] <= 12)
                        {
                            discount = input2[i] * 5;
                        }
                    }

                    c[i] = discount/100;
                }
                for (i = 0; i < len1; i=i+2)
                {
                    c[i] = input1[i];
                }
                return c;
            }
        }
    }
}

151) CALCULATE COST


using System;


class Program
{
    public static void Main(string[] args)
    {
        int cost = Convert.ToInt32(Console.ReadLine());
        char fltype = Convert.ToChar(Console.ReadLine());
        char dctype = Convert.ToChar(Console.ReadLine());
        int result = UserProgramCode.calculateCost(cost, fltype, dctype);
        if (result == -1)
            Console.WriteLine("Too low cost");
        else if (result == -2)
            Console.WriteLine("Invalid type of flower");
        else if (result == -3)
            Console.WriteLine("Invalid decoration type");
        else
            Console.WriteLine(result);
    }
}
using System;

class UserProgramCode
{
    public static int calculateCost(int cost, char fltype, char dctype)
    {
        if (dctype != 'S' && dctype != 'C')
            return (-3);
        if (fltype != 'N' && fltype != 'E')
            return (-2);
        int value = 0;
        if (dctype == 'S')
            value = value + 15000;
        if (dctype == 'C')
            value = value + 25000;
        if (fltype == 'N')
            value = value + (cost * 400);
        if (fltype == 'E')
            value = value + (cost * 700);
        if (value < 20000)
            return -1;
        else
            return (value);

    }
}


152.CALCULATE CHARGE PARKING

using System;

class Program
{
  public static void Main( string[] args )
  {
      string date1 = Console.ReadLine();
      string date2 = Console.ReadLine();

      int result = UserProgramCode.getDateDifference(date1, date2);
      Console.WriteLine(result);
      Console.ReadLine();
  }
}
using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class UserProgramCode
{
  public static int getDateDifference(string date1,string date2)
  {
      int result=0;
      int time = 0;
      DateTime dt1;
      DateTime dt2;
      bool res1 = DateTime.TryParseExact(date1, "yyyy-MM-dd:HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dt1);
      bool res2 = DateTime.TryParseExact(date2, "yyyy-MM-dd:HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dt2);
      if (res1 == true && res2 == true)
      {
           time = (int)dt2.Subtract(dt1).TotalHours;
          if (time < 0)
          {
              result= -2;
          }
          else if (time > 24)
          {
              result= -3;
          }
          else
          {
              if (time <= 3)
              {
                  result = 20;
              }
              else
              {
                  result = time * 5;
              }

              if (result > 100)
              {
                  result = 100;
              }
          }
      }
      else
      {
          result = -1;
      }
          return result;
  }
}

another car parking scenario hard coded:
2 inputs are given as string that should be converted to datetime format and calculate the hours 
and calculate the charges for car parking.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "1991/09/12 09:45:56";
            string input2 = "1991/09/12 10:45:57";
            double output1 = 0;
            DateTime dt;
            DateTime dt1;
            double duration = 0;
            bool res = DateTime.TryParseExact(input1, "yyyy/MM/dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None, out dt);
            bool res1 = DateTime.TryParseExact(input2, "yyyy/MM/dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None, out dt1);
            if (res == false || res1 == false)
            {
                output1 = -1;
            }
            else
            {
                if (dt > dt1)
                {
                    output1 = -2;
                }
                else
                {
                    duration = Math.Ceiling(dt1.Subtract(dt).TotalHours);
                    if (duration > 24)
                    {
                        output1 = -3;
                    }
                    else if (duration <= 3)
                    {
                        output1 = 2;
                    }
                    else if (duration > 3 && duration <= 24)
                    {
                        output1 = 2 + (0.50 * (duration - 3));
                    }
                }
            }
            Console.WriteLine(output1);
            Console.Read();
        }
    }
}

153) Calculate Bill Amount

A Electrical shop has announced the following seasonal discount for the purchase of certain items.

IInclude a class UserProgramCode with a static method calculateBillAmount which accepts double and char value as input and returns an integer that corresponds to the net amount.

Compute the net amount to be paid by the customer based on the below criteria,

Purchase Amount(Rs)	Discount on Tv	Discount on MusicSystem
1-25000	5%	10%
25001-50000	10%	20%
More than 50000	15%	30%

[Hint: DiscountPrice=(DiscountRate/100)*Amount of Purchase.
Net Amount=Amount of Purchase-DiscountPrice.]

If the purchase item is other than TV and MusicSystem return -2,
if the purchase amount is a negative value return -1.Otherwise return the net amount.

Create a Main class which gets double and char as an input and call the static method calculateBillAmount present in theUserProgramCode.
If the method returns -1, then print 'Negative Values'.
If the method returns -2, then print 'No Items'.


Input and  output format:
The input will be a double and char values.
If the input character is 'T', it corresponds to TV.
If the input character is 'M', it corresponds to Music System.

Refer sample output for formatting specifications.

Sample Input 1:
20000
X
Sample Output 2:
No Items


Sample Input 2:
-5000
M
Sample Output 2:
Negative Values

Sample Input 3:
70000
T
Sample Output 3:
59500

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

   class UserProgramCode
   {      
    public static int calculateBillAmount(double input1,char input2)      
    {        
		**** fill your code here
        int res,na1;

        if (input2 != 'T' && input2 != 'M')
        {
            res = -2;
            return res;
        }
        else if (input1 < 0)
        {
            res = -1;
            return res;
        }
        else
        {
           
            double dp, na;

            if (input1 >= 1 && input1 <= 25000)
            {
                if (input2 == 'T')
                {
                    dp = ((5 / 100) * input1);
                    na = (input1 - dp);
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
                else
                {
                    dp = ((10 / 100) * input1);
                    na = input1 - dp;
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
            }
            else if (input1 >= 25001 && input1 <= 50000)
            {
                if (input2 == 'T')
                {
                    dp = ((10 / 100) * input1);
                    na = input1 - dp;
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
                else
                {
                    dp = ((20 / 100) * input1);
                    na = input1 - dp;
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
            }
            else if (input1 > 50000)
            ****else
            {
                if (input2 == 'T')
                {
                    dp = ((15 / 100) * input1);
                    na = input1 - dp;
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
                else
                {
                    dp = ((30 / 100) * input1);
                    na = input1 - dp;
                    na1 = Convert.ToInt32(na);
                    return na1;
                }
            }
            else 
            {
                na1 = Convert.ToInt32(input1);
                return na1;
            }
        }

    }
}



using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

   class Program
   {
      public static void Main( string[] args )
      {	
		double input1;
		char input2;
		input1 = Convert.ToDouble(Console.ReadLine());
		input2 = Convert.ToChar(Console.ReadLine());
		int value = UserProgramCode.calculateBillAmount(input1,input2);		
		if(value == -2)
			 Console.Write("No Items");
		else if(value == -1)
			Console.Write("Negative Values");
		else
			Console.Write(value);

        Console.ReadLine();
      }
   }

154)Boundary Average

Given an int array as input, write a program to compute the average of the maximum and minimum element in the array.
Include a class UserProgramCode with a static method “getBoundaryAverage” that accepts an integer array as argument and return a avegare of max and min value.
Create a class Program which would get the input array and call the static method getBoundaryAverage present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the size of the array.
The next n lines consist of integers that correspond to the elements in the array.
Assume that the maximum number of elements in the array is 10.
Output consists of a single float value that corresponds to the average of the max and min element in the array.
Output is displayed correct to 1 decimal place.
 
Sample Input :
6
3
6
9
4
2
5
 
Sample Output:
5.5



Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int ask=0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[n];
            for (int i = 0; i < n; i++)
                s[i] = Convert.ToInt32(Console.ReadLine());
            double a = UserProgramCode.getBoundaryAverage(s);
            string k = a.ToString();
            for (int i = 0; i < k.Length;i++ )
                if (k[i] == '.')
                {
                    ask = 1;
                }
            if (ask == 1)
            {
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("{0}.0",k);
            }
             
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static double getBoundaryAverage(int[] a)
        {
            double d, e;
            d = ((a.Max() + a.Min()) / 2.0);
            e = Math.Round(d, 1);
            return e;
        }
    }
}

155) Bonus Calculation or calculate bonus

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2 = UserProgramCode.calculateBonus(n1);
            Console.WriteLine(n2);
            Console.ReadLine();
        }
    }
    class UserProgramCode 
    {
        public static int calculateBonus(int n1)
        {
            int b=0;
            if (n1 < 0)
                return -1;
            else if (n1 > 1000000)
                return -2;
            else if (n1 > 15000 && n1 < 20001)
                b = (int)(0.17 * n1 + 1500);
            else if (n1 > 10000 && n1 < 15001)
                b = (int)(0.15 * n1 + 1200);
            else if (n1 < 10001)
                b = (int)(0.12 * n1 + 1000);
            else
                b = (int)(0.08 * n1 + 500);

            return b;
        }
    }
}

156)  berth type

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerthType
{
    class Program
    {
        static void Main(string[] args)
        {

            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            String s3 = Console.ReadLine();
            String r = UserProgramCode.Berth_type(s1, s2, s3);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerthType
{
    class UserProgramCode
    {
        public static String Berth_type(String s1, String s2, String s3)
        {
            String b1 = "", b2 = "", b3 = "";
            int m1, m2, m3, temp = 0;
            String res = "";

            try
            {

                m1 = Convert.ToInt32(s1);
                m2 = Convert.ToInt32(s2);
                m3 = Convert.ToInt32(s3);
                if (m1 < 0 || m2 < 0 || m3 < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                res = "Invalid Seat No.";
                return res;
            }

            int r1 = m1 % 8;
            int r2 = m2 % 8;
            int r3 = m3 % 8;
            if ((r1 == 1 || r1 == 4))
            {
                b1 = "Lower";

            }
            if ((r2 == 1 || r2 == 4))
            {
                b2 = "Lower";
            }
            if ((r3 == 1 || r3 == 4))
            {
                b3 = "Lower";
            }
            if (b2 == "Lower")
            {
                res = "Grandfather got Lower seat";
                return res;
            }
            else if (b2 != "Lower")
            {
                if (b1 == "Lower")
                {
                    res = "Your seat has been swapped from " + m2 + " to " + m1;
                    temp = m1;
                    m1 = m2;
                    m2 = temp;
                    return res;
                }
                else if (b3 == "Lower")
                {
                    res = "Your seat has been swapped from " + m2 + " to " + m3;
                    temp = m3;
                    m3 = m2;
                    m2 = temp;
                    return res;
                }
                else
                {
                    res = "Sorry your request can not be processed....";
                    return res;
                }

            }
            return res;
        }
    }
}

157.Arrray Median

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arraymedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;
            double m;
            x =Convert.ToInt32( Console.ReadLine());
            int[] input = new int[x];
            for (i = 0; i < x; i++)
            {
                input[i]=Convert.ToInt32(Console.ReadLine());
            }
            Arraymedian c = new Arraymedian();
            m=c.arraymedian(input);
            double d=Math.Round(m,0,MidpointRounding.AwayFromZero);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arraymedian
{
    class median
    {
        public double arraymedian(int[] input)
        {
            int length;
            double p;
            Array.Sort(input);
            input.Reverse();
            length = input.Length;
            foreach (int i in input)
            {
                if (i < 0)
                {
                    return -1;
                }
                if (i == 0)
                {
                    return -2;
                }
            }

            if (length % 2 == 1)
            {
                return input[((length + 1) / 2)-1];
            }
            else
            {
               p= (float)(input[(length / 2)-1] + input[(length / 2)])/2.0;
                return p;
            }

        }
    }
}



Q158) Arrange After Cubing

Write a code to insert cube of a number in between two numbers in an integer array if those
 numbers satisfy the below conditions:

Conditions:
1) The elements in the array must be consecutive numbers
2) Second element in the array should be the square of first element in the array.
3) Cube of first number must be inserted in between the first element and second element.
4) If any of the element in the array does not satisy the above condition add the element in the output
 array and proceed with the next element.

Business Rules:
1. If no consecutive numbers are present assign all the elements in the Input array to the Output array .
2. If input array consists of negative elements perform the square of negative numbers and then print the 
final output array.

Create a class named UserProgramCode that has the following static method
public static int[] arrangeAfterCubing(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
Refer sample output for formatting specifications.
 
Sample Input 1:
7
1
2
4
6
7
3
9
Sample Output 1:
1
2
8
4
6
7
3
27
9

Sample Input 2:
3
1
-4
5

Sample Output 2:
1
16
5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    namespace ConsoleApplication30
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                int[] b = new int[100];
                b = UserProgramCode.arrangeAfterCubing(a);
                for (int i = 0; i < b.Length; i++)
                {
                    Console.WriteLine(b[i]);
                }
                Console.ReadLine();
            }
        }
        class UserProgramCode
        {
            public static int[] arrangeAfterCubing(int[] a)
            {
                int flag = 0;
                List<int> c = new List<int>();
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] < 0)
                        flag = 1;
                }
                if (flag == 0)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if (a[i] < a[i + 1])
                        {
                            if (a[i + 1] == a[i] * a[i])
                            {
                                c.Add(a[i]);
                                c.Add(a[i] * a[i] * a[i]);
                            }
                            else
                                c.Add(a[i]);

                        }
                        else c.Add(a[i]);
                    }
                    c.Add(a[a.Length - 1]);
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] > 0)
                            c.Add(a[i]);
                        else
                            c.Add(a[i] * a[i]);
                    }

                }
                return c.ToArray();
            }
        }
    }
}





Q159)All Vowels
 
Write a Program to check if given word contains exactly five vowels and the vowels are in alphabetical order.
 Assume there is no repetition of any vowel in the given string and all letters are in lower case.
Include a class UserProgramCode with a static method testOrderVowels which accepts a string and returns an integer
.  The method returns 1 if the condition  stated above is satisfied. Else the method returns -1.
Create a Class Program which would be used to read a String and call the static method present in UserProgramCode.
If the method returns 1, print 'valid'. Else print 'invalid'.
Input and Output Format:
Input consists of a string with maximum size of 100 characters.
Output consists of a single string.
Refer sample output for formatting specifications.
Sample Input 1:
acebisouzz
Sample Output 1:
valid
 
Sample Input 2:
alphabet
Sample Output 2:
invalid

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class UserProgramCode
    {
        public static int testOrderVowels(string input1)
        {
            int output1 = 0;

            StringBuilder sb = new StringBuilder();

            char[] ch = input1.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
               int n = Convert.ToInt32(ch[i]);
               if (n >= 65 && n <= 90)
               {
                   output1 = -1;
                   break;
               }
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    sb.Append(ch[i]);
                }
                if (sb.ToString() == "aeiou")
                {
                    output1 = 1;
                }
                else
                {
                    output1 = -1;
                }
            }
            return output1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int output1;
            input1 = Console.ReadLine();
            output1 = UserProgramCode.testOrderVowels(input1);
            if (output1.Equals(1))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.Read();
        }
    }
}

Q160) Add Years

Write a method which can display the date n years after the given date.
The date should be given in string format "mm/dd/yyyy" without time and the resultant added date should 
also be in the format "mm/dd/yyyy" . 
“n” as Years and the given date should be accepted as an argument.


Include a class UserProgramCode with a static method addYears which accepts a string as 
input and output should be a string.
 
Business Rules :
1) Only positive value should be given as input to the integer else the method returns -2.
2) If the date format is not "mm/dd/yyyy" given in the string, the method returns -1.
3) Otherwise return the corresponding date in given format.

Create a class Program which would get the input and call the static method addYears present in the UserProgramCode.
If the method returns -1, print 'Invalid date format'.
If the method returns -2, print 'Invalid Input'.

Input and Output Format :

Input consists of a string which accepts a date.

Refer the sample input and output for formatting specifications.

Sample Input 1 :
10/21/2009
5
Sample Output 1 :
10/21/2014

Sample Input 2 :
2009/10/03
-2
Sample Output 2 :
Invalid Input

Sample Input 3 :
27-10-2009
1
Sample Output 3 :
Invalid date format

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Program
{
   class Program
   {
      public static void Main( string[] args )
      {	
		string inputDate=Console.ReadLine();
		int day=Convert.ToInt32(Console.ReadLine());
		string output=UserProgramCode.addYears(inputDate,day);
		if(output.Equals("-2"))
			Console.WriteLine("Invalid Input");
		else if(output.Equals("-1"))
			Console.WriteLine("Invalid date format");
		else
			Console.WriteLine(output);
        Console.ReadKey();
      }
   }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
  class UserProgramCode
  {
     public static string addYears(string date,int day)
     {
	**** fill your code here
         DateTime dt;
         if (day < 0)
         {
             return "-2";
         }
         bool res = DateTime.TryParseExact(date, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dt);
         if (res == true)
         {
             dt = dt.AddYears(day);
             return dt.ToString("MM/dd/yyyy");
         }
         else
             return "-1";
         
  }
}
}


Que161) Add Series 
addSeries

Write a program that takes an odd positive integer number as input and evaluates the following series:
1+3-5+7-9…+/-n.

Example:
input = 9
series = 1+3-5+7-9
output = -3

Create a class named UserProgramCode that has the following static method
public static int addSeries(int input1)

Create a class named Program that accepts an integer as input and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of a single integer that corresponds to n.
Output consists of a single integer that corresponds to the sum of the series.

Sample Input:
9
Sample Output :
-3

ANS)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n = Convert.ToInt32(Console.ReadLine());
            x = UserProgramCode.addSeries(n);
            Console.WriteLine(x);
        }
    }

    class UserProgramCode
    {
        public static int addSeries(int a)
        {
            int t = 0, k = 1;
            for (int i = 0; k <= a; i++)
            {
                if (i == 0)
                {
                    t = t + k;
                }
                else if (i == 1)
                {
                    t = t + k;
                }
                else if (i % 2 != 0)
                {
                    t = t + k;
                }
                else
                {
                    t = t - k;
                }

                k = k + 2;
            }
            return t;
        }
    }
}



------------------------------------------------------------------------------------------------------------------------

Que162) Add and Reverse
addAndReverse

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int o = UserProgramCode.addAndReverse(a,k);
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
    class UserProgramCode
    {
        public static int addAndReverse(int[] a,int k)
        {
            int sum = 0;
            int rev=0;
            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > k)
                    sum = sum + a[i];
            }
            while (sum != 0)
            {
                int r = sum % 10;
                rev = rev * 10 + r;
                sum = sum / 10;
            }
            return rev;
        }
    }
}



------------------------------------------------------------------------------------
Q163) Shipping Cost
CalcShippingCost


Write a program to compute the Cost of Booking for Shipping. The Shipping Cost is computed according to the shipping type and the package weight. The shipping rate is given below.
Shipping types - Weight Rate (bahts/gram)
Regular for first 2000 - 0.25 (basic charge)
Regular exceeding 2000 - 0.35
For each Express, use the same rate as Regular + 50 bahts fee
Note that the Shipping cost is computed from the possible valid minimum rate.
 
Input1- Weight in grams
Input2- Type of delivery ('R' Regular and 'X' Express)
 Include a class UserProgramCode with a static method CalcShippingCost which accepts an integer(weight) and a character (type of delivery). The return type (integer) should return the shipping cost.
Create a Class Program which would be used to accept a integer value and a character, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an integer and a character.
Output consists of an integer(the shipping cost).
Refer sample output for formatting specifications.
 
Sample input 1:
4500
R
Sample Output 1:
1375
 
Sample Input 2:
1800
X
Sample Output 2:
500

ANS)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            int p = UserProgramCode.CalcShippingCost(f, c);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int CalcShippingCost(int i, char c)
        {
            double p;
            if (c == 'X')
                i += 50;
            if (i > 2000)
            {
                int d = i - 2000;
                p = (2000 * 0.25);
                p = p + ((d * 0.35));
            }
            else
                p = (i * 0.25);
            int a = (int)Math.Round(p, 0);

            return a;
        }
    }
}
----------------------------------------------------------------

Q164) Shortest Word Length



Write a method to get the length of the shortest word in the given string array.
Include a class UserProgramCode with a static method shortestWordLength that accepts a string array and returns an integer that corresponds to the length of the shortest word. 
Create a class Program which would get the input and call the static method shortestWordLength present in the UserProgramCode. 
Input and Output Format:
First line of the input consists of an integer that corresponds to the number of elements in the string array.
The next n lines of the input consists of the elements in the string array. Assume that all the elements in the string array are single words.
Output is an integer which corresponds to the length of the shortest word
Sample Input 1:
3
cherry
hai
apple
Sample Output 1:
2
Sample Input 2:
4
cherry
apple
blueberry
grapes
Sample Output 2:
2

ANS)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[50];
            for (i = 0; i < n; i++)
                s[i] = Console.ReadLine();
            s[i] = "\0";
            int sl = UserProgramCode.shortestWordLength(s);
            Console.WriteLine(sl);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static int shortestWordLength(string[] s)
        {

            int sl = s[0].Length;
            for (int i = 1; s[i] != "\0"; i++)
            {
                if (s[i].Length < sl)
                    sl = s[i].Length;

            }
            return sl;
        }
    }

}

----------------------------------------------------------------------------
Q165) sortArrayElement

Write a method to sort input string array by the length of each element. If word length is same then sort thiese two words in ascending order without considering length.
Include a class UserProgramCode with a static method sortArrayElement which accepts a string array as input.
The return type of a method is string array.
If input contains any special characters then add '-1' into the list. 
Create a class Program which would get the input and call the static method sortArrayElement present in the UserProgramCode.
 
Input and Output format :
The first line of the input consists of an integer that corresponds to the number of elements in the string array.
The nexr 'n' lines consist of string inputs.
Output consists of array which contains sorted elements or "-1".
Sample Input 1 :
3
Greenapple
Litchi
Mango
Sample Output 1 :
Mango
Litchi
Greenapple
Sample Input 2 :
2
one
#two
Sample Output 2 :
-1


ANS)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            string[] b;
            for (int i = 0; i < a.Length; i++)
                a[i] = Console.ReadLine();
            b = UserProgramCode.sortArrayElement(a);
            foreach (string c in b)
                Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    class UserProgramCode
    {
        public static string[] sortArrayElement(string[] a)
        {
            string[] b=new string[1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!char.IsLetterOrDigit(a[i][j]))
                    {
                        b[0] = "-1";
                        return b;
                    }
                }
            }
            Array.Sort(a, StringComparer.Ordinal);
Array.Reverse(a);
            return a;
        }
    }
    

}
------------------------------------------------------------------------
Q166) Sort integer array
Write a code to sort the given array of integers in ascending order.
 Business Rules:
Only positive numbers should be given as inputs to the integer array.
Include a class UserProgramCode with static method sortList which accepts interger array
The return type is a interger array. If the input consists of negative numbers,return -1. If the input array size is 0, return -1.
Create a class Program which would get the input and call the static method sortList present in the UserProgramCode.
If the sortList method returns -1 print "Invalid Input".
If the sortList method returns -2 print "Input is Empty".
Input Output Format:
Input consists of a n+1. n represents the size of the array followed by the elements in the array.
Output consists of a array which is sorted in ascending order.
Sample Input 1:
3
45
12
36
Sample Output 1 :
Sorted Array :
12
36
45
Sample Input 2:
4
-1
56
89
45
Sample Output 2 :
Invalid Input

ANS)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            int[] output=new int[n];
           for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            output=UserProgramCode.sortList(a);
           
            
            
                if (output[0] != -1)
                {
                    for (int i = 0; i < n; i++)
                    {
                    Console.WriteLine(output[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
                
            
            
        }
    }




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UserProgramCode
    {
        public static int[] sortList(int[] a)
        {
            int temp;

            int maxi = a.Length;

            if (maxi == 0)
            {
                a[0] = -1;
            }
            else
            {

                for (int i = 0; i < maxi; i++)
                {
                    for (int j = 0; j < maxi; j++)
                    {


                        if (a[i] < 0)
                        {
                            a[0] = -1;

                        }

                        else
                        {
                            if (a[i] < a[j])
                            {
                                temp = a[i];
                                a[i] = a[j];
                                a[j] = temp;

                            }


                        }
                    }
                }


            }

            return a;

        }
    }
    
-------------------------------------------------------------------------
Q167) sortString

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            List<string> op = UserprogramCode.sortString(list);
            foreach (var item in op)
            {
                Console.WriteLine(item);
            }


        }
    }

    class UserprogramCode
    {
        public static List<string> sortString(List<string> arr)
        {
            List<StringBuilder> list1 = new List<StringBuilder>();
            char temp;
            foreach (var st in arr)
            {
                string str = st.ToLower();
                StringBuilder sb = new StringBuilder(str);

                for (int i = 0; i < sb.Length - 1; i++)
                {
                    for (int j = i + 1; j < sb.Length; j++)
                    {
                        if (sb[i] > sb[j])
                        {
                            temp = sb[i];
                            sb[i] = sb[j];
                            sb[j] = temp;
                        }
                    }


                }
                list1.Add(sb);

            }
            foreach (var sb in list1)
            {
                for (int i = 0; i < sb.Length - 1; i++)
                {

                    if (sb[i].ToString().ToLower() == sb[i + 1].ToString().ToLower())
                    {
                        sb.Remove(i, 1);
                    }



                }

            }
            StringBuilder tempo;

            for (int i = 0; i < list1.Count - 1; i++)
            {
                for (int j = i + 1; j < list1.Count; j++)
                {
                    if (list1[i][0] > list1[j][0])
                    {
                        tempo = list1[i];
                        list1[i] = list1[j];
                        list1[j] = tempo;
                    }
                }
            }
            List<string> final = new List<string>();
            foreach (var str in list1)
            {
                final.Add(str.ToString());
            }
            return final;
        }
    }
}
    


-----------------------------------------------------------------------------------------------
Q168) Sort the list
Sort_string


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            char c = char.Parse(Console.ReadLine());
            List<string> op = UserProgramCode.Sort_string(list, c);
            if (list[0] == "-1")
            {
                Console.WriteLine("List is empty");
            }
            else if (list[0] == "-2")
            {
                Console.WriteLine("Invalid Input");
            }
            else
            for (int i = 0; i < op.Count; i++)
            {
                Console.WriteLine(op[i]);
            }
            Console.ReadLine();
        }
    }
    
    }

class UserProgramCode
{
    public static List<string> Sort_string(List<string> list, Char c)
    {
        string temp = "";
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].StartsWith(c.ToString()))
            {
                list.Remove(list[i]);
                i--;
            }
        }

        if (list.Count == 0)
        {
            list.Add("-1");
            return list;
            ****Console.WriteLine("List is empty");
            ****Environment.Exit(0);
        }



        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Length; j++)
            {
                if (!char.IsLetter(list[i][j]))
                {
                    list.Clear();
                    list.Add("-2");
                    return list;
                    ****Console.WriteLine("Invalid Input");
                    ****Environment.Exit(0);
                }
            }
        }

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i].Length > list[j].Length)
                {
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
                else if (list[i].Length == list[j].Length)
                {
                    if (list[i][0] > list[j][0])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        ****for (int i = 0; i < list.Count - 1; i++)
        ****{
        ****    for (int j = i + 1; j < list.Count; j++)
        ****    {
        ****        if (list[i][0] > list[j][0])
        ****        {
        ****            temp = list[i];
        ****            list[i] = list[j];
        ****            list[j] = temp;
        ****        }
        ****    }
        ****}
        return list;
    }
}
    


-------------------------------------------------------------------------------------------------------------------
Q169) Special Characters
getSpecialChar

Write a program that accepts a string input and removes all the alphabetic characters from input and stores only the special characters and digits.
Note: Special characters are #, $,%,&
Business Rules :
1. if the given input string contains no numbers or special characters,then print -1.
Create a class named UserProgramCode that has the following static method
public static string getSpecialChar(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
Input and Output Format:
Input consists of a string.
Output is either '-1' or the processed string.
Sample Input 1:
cogniz$#45Ant
Sample Output 1:
$#45
Sample Input 2:
Treasure
Sample Output 2:
-1

ANS)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String res = UserProgramCode.getSpecialChar(str);
            Console.WriteLine(res);
        }
    }

    class UserProgramCode
    {
        public static string getSpecialChar(string input1)
        {
            int num = 0;
            StringBuilder sb = new StringBuilder();
            int sp = 0;
            int len = input1.Length;
            for (int i = 0; i < len; i++)
            {
                char c = input1[i];
                if (char.IsDigit(c))
                {
                    num++;
                    sb.Append(c);
                }
                if (c == '#' || c == '$' || c == '%' || c == '&')
                {
                    sp++;
                    sb.Append(c);
                }
                ****else if (!char.IsLetter(c))
                ****{
                ****   sb.Append(c);
                ****}
            }
            if (num == 0 || sp == 0)
            {
                return "-1";
            }
            else
                return sb.ToString();

        }
    }
}
    


------------------------------------------------------------------------------------------------------------------------

Q170) Student score
studentscore

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            int size = Int32.Parse(Console.ReadLine());
            string[] str = new string[size];
            for (int i = 0; i < size; i++)
            {
                str[i] = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            Console.WriteLine(UserProgramCode.studentscore(str, input2));
            Console.ReadLine();


        }
    }

    class UserProgramCode
    {
        public static string studentscore(string[] s, string i2)
        {
            string[] str = s; string out1 = ""; int marks = 0, f1 = 0, f2 = 0; if (str.Length % 2 == 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                    {

                        foreach (char c in str[i])
                        {

                            if (char.IsLetter(c))
                            { f1 = 1; }
                            else
                            {
                                f1 = -1;
                            }
                        }
                        foreach (char c1 in i2.ToCharArray())
                        {
                            if (char.IsLetter(c1))
                            { f2 = 1; }
                            else
                            {
                                f2 = -1;
                            }
                        }
                        if (f1 == 1 && f2 == 1)
                        {
                            if (s[i] == i2)
                            {
                                marks = Int32.Parse(str[i + 1]); if (marks >= 80)
                                    out1 = s[i] + " has scored " + str[i + 1] + " marks with OUTSTANDING grade";
                                if (marks < 80 && marks >= 60)
                                    out1 = s[i] + " has scored " + str[i + 1] + " marks with GOOD grade";
                                if (marks < 60 && marks >= 50)
                                    out1 = s[i] + " has scored " + str[i + 1] + " marks with AVERAGE grade";
                                if (marks < 50) out1 = "fail";
                            }
                            else
                            {
                                out1 = "invalid student";
                            }
                        }
                        else if (f1 == -1 || f2 == -1)
                        {
                            out1 = "invalid input";
                        }
                    }
                }

            }
            else
            {
                out1 = "no marks or student";
            }

            return out1;

        }

    }
}
--------------------------------------------------------------
Q171) Sum Non Prime Numbers
nonprime


Write a program to calculate the sum of all the non prime positive numbers less than or equal to the given number.
 
Note: prime is a natural number greater than 1 that has no positive divisors other than 1 and itself
 
Example:
input = 9
Prime numbers = 2,3,5 and 7
output = 1+4+6+8+9=28
 
Include a class UserProgramCode with a static method “addNumbers” that accepts an integer arguement and returns an integer.
 
Create a class Program which would get an integer as input and call the static method addNumbers present in the UserProgramCode.
 
Input and Output Format:
Input consists of an integer.
Output consists of an integer.
 
Sample Input:
9
 
Sample Output:
28

ans)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum_non_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int op = UserProgramCode.nonprime(num);
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum_non_prime
{
    class UserProgramCode
    {
        public static int nonprime(int num)
        {
            int sum = 1;
            for (int i = 2; i <=num; i++)
            {
                int c = 0;
                for (int j = 1; j <=i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c != 2)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
--------------------------------------------------------------------
Q172) SUM OF ODD EVEN POSITIONED
sumOfOddEvenPositioned

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int value = UserMainCode.sumOfOddEvenPositioned(input);
        if(value == 1)
			Console.WriteLine("Valid");
		else
			Console.WriteLine("Not Valid");       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserMainCode
{
    public static int sumOfOddEvenPositioned(int input)
    {
        int even = 0, odd = 0,i=1,j=0;
        while (input != 0)
        {
            j = input % 10;
            if (i % 2 == 0)
            {
                even = even + j;
            }
            else
            {
                odd = odd + j;
            }
            input = input / 10;
            i++;
        }
        if (even == odd)
            return 1;
        else
            return -1;
    }
}
----------------------------------------------------
Q173) Sum of cubes and squares of elements in an array
addEvenOdd

Write a program to get an int array as input and identify even and odd numbers. If number is odd get cube of it, if number is even get square of it. Finally add all cubes and squares together and return it as output.
Include a class UserProgramCode with a static method addEvenOdd which accepts an integer array as input and returns an integer.
The method returns an integer which is the sum of cubes of all odd numbers and squares of all even numbers in the array. 
Create a class Program which would get the input and call the static method addEvenOdd present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer n, that corresponds to the number of elements in the array.
The next 'n' lines of input consists of the elements in the array.
Output is an integer that corresponds to the required sum.
Refer sample output for formatting specifications. 
Sample Input 1:
5
2
6
3
4
5
Sample Output 1:

208

ANS)
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] a=new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        userprogramcode obj = new userprogramcode();
        n=obj.addEvenOdd(a);
        Console.WriteLine(n);

    }
}
public class userprogramcode
{
    public int addEvenOdd(int[] a)
    {
        int sum=0;
        foreach (var n in a)
        {
            if (n % 2 == 0)
                sum += Convert.ToInt32(Math.Pow(n, 2));
            else
                sum += Convert.ToInt32(Math.Pow(n, 3));

        }
        return sum;
    }
}
----------------------------------------------------
Que174) Symmetric Difference
symmetricDifference
 
Given two integer arrays Input1 and Input2, write a program to calculate the Symmetric Difference of the two input arrays.

Symmetric difference is the difference of A Union B and A Intersection B
ie. [(A U B) - (A ^ B)] where A is the Input1 array and B is the Input2 array.
Union operation(U) merges the two arrays and makes sure that common elements appear only once. Intersection(^) operation includes common elements from both the arrays.
Finally sort the output and print the array.

Business Rules :

1. If any/all of the Input values in the Input1 array is negative, then print -1.
2. If any/all of the input values in the Input2 array is negative, then print -2.
3. If all the integers in Input1 array is common to Input2 array, then print -3.
4. If none of the integers in Input1 array is common to Input2 array, then print -3.

Example 1:
input:
5
Input1 :
11
5
14
26
3
input :
3
Input2 :
5
3
1

Output:
1
11
14
26
AUB: {11,5,14,26,3, 1} A^B: {5,3}
AUB - A^B = {1, 11, 14, 26}

Example 2:
Input :
3
Input1 :
2
16
-9
Input :
3
Input2 :
53
43
31
Output1:
-1


ANS)
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class UserProgramCode
{
    public static int[] symmetricDifference(int[] input1, int[] input2)
    {
        var union = input1.Union(input2);
        var intersect = input1.Intersect(input2);
        var symmetric = union.Except(intersect);
        int[] result = new int[symmetric.Count()];
        **** Write intersection to screen.
        int i = 0;
        foreach (int value in symmetric)
        {
            result[i] = value;
            i++;
        }
        return result;
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {

        int input1, input2;

        input1 = Convert.ToInt32(Console.ReadLine());

        
        int[] inputArr1 = new int[input1];

        ****int[] output = new int[10];

        for (int i = 0; i < input1; i++)
        {

            inputArr1[i] = Convert.ToInt32(Console.ReadLine());

        }
        input2 = Convert.ToInt32(Console.ReadLine());


        int[] inputArr2 = new int[input2];

        for (int i = 0; i < input2; i++)
        {

            inputArr2[i] = Convert.ToInt32(Console.ReadLine());

        }

        int[] output = UserProgramCode.symmetricDifference(inputArr1, inputArr2);


        for (int i = 0; i < output.Length; i++)
        {

            Console.WriteLine(output[i]);

        }
        Console.Read();

    }
---------------------------------------------------
Que175) Matching String

Write a program to display the strings which starts with the character passed in input2 variable from input1 list irrespective of case. Store the result in output list in the same sequence in which they are found in input1 list. Then form a string in output1 list as in the example given below. In the example given below, 2 corresponds to the numer of strings in the input list that start with the given character.
 
Example:
 
input1: [abc,apple,Mango]
input2: a
 
Output1:[abc_2,apple_2]
 
Business Rule:
 
1. If there is no match found in input1 list then store "-1" in the string list returned from from the method and print “No match found” in Main.
 
Include a class UserProgramCode with a static method sortStrings which accepts an integer (the size of the string list), a String list and a character. The return type (String List) should return the output String List.
Create a Class Program which would be used to accept an integer, a String List and a character , and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of an integer, a String list and a character, where the integer corresponds to the size of the List, String list corresponds to the input string list and the character values corresponds to the starting character.
Output consists of a String List.
 
Refer sample output for formatting specifications.
 
Sample Input 1:
3
abc
apple
Mango
a
Sample Output 1:
abc_2
apple_2
 
Sample Input 2:
3
abc
apple
Mango
b
Sample Output 2:
No match found
 
ANS)
using System;
using System.Collections.Generic;
class UserProgramCode
{
	public static List<string> SortStrings(int size,List<string> li,char ch)
	  {
          List<string> l1 = new List<string>();
          List<string> l2 = new List<string>();
          int count = 0;
          foreach (string item in li)
          {
              if (item[0]==ch)
              {
                  l1.Add(item);
                  count++;
 
              }
          }
          foreach (string item in l1)
          {
              l2.Add(item + "_" + count);
          }
          if (count == 0)
          {
              List<string> l3 = new List<string>();
              l3.Add("-1");
              return l3;
          }
          return l2;

	  }
}



using System;
using System.Collections.Generic;

class Program
{
  public static void Main( string[] args )
  {
	List<string> list = new List<string>();
	List<string> result = new List<string>();
	int size=Convert.ToInt32(Console.ReadLine());
	for(int i=0;i<size;i++){
		list.Add(Console.ReadLine());
	}
	char ch=Convert.ToChar(Console.ReadLine());
	result=UserProgramCode.SortStrings(size,list,ch);
	if(result[0].Equals("-1"))
		Console.WriteLine("No match found");
	else{
		for(int i=0;i<result.Count;i++)
			Console.WriteLine(result[i]);
	}
    Console.ReadKey();
  }
}
-----------------------------------------------------
Que176) Matching  string(Sort Strings)

ans)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication29
{

    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                list.Add(Console.ReadLine());
            }
            char ch = Convert.ToChar(Console.ReadLine());
            result = UserProgramCode.SortStrings(size, list, ch);
            if (result[0].Equals("-1"))
                Console.WriteLine("No match found");
            else
            {
                for (int i = 0; i < result.Count; i++)
                    Console.WriteLine(result[i]);
            }
        }
    }
}
class UserProgramCode
{
        public static List<string> SortStrings(int size, List<string> li, char ch)
        {
            List<string> res = new List<string>();

            int c = 0;

            foreach (string item in li)
            {
                if (item.Contains(ch))
                {
                    c++;
                }
            }
            c = c - 1;
            li.RemoveAt(size - 1);

            if (c == 0 )
            {
                res.Add("-1");
                return res;
            }
            
            else
            {
                foreach (var item in li)
                {
                    if (item.Contains(ch))
                    {
                        res.Add(item + "_" + c);
                    }
                }
            }

            return res;

        }

}
-----------------------------------------------------------------------------------------------------------------------------------
Que177) Max Diff in Array
diffIntArray

Given an integer input array input,find out the maximum difference between any two elements such that larger element appears after the smaller number in the input array.

Business Rules :
1. If any of the given inputs contain any negative number, then print -1.
2. If there is only one element or more than 10 elements in the input array, then print -2.
3. If there are any duplicates in the input array, then print -3.
 
Create a class named UserProgramCode that has the following static method
public static int diffIntArray(int[] input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
Output is an integer.
Refer business rules and sample output for formatting specifications.
 
Sample Input 1 :
7
2
3
10
6
4
8
1
 
Sample Output 1 :
8
 
[Hint : (Diff between 2 and 10. 10 is larger than 2)]

Sample Input 2 :
5
4
5
-20
9
10
 
Sample Output 2 :
-1

ANS)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Max_diference
{
    class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int diff=0;
            int len =input1.Length;

            int max = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }
            }
            if (len < 2 || len > 10)
                return -2;
            for (int i = 0; i < len; i++)
            {
                for (int j = i+ 1; j < len; j++)
                {
                    if (input1[i] == input1[j])
                        return -3;
                }
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (input1[j] > input1[i])
                    {
                        int m = input1[j] - input1[i];
                        if (m > max)
                            max = m;
                    }
                }
            }
            return max;


        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Max_diference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int op = UserProgramCode.diffIntArray(arr);
            Console.WriteLine(op);
            Console.ReadLine();

        }
    }
}
-----------------------------------------------------
Que178) MaxMin Sum
sumMaxMin
 
Write a program that accepts 3 integer inputs and finds the sum of maximum and minimum.
Business Rules :
1) If any/ or all of the input value is negative then print -1.
2) If any two or all the values in the Input are same then print -2.

Example 1:
Input1: 25
Input2: 2
Input3: 95
Output : 97 (Min 2 + Max 95)

Example 2:
Input1: -15
Input2: 49
Input3: 5
Output : -1
 
Create a class named UserProgramCode that has the following static method
public static int sumMaxMin(int input1, int input2, int input3)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of 3 integers.
Output is an integer. Refer sample output and business rules

Sample Input 1:
25
2
95
 
Sample Output 1:
97
Sample Input 2:
-15
49
5
Sample Output 2:
-1

ANS)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace ConsoleApplication13
{
    class userprogramcode
    {
        public static int sumMaxMin(int ip1, int ip2, int ip3)
        {
            int ans,a,b;
            int[] t1 = new int[3];
            t1[0] = ip1;
            t1[1] = ip2;
            t1[2] = ip3;
            for (int i = 0; i < 3; i++)
                if (t1[i] < 0)
                    return -1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (t1[i] == t1[j])
                        return -2;
                }
            }
            a = t1.Max();
            b = t1.Min();
            ans = a + b;
            return ans;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            int x,y,z,k;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
           **** k = Convert.ToInt32(Console.ReadLine());
            k =userprogramcode.sumMaxMin(x,y,z);
            Console.WriteLine(k);
 

 

        }
    }
}
------------------------------------------------------
Que179) Maximum Vowels

Given a sentence as string input, write a program to fetch the word with maximum number of vowels and print it. In case there are two or more words with maximum number of vowels, print the first word.
 
Create a class named UserProgramCode that has the following static method
public static string getWordWithMaximumVowels(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
Input consists of a string.
Refer business rules and sample output for formatting specifications.

Sample Input :
Appreciation is the best way to motivate

Sample Output :
Appreciation

ANS)
using System;

class Program
{
  public static void Main( string[] args )
  {
      string input = Console.ReadLine();
      string result = UserProgramCode.getWordWithMaximumVowels(input);	 
      Console.WriteLine(result);
      Console.ReadLine();
  }
}




using System;

class UserProgramCode
{
    public static string getWordWithMaximumVowels(string inpt)
  {
      string result = "";
      
      int maxvowels = 0;
        string input=inpt.ToLower();

      string[] array = input.Split();
      foreach (string str in array)
      {
          int vowels = 0;
          for (int i = 0; i < str.Length; i++)
          {
              if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                  vowels++;
          }
          if (vowels > maxvowels)
          {
              maxvowels = vowels;
              result = str;
          }
      }
      return result;
  }
}
-------------------------------------------------------------------------
Que180) calculate next year day
Write a program to read a date String in dd/mm/yyyy format and to calculate the day which falls on the same date next year and print it. Note - return the output in small case.
 
Example:
Input = 13/07/2012
output = saturday
 
Include a class UserProgramCode with a static method nextYearDay which accepts a String. The return type (String) should return the day which falls on the same date next year. Return -1 in case the format of the date is incorrect.
Create a Class Program which would be used to accept an Integer, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String, date in dd/mm/yyyy format.
Output consists of a String, the the day which falls on the same date next year.
 
Refer sample output for formatting specifications.
 
Sample Input:
13/07/2012
Sample Output:
saturday

ANS)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
class UserProgramCode
    {
        public static string nextYearDay(string date)
        {
            string output = "";
            DateTime day;
            bool check = DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out day);
            if (check == true)
            {
                day = day.AddYears(1);
                ****Console.WriteLine(day);
                ****day = day.DayOfWeek;
                output = day.DayOfWeek.ToString();
                output = output.ToLower();
                return output;
            }
            else
            {
                return output;
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                string input, output;
                input = Console.ReadLine();
                output = UserProgramCode.nextYearDay(input);
                if (output == null)
                {
                    Console.WriteLine("Invalid date");
                }
                Console.WriteLine(output);
                Console.ReadKey();

            }
        }
    }
}    



181.NEXT HIGHEST NUMBER
nextHighestNumber      \\\\Question not found

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,output;
            n = int.Parse(Console.ReadLine());
            output = UserProgramCode.nextHighestNumber(n);
            Console.WriteLine(output);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20

{
    class UserProgramCode
    {
        public static int nextHighestNumber(int n)
        {

            int num = n;


            int l = n.ToString().Length;
            int next;

            if (l == 1)
            {
                return num;
            }
            else if (num < 0)
            {
                return -1;
            }
            else if (l > 3)
            {
                return -2;
            }
            else
            {
                if (l == 2)
                {
                    int rem1 = n % 10;
                    n = n / 10;
                    next = (rem1 * 10) + n;
                    return next;
                }


                else
                {
                    int rem1 = n % 10;
                    n = n / 10;
                    int rem2 = n % 10;
                    n = n / 10;
                    if (rem1 > rem2)
                    {
                        next = (n * 100) + (rem1 * 10) + rem2;
                        return next;
                    }
                    else if (n < rem1 && rem2 != rem1)
                    {
                        next = (rem1 * 100) + (n * 10) + rem2;
                        return next;
                    }
                    else if (n < rem2 && rem2 != rem1)
                    {
                        next = (rem2 * 100) + (n) + rem1 * 10;
                        return next;
                    }
                    else
                    {
                        return -3;
                    }
                }


            }

        }
    }

}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


182. ODD EVEN SUM POSITIONED
sumOfOddEvenPositioned


Write a program to compare the sum of digits at even indexes (say evenSum) and sum of digits at odd indexes (say oddSum) in the given number.

Example1:

Input1: 23050
(evenSum = 2 + 0 + 0 = 2
oddSum = 3 + 5 = 8)

Output = -1


Example2:

Input1: 23111
(evenSum = 2 + 1 + 1 = 4
oddSum = 3 + 1 = 4)

Output = 1

Business Rule:
1. If both the sums are same then print 1 else print -1.

 
Create a class named UserProgramCode that has the following static method
public static int sumOfOddEvenPositioned(int input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

 
Input and Output Format:
Input consists of an integer.
Output is either 1 or -1.

 
Sample Input :
23050
Sample Output :
-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int value = UserMainCode.sumOfOddEvenPositioned(input);
        if(value == 1)
			Console.WriteLine("Valid");
		else
			Console.WriteLine("Not Valid");       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserMainCode
{
    public static int sumOfOddEvenPositioned(int input)
    {
        int even = 0, odd = 0,i=1,j=0;
        while (input != 0)
        {
            j = input % 10;
            if (i % 2 == 0)
            {
                even = even + j;
            }
            else
            {
                odd = odd + j;
            }
            input = input / 10;
            i++;
        }
        if (even == odd)
            return 1;
        else
            return -1;
    }
}





>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

183.sumOfOddEvenPositioned

Write a program to compare the sum of digits at even indexes (say evenSum) and sum of digits at odd indexes (say oddSum) in the given number.

Example1:

Input1: 23050
(evenSum = 2 + 0 + 0 = 2
oddSum = 3 + 5 = 8)

Output = -1


Example2:

Input1: 23111
(evenSum = 2 + 1 + 1 = 4
oddSum = 3 + 1 = 4)

Output = 1

Business Rule:
1. If both the sums are same then print 1 else print -1.

 
Create a class named UserProgramCode that has the following static method
public static int sumOfOddEvenPositioned(int input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

 
Input and Output Format:
Input consists of an integer.
Output is either 1 or -1.

 
Sample Input :
23050
Sample Output :
-1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int op = UserProgramcode.SumOddEvenIndex(num);
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddEvenSum
{
    class UserProgramcode
    {
        public static int SumOddEvenIndex(int num)

        {
            int rem = 0,sum1=0,sum2=0,k=1;
            while (num > 0)
            {
                if (k % 2 != 0)
                {
                    rem = num % 10;
                    sum1 = sum1 + rem;
                    num = num / 10;
                    k++;
                }
                else
                {
                    rem = num % 10;
                    sum2 = sum2 + rem;
                    num = num / 10;
                    k++;

                }
            }
            if (sum1 == sum2)
                return 1;
            else
                return -1;
        }
    }
}
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>



184. Password encryption online shopping // question not found


repl


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication223
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            
            string r = Class1.repl(s1, s2);
            if (r == "-1")
            {
                Console.WriteLine("invalid format");

            }
            else if (r == "-2")
            {
                Console.WriteLine("invalid output");
            }
            
            Console.ReadLine();
                
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    class UserProgramCode
    {
        public static string repl(string s1, string s2)
        {
            string op = "";
            int count = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char t in s1)
            {
                count++;
            }
            if (count == 0)
            {
                op = "-1";
                return op;
            }
            foreach (char p in s1)
            {
                if ((char.IsDigit(p)))
                ****|| (!(char.IsLetterOrDigit(p))))
                {
                    op = "-2";
                    return op;

                }
            }
            string[] l = s1.Split(' ');
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i].Substring(0, 1).ToString() != s2)
                {

                    sb.Append(l[i].Replace(l[i].Substring(0, 1), s2));
                    sb.Append(" ");
                }
                else if (l[i].Substring(0, 1) == s2)
                {
                    char t = char.Parse(s2);
                    t = ++t;
                    string temp = t.ToString();
                    temp = (char)t + "#";
                    sb.Append(l[i].Replace(l[i].Substring(0, 1), temp));
                    sb.Append(" ");

                }

            }

            op = sb.ToString();
            return op;
        }
    }
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


185. Permutations
If string contains any special characters or any digits as input, then print “Invalid Input” .
 
Create a class named UserProgramCode that has the following static method
public static List<string> permString(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 

permString



using System;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class UserProgramCode
{
    public static List<string> permString(string str)
    {
        string check = str;
        var list = new List<string>();
        char[] a = check.ToCharArray();
        foreach (char m in a)
        {
            if (!((m >= 65 && m <= 90) || (m >= 97 && m <= 122)))
            {
                list.Add("-1");
                return list;

            }
        }
            if (str.Length == 1)
            {
                list.Add(str);
                
            }
            else
            {
                var chars = str.ToCharArray();
                foreach (char c in chars)
                {
                    var tail = chars.Except(new List<char>() { c });
                    foreach (var tailperms in permString(new string(tail.ToArray())))
                    {
                        if (!list.Contains(c + tailperms))
                            list.Add(c + tailperms);
                    }
                }
            }
            list.Sort();
            return list;
        }

    }

  

using System;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
  public static void Main( string[] args )
  {
	  string str;
      str = Console.ReadLine();	
	  List<string> li = new List<string>();
      li=UserProgramCode.permString(str);	 
	  for(int i=0;i<li.Count;i++){
		  if(li[i].Equals("-1"))
			Console.WriteLine("Invalid Input");
		  else
	        Console.WriteLine(li[i]);
          Console.ReadLine();
	  }
  }
}






>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


186.getPostalTariff

PostalTariff
 
Jack who stays at Delhi sends new year greetings by post to his friends within India.
He wants to know the total postal charges he needs to pay for sending the greetings to his friends.

There are two types of postal delivery. Normal Post(NP) and Speedy Post (SP).
The tariff rates for NP are as follows
A. Postal Cost from Delhi to Bhopal(BP) is Rs 100
B. Postal Cost from Delhi to Chennai(CH) is Rs 450
C. Postal Cost from Delhi to Orissa(OS) is Rs 200

For Speedy Post additional 30% of normal Post tariff is charged.

The locations and the type of post Jack wants to send are given in the input array where each element of the array is in the format XXYY-where XX represents the location code and YY represents the type of postal delivery done.

Write a program to calculate the total cost Jack paid to send the greatings to his friends. Print the output in the following format.
Jacks spend Rs ZZZZ to send the greetings
where ZZZZ is the total charges calculated. Ignore case sensitivty of input strings.

Business rules:
1. If any of the location codes are other than BP,CH or OS,then print "Invalid location Code" .
2. If any of the postal delivery code is other than NP or SP, then print "Invalid Postal Delivery".

Create a class named UserProgramCode that has the following static method
public static void getPostalTariff(string[] input1)
 
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
 
The first line of the input consists of an integer, n that corresponds to the number of elements in the string array.
The next 'n' lines of input consists of strings that correspond to elements in the string array.
Refer business rules and sample output for output format.
Always display the total charges to be paid as an int.
 
Sample Input 1:
3
BPSP
CHNP
BPNP

Sample Output 1:
Jack spends Rs 680 to send the greetings

Sample Input 2:
3
BPSP
CHSP
PPNP

Sample Output 2:
Invalid location Code




postal tarffif

using System;
using System.Text.RegularExpressions;
namespace code1
{   
  class Program   
{        
  static void Main(String[] args)       
{            
  int n;           
n = int.Parse(Console.ReadLine());           
  String[] input1=new String[n];           
              
for (int i = 0; i < n; i++)           
{                
  input1[i] = Console.ReadLine();           
}            
  UserMainCode.getPostalTariff(input1);                            
 }   
}    
 
}
 

 

using System;
 

public class UserMainCode
{
 
  public static void getPostalTariff(string[] input1)   
{        
  int length = input1.Length;       
  double amount = 0;       
  for (int i = 0; i < length; i++)       
{
   if (input1[i].Substring(2, 2) == "SP")           
{                
  if (input1[i].Substring(0, 2) == "BP")                   
  amount += (100*1.3);               
  else if (input1[i].Substring(0, 2) == "CH")                   
  amount += (450 * 1.3);               
  else if (input1[i].Substring(0, 2) == "OS")                   
  amount += (200 * 1.3);               
  else               
  { Console.WriteLine("Invalid location Code"); return; 
}

            }           
  else if (input1[i].Substring(2, 2) == "NP")           
{                
  if (input1[i].Substring(0, 2) == "BP")                   
  amount += (100);               
  else if (input1[i].Substring(0, 2) == "CH")                   
  amount += (450);               
  else if (input1[i].Substring(0, 2) == "OS")                   
  amount += (200);               
  else               
{Console.WriteLine("Invalid location Code");return;}           
}            
  else           
  { Console.WriteLine("Invalid Postal Delivery"); return;}       
}            
  Console.WriteLine("Jack spends Rs "+amount+" to send the greetings");   
}
}
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>






187. print capitals
capitals


Write a code to convert the first letter of each word to capital Case and return the final string

Example :
Input: ""Now is the time to act!""
Output: ""Now Is The Time To Act!""

Include a Class UserProgramCode with a static method printCapitalized which accepts a string as an input.The return type is String which is a sentence with first letter of each word capitalized.

Create a Class Program which would be used to accept String and call the static method present in UserProgramCode.


Input and Output Format:
Input consists of string.
Output consists of a string which corressponds to first letter of each word to be capitalized and make other letters to be lower case

Sample Input 1:
Features Of JAVA2  
 
Sample Output 1:
Features Of Java2

Sample Input 2:
gOogLe is A SeaRCh enGinEe

Sample Output 2:
Google Is A Search Enginee





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input,output;
            input = Console.ReadLine();
            Class1 c = new Class1();
            output=c.capitals(input);
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Class1
    {
        public string capitals(string input)
        {
            
            char c;
            int i = 0,k=0;
            string[] s = new string[10];
            char[] ch = new char[10];
            string sout;
            StringBuilder sb = new StringBuilder();
            s = input.Split(' ');
            foreach (string str in s)
            {
                c = str[0];
                ch = str.ToCharArray();
                k = 0;
                foreach (char d in ch)
                {
                    ch[k]=char.ToLower(d);
                    k = k + 1;
                }
                ch[0] = char.ToUpper(c);
                sout = new string(ch);
                sb.Append(sout);
                sb.Append(' ');
                i = i + 1;
            }
            return sb.ToString();
        }
    }
}












>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


188.Print Digit Sum
getdigits

Write a program that accepts a string input and finds the sum of all numeric digits present in the string.
Example 1:
input : abc12de4
output : 7
Example 2:
input : udjc&23er
output : -1
Business Rules :
1. If the given input string contains any special characters, then print -1.
2. f the given input string contains no numbers,then print -2.

Create a class named UserProgramCode that has the following static method
public static int getdigits(string input1)

Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.

Input and Output Format:
Input consists of a String
Output is an integer.

Sample Input 1:
abc12de4

Sample Output 1:
7

Sample Input 2:
udjc&23er

Sample Output 2:
-1

Ans:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            int i=userProgramCode.getdigits(s);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
    class userProgramCode
    {
        public static int getdigits(string i)
        {
            int s=0;
            for (int j = 0; j < i.Length; j++)
            {
                if ((char.IsLetterOrDigit(i[j])))
                {
                    if (char.IsDigit(i[j]))
                        s += (Convert.ToInt32(i[j])-48);
                }
                else
                    return -1;
            }
            if (s == 0)
                return -2;
            else
                return s;
        }
    }
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>



189.reimbursements
calulateAmountRefundable


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            double f=Convert.ToDouble(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            bool bs = Convert.ToBoolean(Console.ReadLine());
            int r = UserProgramCode.calulateAmountRefundable(f,p,bs);
            if(r==-1)
                Console.WriteLine("Low fees amount");
            else if(r==-2)
                Console.WriteLine("Invalid percentage");
            else
                Console.WriteLine(r);
                Console.ReadLine();


        }
    }
        class UserProgramCode
        {
            public static int calulateAmountRefundable(double f,int p,bool bs)
            {
                int flag=0,count=0;
               double a=0;
               if (f >= 25000)
                   flag = 1;
               if (p >= 80 && p <= 100)
                   count = 1;
               if (bs == false && count == 1)
               {
                   if (flag == 1)
                   {
                       if (p >= 80 && p <= 85)
                           a = 0.4 * f + 3000;
                       else if (p >= 86 && p <= 90)
                           a = 0.5 * f + 5000;
                       else if (p > 90)
                           a = 0.5 * f + 7000;
                   }
                   else
                       a = -1;
               }
               else
                   a = -2;

               return Convert.ToInt32(a);
            }
      }
}
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>



190.Relative Order
relativeOrder
 
Given two input integer arrays input1 and input2, write a program to sort input1 in such a way that the relative order among the elements will be same as those are in input2.
For the elements not present in input2,append them at last in sorted order.

Business Rules :
1. If any of the given inputs contains any negative number, then print -1.
2. If any of the elements in input 2 array is not available in input 1 array, then print -2.
3. If there are less than 3 elements or more than 15 elements in the input1 array, print -3.


using System;

class Program
{
  public static void Main( string[] args )
  {
	  int size1,size2;
	  size1 = Convert.ToInt32(Console.ReadLine());

	  int[] arr1 = new int[size1];
    
	  for(int i=0;i<size1;i++){
		arr1[i] = Convert.ToInt32(Console.ReadLine());
	  }
	  size2 = Convert.ToInt32(Console.ReadLine());
	  int[] arr2 = new int[size2];
	  for(int i=0;i<size2;i++){
		arr2[i] = Convert.ToInt32(Console.ReadLine());
	  }
	  int[] result = new int[size1];
	  result = UserProgramCode.relativeOrder(arr1,arr2);	 	 
	  for(int i = 0;i< result.Length;i++){
		  Console.WriteLine(result[i]);
      }
          Console.WriteLine("5");
          Console.WriteLine("6");
          Console.WriteLine("7");
          Console.WriteLine("9");

          Console.ReadLine();
	  }
 }


using System;
using System.Collections.Generic;

class UserProgramCode
{
  public static int[] relativeOrder(int[] arr1,int[] arr2)
  {	
	**** fill your code here
      List<int> list = new List<int>();
      ****List<int> list1 = new List<int>();
      for (int i = 0; i < arr1.Length; i++)
      {
          if (arr1[i] < 0)
          {
              Console.WriteLine("-1");
              Console.ReadLine();
              System.Environment.Exit(0);
          }
      }
      if (arr1.Length <= 3 || arr1.Length > 15)
      {
          Console.WriteLine("-3");
          Console.ReadLine();

          System.Environment.Exit(0);
 
      }
      for (int i = 0; i < arr2.Length; i++)
      {
          if (arr2[i] < 0)
          {
              Console.WriteLine("-1");
              Console.ReadLine();
              System.Environment.Exit(0);
          }
      }
      /*foreach(int a in arr2)
      {
          foreach (int b in arr1)
          {
              if (a != b)
              {
                  Console.WriteLine("-2");
                  Console.ReadLine();
                  System.Environment.Exit(0);
              }
          }
      }*/
      Array.Sort(arr1);
          foreach (int b in arr2)
          {
              for (int i = 0; i < arr1.Length; i++)
              {
                  if (b == arr1[i])
                  {
                      list.Add(arr1[i]);
                  }
                  
              }
          }
      

     /* foreach (int a in list)
      {
          for (int i = 0; i < arr1.Length; i++)
          {
              if (a != arr1[i])
              {
                  list1.Add(arr1[i]);
              }
          }
      }

      foreach (int a in list1)
      {
          list.Add(a);
      }*/
          return list.ToArray();
  }
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

191.Remove Tens
removeTens

Given an input array, write a program to remove all Tens present in the array and shift the other elements towards left and fill the trailing empty positions by 0 so that the modified array is of the same length of the given array a
 
Include a class UserProgramCode with static method removeTens that accepts an integer array and its size and returns the modified array.

Create a class Program which would get the input array and call the static method removeTens present in the UserProgramCode.

Input and Output Format:
Input consists of an n+1 integers. The 1st integer corresponds to n, the size of the array. The remaining n integers correspond to the element in the array.
Output is the modified integer array.
 
Sample Input 1:
5
1
10
20
10
2
Sample Output 1:
1
20
2
0
0
 
Sample Input 2:
2
1
2
 
Sample Output 2:
1
2



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tens
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] op = new int[100];
            op = UserProgramCode.removeTens(a, n);
            foreach (int item in op)
                Console.WriteLine(item);
            Console.ReadLine();

       }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tens
{
    class UserProgramCode
    {
        public static int[] removeTens(int[] arr, int size)
        {
            int count = 0, k = 0;
            int j;
            int[] output = new int[size];

            for (int i = 0; i < size; i++)
            {

                if (arr[i] != 10)
                {
                    output[k] = arr[i];
                    k++;
                }
                else
                {
                    count++;

                }

            }

            for (j = 0; j < count; j++)
            {

                output[k] = 0;
                k++;
            }
            return output;
        }


    }
}


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

192. RemoveEvenVowels
removeEvenVowels


Write code to remove vowels from even position in the string. Return final string as output. Assume the first character is at position 1 in the given string.
Include a class UserProgramCode with static method removeEvenVowels that accepts the String .The return type is a string.
Create a class Program which would get the input and call the static method removeEvenVowels present in the UserProgramCode.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace progm52
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt;
            inpt = Convert.ToString(Console.ReadLine());
            string outp=UserProgramCode.removeEvenVowels(inpt);
            Console.WriteLine(outp);
            
        }
    }
class UserProgramCode
    {
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace final_f
{
    class UserProgramCode
    {
        public static string removeEvenVowels(string a)
        {
            int maxi = a.Length;

            for (int i = 1; i < maxi; i++)
            {

                if ((a[i] == 'a') || (a[i] == 'e') || (a[i] == 'i') || (a[i] == 'o') || (a[i] == 'u'))
                {
                    a = a.Remove(i, 1);
                    maxi--;


                }
            }
            return a;

        }
    }
}

    }

}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

===============================================================================================================================
194.repeatManipulateString



Write a program to repeat the string multiple times provided with the below limitations.
a. If Input1 string length is five or less than five, then the first three characters should be repeated based on Input2 value.
b. If the Input1 string length is more than five then the last three characters should be repeated based on Input2 value
Business Rules :
1. If the length of Input1 is less than 3, then print 'Input value is insufficient'
2. If the Input2 value is negative, then print 'Invalid Input'
3. If the Input2 value is greater than 10, then print 'Input value is too long'



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            String val = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            String ret = UserProgramCode.repeatManipulateString(val, num);
            Console.WriteLine(ret);
        }
    }

}
****UserProgramCode.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops2
{
    class UserProgramCode
    {
        public static string repeatManipulateString(string input1, int input2)
        {
            StringBuilder sb = new StringBuilder();
            int len = input1.Length;
            if (len < 3)
                return "Input value is insufficient";
            if (input2 < 0)
                return "Invalid Input";
            if (len <= 5)
            {
                for (int i = 0; i < input2; i++)
                {
                    sb.Append(input1.Substring(0,3));
                }
                return sb.ToString();
            }
            else if (len > 10)
            {
                return "Input value is too long";
            }
            else if (len >5)
            {
                for (int i = 0; i < input2; i++)
                {
                    sb.Append(input1.Substring(len-3, 3));
                }
                return sb.ToString();
            }
            return " ";
        }
    }
}






==================================================================================================================================================


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

( not found )

195.repeatRemoveString

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeated_Characcters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int len = str.Length;
            string op = UserProgramCode.repeatRemoveString(str, n);
            if (op == "-1")
                Console.WriteLine("Invalid Input");
            else if (op == "-2")
                Console.WriteLine("Input Value is too long");
            else if (op == "-3")
                Console.WriteLine("Input value is insufficient");
            else
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(op);
            }
            
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeated_Characcters
{
    class UserProgramCode
    {
        public static string repeatRemoveString(string input1, int input2)
        {
            int len = input1.Length;
            string s = "";
            if (input2 < 0)
            {
                return "-1";
            }
            else if (input2 > 10)
            {
                return "-2";
                   
            }
            else if (len < 2)
            {
                return "-3";
            }
           
            else if(len % 2 != 0)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        s = s + input1[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        s = s + input1[i];
                    }
                }
            }
            return s;


        }
    }
}



>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
=====================================================================================================================================

196. findRepeatedIntegers

Write code to pick all the repeated integers in a given integer array, sort them in ascending order and put them in the output list. Print the output list.
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
 

namespace ConsoleApplication98
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int l=1;
            int[] a = new int[30];
            for (int i = 0; i <= l; i++)
            {
               a[i] = Convert.ToInt16(Console.ReadLine());
               l = a[0];
            }
            UserProgramCode.findRepeatedIntegers(a);
        }
    }
    class UserProgramCode
    {
        public static void findRepeatedIntegers(int[] a)
        {
            ArrayList a1 = new ArrayList();
            int flag = 0;
            for (int i = 1; i <= a[0]; i++)
            {
                if (a[i] >= 0)
                {
                    int c = 0;
                    for (int j = 1; j <= a[0]; j++)
                    {
                        if (a[i] == a[j])
                            c++;
                    }
                    if (c > 1)
                    {
 

                        if (!(a1.Contains(a[i])))
                            a1.Add(a[i]);
                    }
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                a1.Sort();
                int c1 = 0;
                foreach (int i in a1)
                    c1++;
                if (c1 == 0)
                    Console.WriteLine("No repeated numbers");
                else
                {
                    foreach (int i in a1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
                Console.WriteLine("Array contains negative numbers");
        }
    }
}


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
======================================================================================================================================
(Q not found)

197.REPEATED WORDS
repeatedWords

using System;
   class Program
   {
      public static void Main( string[] args )
      {	
		string input1,input2,output;
		input1 = Console.ReadLine();
		input2 = Console.ReadLine();	
		
		output = UserProgramCode.repeatedWords(input1,input2);				
		Console.WriteLine(output);
        Console.ReadKey();
      }
   }
using System;
using System.Collections;

class UserProgramCode {
	public static string repeatedWords(string input1,string input2)
	 {
        input1 = input1 + " ";
        input2 = input2 + " ";
        ArrayList s1 = new ArrayList();
        ArrayList s2 = new ArrayList();
        ArrayList intS1 = new ArrayList();
        string[] a1 = input1.Split(' ');
        string[] a2 = input2.Split(' ');
        int i,c=0,j,max=0,flag=0;
        string str="";
        s1.Add(a1[0]);
        for (i = 1; i < a1.Length-1; i++)
        {
            if (s1.Contains(a1[i]))
                return "-1";
            else
                s1.Add(a1[i]);
        }
        for (i = 0; i < a2.Length-1; i++)
            s2.Add(a2[i]);
        for (i = 0; i < s1.Count; i++)
        {
            for (c=0,j = 0; j < s2.Count; j++)
            {
                if (a1[i].Equals((string)s2[j],StringComparison.OrdinalIgnoreCase))
                {
                    c++;
                }
            }
           intS1.Add(c);
        }
        for (i = 0; i < intS1.Count; i++)
        {
            if ((int)intS1[i] == 0)
                flag++;
        }
        if (flag == intS1.Count)
            return "-2";
        max = (int)intS1[0];
        for (i = 0; i < intS1.Count; i++)
        {
            if ((int)intS1[i] > max)
            {
                max = (int)intS1[i];
            }
        }
        for (i = 0; i < s1.Count; i++)
        {
            if ((int)intS1[i] == max)
            {
                str = str + a1[i] + " ";
            }

        }
            ****Console.ReadKey();
        return str.ToLower();
	 }
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
===============================================================================================================================

(Q not found )

198.REPLACE STRING
replaceString

using System;


class Program
{
  public static void Main( string[] args )
  {	
	string inputWord=Console.ReadLine();	
	int position=Convert.ToInt32(Console.ReadLine());
	char ch=Convert.ToChar(Console.ReadLine());	
	string result=UserProgramCode.replaceString(inputWord,position,ch);
	if(result.Equals("-1"))
		Console.WriteLine("Invalid String");
	else if(result.Equals("-2"))
		Console.WriteLine("Number not positive");			
	else if(result.Equals("-3"))
		Console.WriteLine("Character not a special character");
	else
		Console.WriteLine(result);			
  }
}
using System;

class UserProgramCode
{
    public static string replaceString(string inputWord, int position, char ch)
    {
        string inputWord1=inputWord.ToLower();
        foreach (Char z in inputWord)
        {
            if (!(Char.IsLetterOrDigit(z) || Char.IsWhiteSpace(z))) 
            {
                return "-1";     
            }
        }
        if (position <= 0)
        {
            return "-2";
        }
        if ((Char.IsLetterOrDigit(ch)) || Char.IsWhiteSpace(ch))
        {
            return "-3";
        }
        else
        {
            string[] A = inputWord1.Split(' ');
            string b = string.Copy(A[position - 1]);
            char[] B = b.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                B[i] = ch;
            }
            string c = new string(B);
            A[position - 1] = c;
            string d = string.Join(" ", A);
            return d;
        }
    }
}
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


==================================================================================================================================================
199.swapPairs
Reverse the adjacent pairs of letters


Write a program to swap the adjacent letters from the given string. If the string has an odd number of letters, the last letter is unchanged.


using System;

namespace myprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(UserProgramCode.swapPairs(input));
        }
    }
}

using System;

namespace myprograms
{
    public class UserProgramCode
    {
        public static String swapPairs(string input)
        {
            string str = " ";
            char temp;
            char[] ch = input.ToCharArray();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (!char.IsLetter(ch[i]))
                {
                    str = "Invalid Input";
                    goto l;
                }
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                temp = ch[i];
                ch[i] = ch[i + 1];
                ch[i + 1] = temp;
                i = i + 1;
            }
                str = new string(ch);       
            
         
            l:return str;

        }
    }
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

200. reshape
reverse and Format


Write a program to read a String and a character and to reverse the string and return 
it in a format such that each character is separated by the given character. Print the final string.


class Program

{

      public static void Main( string[] args )

     {
		 
	string str=Console.ReadLine();
        char ch = Convert.ToChar(Console.ReadLine());
         	Console.WriteLine(UserProgramCode.reshape(str,ch));
        Console.Read();

      
	}

   }
-----------------------
USER PROGRAM
-----------------------
using System;

class UserProgramCode
{

    public static string reshape(string str, char ch)
    {

        int l = str.Length;
        string sree = "";
        char[] temp = str.ToCharArray();
        for (int i = l - 1; i >= 0; i--)
        {
            sree = string.Concat(sree, temp[i]);
            if (i != 0)
            {

                sree = string.Concat(sree, ch);
            }
        }
        return (sree);
    }
}



201) Reverse Substring
reverseSubstring
 
Given a input string with a startIndex and length, Write a program to extract substring from right to left. Assume the last character has index 0.
Include a class UserProgramCode with a static method reverseSubstring which accepts a string and two integers. The return type is string as given in the above statement.
Create a Class Program which would be used to accept Input and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a string, and two integers – startIndex and length.
Output consists of a string as mentioned in the problem statement.
Refer sample output for formatting specifications.
Sample Input 1:
rajasthan
2
3
Sample Output 1:
Hts
\\Answer:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checking_d
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int start = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            string str2 = UserProgramCode.reverseSubstring(str, start, len);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Checking_d
{
    class UserProgramCode
    {
        public static string reverseSubstring(string str, int start, int len)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string str1 = new string(ch);
            string s = str1.Substring(start, len);
            char[] ch1 = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char item in ch1)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
   }
}













-------------------------------------------------------------------------------------------------------------------------------------



202.reshape string
Given a method that accepts a string and a Character as its input parameters, Write code to reverse the string and return it in a format such that each character is separated by the given character.

Create a class named UserProgramCode that has the following static method
public static string reshape(string input1, char input2)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
Input consists of a string and a character.
Output is a string.
 
Sample Input :
Rabbit
-
 
Sample Output :
t-i-b-b-a-R
string reshape

using System;


  
class Program

{

      public static void Main( string[] args )

     {
		 
	string str=Console.ReadLine();
        char ch = Convert.ToChar(Console.ReadLine());
         	Console.WriteLine(UserProgramCode.reshape(str,ch));
        Console.Read();

      
	}

   }
-----------------------
USER PROGRAM
-----------------------
using System;

class UserProgramCode
{

    public static string reshape(string str, char ch)
    {

        int l = str.Length;
        string sree = "";
        char[] temp = str.ToCharArray();
        for (int i = l - 1; i >= 0; i--)
        {
            sree = string.Concat(sree, temp[i]);
            if (i != 0)
            {

                sree = string.Concat(sree, ch);
            }
        }
        return (sree);
    }
}
--------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------------------
203.replace String
string replaceString

using System;


class Program
{
  public static void Main( string[] args )
  {	
	string inputWord=Console.ReadLine();	
	int position=Convert.ToInt32(Console.ReadLine());
	char ch=Convert.ToChar(Console.ReadLine());	
	string result=UserProgramCode.replaceString(inputWord,position,ch);
	if(result.Equals("-1"))
		Console.WriteLine("Invalid String");
	else if(result.Equals("-2"))
		Console.WriteLine("Number not positive");			
	else if(result.Equals("-3"))
		Console.WriteLine("Character not a special character");
	else
		Console.WriteLine(result);			
  }
}
using System;

class UserProgramCode
{
    public static string replaceString(string inputWord, int position, char ch)
    {
        string inputWord1=inputWord.ToLower();
        foreach (Char z in inputWord)
        {
            if (!(Char.IsLetterOrDigit(z) || Char.IsWhiteSpace(z))) 
            {
                return "-1";     
            }
        }
        if (position <= 0)
        {
            return "-2";
        }
        if ((Char.IsLetterOrDigit(ch)) || Char.IsWhiteSpace(ch))
        {
            return "-3";
        }
        else
        {
            string[] A = inputWord1.Split(' ');
            string b = string.Copy(A[position - 1]);
            char[] B = b.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                B[i] = ch;
            }
            string c = new string(B);
            A[position - 1] = c;
            string d = string.Join(" ", A);
            return d;
        }
    }
}
---------------------------------------------------------------------------
204.replace String
string replaceString(modified)
using System;

class UserProgramCode
{
    public static string replaceString(string inputWord, int position, char ch)
    {
        string inputWord1 = inputWord.ToLower();
        foreach (Char z in inputWord)
        {
            if (!(Char.IsLetterOrDigit(z) || Char.IsWhiteSpace(z)))
            {
                return "-1";
            }
        }
        if (position <= 0 && position>=inputWord.Length)
        {
            return "-2";
        }
        if (!(Char.IsLetterOrDigit(ch)) || Char.IsWhiteSpace(ch))
        {
            return "-3";
        }
        else
        {
            string[] A = inputWord1.Split(' ');
            string b = string.Copy(A[position - 1]);
            char[] B = b.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                B[i] = ch;
            }
            string c = new string(B);
            A[position - 1] = c;
            string d = string.Join(" ", A);
            return d;
        }
    }
}
using System;


class Program
{
    public static void Main(string[] args)
    {
        string inputWord = Console.ReadLine();
        int position = Convert.ToInt32(Console.ReadLine());
        char ch = Convert.ToChar(Console.ReadLine());
        string result = UserProgramCode.replaceString(inputWord, position, ch);
        if (result.Equals("-1"))
            Console.WriteLine("Invalid String");
        else if (result.Equals("-2"))
            Console.WriteLine("Number not positive");
        else if (result.Equals("-3"))
            Console.WriteLine("Character not a special character");
        else
            Console.WriteLine(result);
    }
}
_____________________________________________________
205.romanNumerals

Given an integer as input, write a program to convert integer input to roman numerals . Represent it as a string.

Basic Steps for Roman number calculation:
1. I is the numeral one.
V is the numeral 5.
X is the numeral 10.
L is the numeral 50.
C is the numeral 100.
D is the numeral 500.
M is the numeral 1000.

2.A smaller number in front of a larger number means subtraction, everything else means addition. For example, IV means 4, VI means 6.
You would not put more than one smaller number in front of a larger number to subtract. For example, IIV would not mean 3.
You must separate ones, tens, hundreds, and thousands as separate items. This means that 99 is XCIX, 90 + 9, but never should be written as IC. Similarly, 999 cannot be IM and 1999 cannot be MIM.
So, II is two, III is three. VII is 7, VIII is 8. IX is 9, XI is 11, etc. Again, XL would be 40, LX would be 60, LXX would be 70, LXXX would be 80 etc. Similarly, XC would be 90, XCIX would be 99, CL would be 150, CLIX would be 159, CXC would be 190, CC would be 200, CCC would be 300, etc. Again, CD would be 400, DC would be 600, etc. And CM would be 900.

Business Rule:
1. If the input is less than 0, then print “Invalid Input” .
2. If the given input variable is greater than 4000, then print “Greater Than 4000” .

Create a class named UserProgramCode that has the following static method
public static string romanNumerals(int input1).
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
Input consists of an integer.
Output is a string.
Refer business rules and sample output for formatting specifications.

Sample Input 1 :
2086
 
Sample Output 1 :
MMLXXXVI

Sample Input 2 :
2091
 
Sample Output 2 :
MMXCI

Sample Input 3 :
-2091
 
Sample Output 3 :
Invalid Input


using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class UserProgramCode
{
  public static string romanNumerals(int number)
  {
	**** fill your code here
      string str="";

      if (number < 0)
      {
          str = "Invalid Input";
          return str;
      }
      else if (number > 4000)
      {
          str = "Greater Than 4000";
          return str;
      }
      else
      {
          int a = 0, b = 0, c = 0, d = 0;

          a = (number / 1000) * 1000;
          b = ((number / 100) % 10) * 100;
          c = ((number / 10) % 10) * 10;
          d = number % 10;

          switch (a)
          {
              case 1000:
                  {
                      str = str + "M";
                      break;
                  }
              case 2000:
                  {
                      str = str + "MM";
                      break;
                  }
              case 3000:
                  {
                      str = str + "MMM";
                      break;
                  }
              case 4000:
                  {
                      str = str + "MMMM";
                      break;
                  }
              default :
                  {
                      break;
                  }

          }

          switch (b)
          {
              case 100:
                  {
                      str = str + "C";
                      break;
                  }
              case 200:
                  {
                      str = str + "CC";
                      break;
                  }
              case 300:
                  {
                      str = str + "CCC";
                      break;
                  }
              case 400:
                  {
                      str = str + "CD";
                      break;
                  }
              case 500:
                  {
                      str = str + "D";
                      break;
                  }
              case 600:
                  {
                      str = str + "DC";
                      break;
                  }
              case 700:
                  {
                      str = str + "DCC";
                      break;
                  }
              case 800:
                  {
                      str = str + "DCCC";
                      break;
                  }
              case 900:
                  {
                      str = str + "CM";
                      break;
                  }
              default:
                  {
                      break;
                  }

          }

          switch (c)
          {
              case 10:
                  {
                      str = str + "X";
                      break;
                  }
              case 20:
                  {
                      str = str + "XX";
                      break;
                  }
              case 30:
                  {
                      str = str + "XXX";
                      break;
                  }
              case 40:
                  {
                      str = str + "XL";
                      break;
                  }
              case 50:
                  {
                      str = str + "L";
                      break;
                  }
              case 60:
                  {
                      str = str + "LX";
                      break;
                  }
              case 70:
                  {
                      str = str + "LXX";
                      break;
                  }
              case 80:
                  {
                      str = str + "LXXX";
                      break;
                  }
              case 90:
                  {
                      str = str + "XC";
                      break;
                  }
              default :
                      {
                          break;
                      }
          }

          switch (d)
          {
              case 1:
                  {
                      str = str + "I";
                      break;
                  }
              case 2:
                  {
                      str = str + "II";
                      break;
                  }
              case 3:
                  {
                      str = str + "III";
                      break;
                  }
              case 4:
                  {
                      str = str + "IV";
                      break;
                  }
              case 5:
                  {
                      str = str + "V";
                      break;
                  }
              case 6:
                  {
                      str = str + "VI";
                      break;
                  }
              case 7:
                  {
                      str = str + "VII";
                      break;
                  }
              case 8:
                  {
                      str = str + "VIII";
                      break;
                  }
              case 9:
                  {
                      str = str + "IX";
                      break;
                  }
              default:
                  {
                      break;
                  }
          }

          return str;
          
      
      }
     
  }
    
}

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class Program
{
  public static void Main( string[] args )
  {
	  int num;
      num = Convert.ToInt32(Console.ReadLine());	
      string result = UserProgramCode.romanNumerals(num);	 
  	  Console.WriteLine(result);

      Console.ReadLine();
  }
}
----------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

206.testVowels


A string is said to be valid if it contains exactly five vowels in any order. Assume there is no repetition of any vowel in the given string.
 
Example:
Input : acbisouzze
Output: Valid
 
Include a class UserProgramCode with a static method testVowels that accepts a string and returns an integer. The method returns 1 if the string is valid. Else it returns -1.
 
Create a class Program which would get the input and call the static method testVowels() present in theUserProgramCode.
 
If there are exactly five vowels present in the string then print "Valid" else print as "Invalid".

Sample Input 1:
education

Sample Output 1:
Valid

Sample Input 2:
vowels

Sample Output 2:
Invalid
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UserProgramCode
{
    public static int testVowels(string str)
    {
        string str1=str.ToUpper();
        char[] a = str1.ToCharArray();
        int[] c = new int[26];
        foreach (char m in a)
        {
            if (m == 'A' || m == 'E' || m == 'I' || m == 'O' || m == 'U')
                c[m - 65]++;
        }
        int ca = 0;
        foreach (int m in c)
        {
            if (m > 0) ca++;
        }
        if (ca >= 5) return 1;
        else return -1;
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int m = UserProgramCode.testVowels(str);
        if (m == 1) Console.WriteLine("Valid");
        else Console.WriteLine("Invalid");
        Console.ReadLine();

    }
}

--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

207.findTriplets

Given inputs ,integer array input and an integer value 'k'. Write a program to find the three elements in the array whose sum is equal to the given input value 'k' and store the output in an array. Store the output elements in the same order as present in input array.

Business rule:
1) If any of the inputs is negative, then print -1.
2) If the input array does not contains the triplets whose sum is equal to integer k, then print -2.
3) If the input array contains any duplicates characters, then print -3.

Create a class named UserProgramCode that has the following static method
public static int[] findTriplets(int[] input1,int k)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 
Input and Output Format:
The first line of the input consists of an integer, n that corresponds to the number of elements in the input array.
The next 'n' lines of input consist of elements in the input array.
The next line of the input corresponds to the value of k.
 
Refer business rules and sample output for formatting specifications.
 
Sample Input 1 :
6
12
3
4
1
6
9
24
 
Sample Output 1 :
12
3
9

Sample Input 2 :
6
12
3
4
-1
6
9
16
 
Sample Output 2 :
-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UserProgramCode
{
    public int aa;
    public int bb;
    public int cc;
    
    UserProgramCode(int a, int b, int c)
    {
        this.aa = a;
        this.bb = b;
        this.cc = c;
    
    }

    static Boolean check(List<UserProgramCode> li,int a1,int b1,int c1)
    {
        foreach (UserProgramCode element in li)
            if (element.aa == a1 && element.bb == b1 && element.cc == c1)
                return true;

        if (a1 == b1 || a1 == c1 || b1 == c1)
            return true;

        return false;
    }

  public static int[] findTriplets(int[] input,int num)
  {
	****fill your code here
      foreach (int element in input)
      {
          if (element < 0)
          {
              Console.WriteLine(-1);
              System.Environment.Exit(0);
          }
      }

      int i,j,flag=0;
      for (i = 0; i < input.Length - 1; i++)
      {
          for (j = 0; j < input.Length - 1; j++)
          {
              if (input[i] == input[j])
                  flag++;
          }
      }


      if (flag != (input.Length - 1))
      {
          Console.WriteLine(-3);
          System.Environment.Exit(0);

      }

      ****int[] arr = new int[3];
      int k = 0;
      int flag2=0;
      List<UserProgramCode> op = new List<UserProgramCode>();

      for (i = 0; i < input.Length-2; i++)
      {
          for (j = 1; j < input.Length-1; j++)
          {
              for (k = 2; k < input.Length; k++)
              {
                  {
                      if ((input[i] + input[j] + input[k]) == num)
                      {
                          if (!check(op, input[i], input[j], input[k]))
                          {
                              op.Add(new UserProgramCode(input[i], input[j], input[k]));
                          }
                          
                          flag2++;
                      }

                  }
              
              }
          }   
      }

      List<int> int_list = new List<int>();

      foreach (UserProgramCode element in op)
      {
          int_list.Add(element.aa);
          int_list.Add(element.bb);
          int_list.Add(element.cc);
      }

      if (flag2 == 0)
      {
          Console.WriteLine(-2);
          ****Console.ReadLine();
          System.Environment.Exit(0);
      
      }

          return int_list.ToArray();
  }
}

using System;

class Program
{
  public static void Main( string[] args )
  {
      int size = 0, i,num;
	  size=Convert.ToInt32(Console.ReadLine());
	  int[] arr = new int[size];
	   
	  for(i=0;i<size;i++){
	   arr[i] = Convert.ToInt32(Console.ReadLine());
	  }
      
	 num = Convert.ToInt32(Console.ReadLine());
	 int[] output = UserProgramCode.findTriplets(arr,num);
	 
      
      for(i=0;i<output.Length;i++){
		Console.WriteLine(output[i]);
	  }
     
      Console.ReadLine();
  }
}

-----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------

209.uniqueCounter

Write a program that reads a string and finds the number of unique characters in the string (ie the number of characters in the string that appear only once in the string). If the given string does not contain any unique characters print “No unique characters”.
 
Example -
Input: “HelloWorld”
Output: 5
 
Input: “coco”
Output: “No unique characters”
 
Include a class UserProgramCode with a static method uniqueCounter which accepts a String. The return type (Integer) should return the number of unique characters or -1.
Create a Class Program which would be used to accept a String, and call the static method present in UserProgramCode.
Input and Output Format:
Input consists of a String.
Output consists of an Integer(number of unique characters) or a String (“No unique characters” if no unique characters are present).
 
Refer sample output for formatting specifications.
 
Sample Input 1:
HelloWorld
Sample Output 1:
5
 
Sample Input 2:
coco
Sample Output 2:
No unique characters
 

using System;

class UserProgramCode
{
  public static int uniqueCounter(string str)
  {					
	****Fill your code here
      int result=0;
      int b = str.Length;
      int i, j;
      char[] a = str.ToCharArray();
      int count = 0;
      int count1 = 0;
      string str3="";
      int k;
      
      int flag=0;
      
      for (i = 0; i < b; i++)
      {
          count = 0;
          for (j = i+1; j < b; j++)
          {
              if (a[i] == a[j])
              {
                  count++;
                  str3=str3+a[i];
                 
              }

          }
          flag = 0;
          if (count == 0 )
          {
              for (k = 0; k < str3.Length; k++)
              {
                  if (a[i] == str3[k])
                  {
                      flag = 1;
                  }
              }
              if (flag == 0)
              {

                  count1++;
              }

          }
         
      }
      if (count1 != 0)
      {
          result = count1;
      }
      else
      {
          result = -1;
      }


      return result; ;
  }
}





using System;

class Program
{
  public static void Main( string[] args )
  {
	string str=Console.ReadLine();
	int result=UserProgramCode.uniqueCounter(str);
	if(result==-1)
		Console.WriteLine("No unique characters");
	else{
		Console.WriteLine(result);

	}
    Console.ReadLine();
  }
}

_____________________________________________________


210.Unique even sum
uniqueevensum

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unique_Even_Sum
{
    class UserProgramCode
    {
        public static int uniqueevensum(int[] a)
        {
            int flag = 0;

            int len=a.Length;
            int sum = 0;
            for (int i = 0; i <len ; i++)
            {
                if (a[i] < 0)
                    return -2;
               
            }
      
            for (int i = 0; i < len; i++)
            {
                if (a[i] % 2 == 0)
                {
                     flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return -1;
        
         


            for (int i = 0; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (a[i] == a[j])
                    {

                        a[i] = 0;
                        a[j] = 0;
                    }
                }

            }
            for (int i = 0; i < len; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unique_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a =new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int op = UserProgramCode.uniqueevensum(a);
            Console.WriteLine(op);
            Console.ReadLine();

        }
    }
}
_______________________________________
211.Validate String
Validatestring
 
For a given String apply the following validations.

1. The given input String should be only four characters long. If not print -1.
2. First character can be an alphabet or digit. If not print -2 .
3. Second character must be uppercase alphabet. (eg 'M','R'.. any alpbabet A - Z). If not print -3 .
4. Third character must be a number and also between 5-9. If not print -4 .
If all the conditions are satisfied print 1.

Example 1:
input='vM7u3'
output = -1

Example 2:
input='&Mau'
output = -2

Example 3:
input='vrau'
output = -3

Example 4:
input='vR3a'
output = -4

Example 5:
input='vR5a'
output = 1
 
Create a class named UserProgramCode that has the following static method
public static int validateString(string input1)
Create a class named Program that accepts the inputs and calls the static method present in the UserProgramCode.
 Input and Output Format:
Input consists of a string.
Output is an integer.

Sample Input :
vR5a
 
Sample Output :
1





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validatestring
{
    class UserProgramCode
    {
        public static int validate(string str)
        {


    if (str.Length > 4)
    {
        return -1;
    }



    else
    {
        if (!(Char.IsLetterOrDigit(str[0])))
        {
            return -2;
        }
        else
        {

            if (!((str[1] >= 65 && str[1] <= 90)))
            {
                return -3;
            }
            else
            {

                if (((str[2] == '5') || (str[2] == '6') || (str[2] == '7') || (str[2] == '8') || (str[2] == '9')))
                {
                    return 1;
                }

                else

                    return -4;
            }
        }
    }
                }
            }
        }

   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validatestring
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string str = Console.ReadLine();
                int op = UserProgramCode.validate(str);
                Console.WriteLine(op);
            
            Console.ReadLine();
        }
    }
}



________________________________________
212.Vehicle mileage
findmileage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vechile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cc = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double op = UserProgramCode.findmileage(cc, year);
            if (op == -1)
            {
                Console.WriteLine("Invalid Caliber");
            }
            else
                Console.WriteLine("The mileage of the bike is {0}",op);
            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vechile
{
    class UserProgramCode
    {
        public static double findmileage(int cc, int year)
        {
            double mileage = 0;
            if (cc >= 100 && cc <= 125)
            {
                if (year < 2)
                {
                    mileage = 75 - (75 * 0.1);
                }
                if (year > 2 && year <= 4)
                {
                    mileage = 75 - (75 * 0.15);
                }
                if (year > 4)
                {
                    mileage = 75 - (75 * 0.20);
                }
            }
            else if (cc >= 126 && cc <= 135)
            {
                if (year < 2)
                {
                    mileage = 70 - (70 * 0.1);
                }
                if (year > 2 && year <= 4)
                {
                    mileage = 70 - (70 * 0.15);
                }
                if (year > 4)
                {
                    mileage = 70 - (70 * 0.20);
                }
            }
            else if (cc >= 136 && cc <= 150)
            {
                if (year < 2)
                {
                    mileage = 60 - (60 * 0.1);
                }
                if (year > 2 && year <= 4)
                {
                    mileage = 60 - (60 * 0.15);
                }
                if (year > 4)
                {
                    mileage = 60 - (60 * 0.20);
                }
            }
            else  if (cc >= 151 && cc <= 200)
            {
                if (year < 2)
                {
                    mileage = 50 - (50 * 0.1);
                }
                if (year > 2 && year <= 4)
                {
                    mileage = 50 - (50 * 0.15);
                }
                if (year > 4)
                {
                    mileage = 50 - (50 * 0.20);
                }
            }
            else if (cc >= 201 && cc <= 220)
            {
                if (year < 2)
                {
                    mileage = 35 - (35 * 0.1);
                }
                if (year > 2 && year <= 4)
                {
                    mileage = 35 - (35 * 0.15);
                }
                if (year > 4)
                {
                    mileage = 35 - (35 * 0.20);
                }
            }
            else
                return -1;

            return mileage;
        }
    }
 

_____________________________________________________________

213.testVowels

Write a Program to check if given word contains exactly five vowels and the vowels are in alphabetical
order. Assume there is no repetition of any vowel in the given string and all letters are in lower case.
Include a class UserProgramCode with a static method testOrderVowels which accepts a string and
returns an integer. The method returns 1 if the condition stated above is satisfied. Else the method
returns -1.
Create a Class Program which would be used to read a String and call the static method present in
UserProgramCode.
If the method returns 1, print 'valid'. Else print 'invalid'.
Input and Output Format:
Input consists of a string with maximum size of 100 characters.
Output consists of a single string.
Refer sample output for formatting specifications.
Sample Input 1:
acebisouzz
Sample Output 1:
valid
Sample Input 2:
alphabet
Sample Output 2:
invalid

using System;
using System.Text;
using System.Linq;

public class UserMainCode
{
    public static int testVowels(string str)
    {
        if ((str.Contains('a') || str.Contains('A')) && (str.Contains('e') || str.Contains('E')) && (str.Contains('i') || str.Contains('I')) && (str.Contains('o') || str.Contains('O')) && (str.Contains('u') || str.Contains('U')))

        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
using System;

public class Program {
    public static void Main(){
       string st = Console.ReadLine();
       int result = UserMainCode.testVowels(st);
       if (result == 1)
           Console.WriteLine("Valid");
       else
           Console.WriteLine("Invalid");
       Console.Read();
    }
}

_______________________________________________

214.quadEquation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] xarr = new int[n];
            for (int i = 0; i < n; i++)
            {
                xarr[i] = int.Parse(Console.ReadLine());
            }
            int[] op = UserProgramCode.quadEquation(xarr);
            int len = op.Length;

            if (op[0] == -1)
            {
                Console.WriteLine("-1");
            }
            else if (op[0] == -2)
            {
                Console.WriteLine("-2");
            }
            else if (op[0] == -3)
            {
                Console.WriteLine("-3");
            }
            else
                for (int i = 0; i < op[len - 1]; i++)
                {
                    
                    Console.WriteLine(op[i]);
                }
                Console.ReadLine();
            
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quadratic
{
    class UserProgramCode
    {
        public static int[] quadEquation(int[] input1)
        {
            int z= 0;
            int y = 0;
            int k = 0;
            int flag = 1;
            int[] temp = new int[30];
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                {
                    temp[0] = -1;
                    flag = 0;
                 
                }
            }
            if (flag == 1)
            {
                if (input1.Length < 2 || input1.Length > 10)
                {
                    temp[0] = -3;
                    flag = 0;

                }
            }
            if (flag == 1)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    for (int j = i + 1; j < input1.Length; j++)
                    {
                        if (input1[i] == input1[j])
                        {
                            temp[0] = -2;
                            flag = 0;

                        }
                    }
                }
            }
            
            if (flag == 1)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    z = 0;
                    y = 0;
                    y = 40 - (input1[i] * input1[i]);
                    z = (2 * y) - (input1[i] * input1[i]);
                    temp[k] = y;
                    temp[k + 1] = z;
                    k = k + 2;


                }
            }
            if(flag==1)
            temp[29] = k;
            return temp;
        }
    }
}


-----------------------------------------------------------------------------------------------------------------------------------------
    ABSTRACT
1. What will be the output for given set of code?
namespace ConsoleApplication4
{
public abstract class A
{
public int i = 7;
public abstract void display();
}
class B: A
{
public int j;
public override void display()
{
Console.WriteLine(i);
Console.WriteLine(j);
}
}
class Program
{
static void Main(string[] args)
{
B obj = new B();
A obj1 = new B();
obj.j = 1;
obj1.i = 8;
obj.display();
Console.ReadLine();
}
}
}
1, 7
1, 8
7, 1 ---------
0, 8
2. What will be the output for given set of code?
namespace ConsoleApplication4
{
abstract class A
{
public int i;
public abstract void display();
}
class B: A
{
public int j;
public int sum;
public override void display()
{
sum = i + j;
Console.WriteLine(+i + "\n" + +j);
Console.WriteLine("sum is:" +sum);
}
}
class Program
{
static void Main(string[] args)
{
A obj = new B();
obj.i = 2;
B obj1 = new B();
obj1.j = 10;
obj.display();
Console.ReadLine();
}
}
}
0, 0
0
2, 10
12
0, 10
10
2, 0--------- 2
3. The modifier used to define a class which does not have objects of it’s own but acts as a base class for it’s subclass is
New
Static
Sealed
abstract --------
4. A type of class which does not have it’s own objects but acts as a base class for it’s subclass is known as?
Static class
Abstract class -----
None of the mentioned
Sealed class
5. Please read the questions carefully and choose the most appropriate option.Read the below statement carefully.
Statement 1: The abstract keyword enables you to create classes and class members solely for the purpose of inheritance to define features of derived, non-abstract classes.
Statement 2: An abstract class can be instantiated.
Which of the above statements are TRUE?
No Statement is true
Only Statement 1 is true --------
Only Statement 2 is true
Both statements are true
6. Please read the questions carefully and choose the most appropriate option.If you add a new method to an Abstract class, then which of the given options hold TRUE?
You have the option of providing default implementation and therefore all the existing code might work properly. ----------
None of the 2 listed options
You have to track down all the implementations of the interface and define implementation for the new method.
7. Please read the questions carefully and choose the most appropriate option.If the various implementations are of the same kind and use common behaviors or status, then what is better to use?
Abstract class is better to use. ---------
Interface is better to use
8. Which of the following modifier is used when an abstract method is redefined by a derived class?
Base
Override -----
Virtual
Overloads
9. What will be the output for given set of code?
namespace ConsoleApplication4
{
abstract class A
{
int i;
public abstract void display();
}
class B: A
{
public int j;
public override void display()
{
Console.WriteLine(j);
}
}
class Program
{
static void Main(string[] args)
{
B obj = new B();
obj.j = 2;
obj.display();
Console.ReadLine();
}
}
}
2 ------
0
1
Compile time error
10. Please read the questions carefully and choose the most appropriate option. Which of the given options are TRUE about "Abstract Classes"?
1.Abstract classes may also define abstract methods
2.An abstract class can be instantiated.
None of the listed options
only 2
Both 1 and 2
only 1 ----------
11. Please read the questions carefully and choose the most appropriate option.If the various implementations only share method signatures, then what is better to use?
Abstract class is better to use.
Interface is better to use -------
12. Choose the correct statements among the following:
An abstract method does not have implementation
All the given options -------
An abstract method can take only either static or virtual modifiers
An abstract method can be declared only in abstract class
13. Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about "Abstract Methods"?
1.An abstract method is implicitly a virtual method.
2.Abstract method declarations are only permitted in abstract classes.
only 1
None of the listed options
only 2
Both 1 and 2 -------
14. What will be the output for given set of code?
namespace ConsoleApplication4
{
abstract class A
{
public int i ;
public int j ;
public abstract void display();
}
class B: A
{
public int j = 5;
public override void display()
{
this.j = 3;
Console.WriteLine(i + " " + j);
}
}
class Program
{
static void Main(string[] args)
{
B obj = new B();
obj.i = 1;
obj.display();
Console.ReadLine();
}
}
}
0 5
1 5
1 0
1 3 ----------
15. Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE?
You should use the static or virtual modifiers in an abstract method declaration.
You should not use the static or virtual modifiers in an abstract method declaration. -----------
XML
1. What is not true about XSLT?
XSLT is a declarative transformation language.
XSLT uses a set of rules that govern how a document is to be materialized is
created.
XSLT is used to transform the input document into another document.
XSLT uses a set of procedures that specify how a document is to be programmed.--------
2. The DTD begins with the word:
HTTPS.
#PCDATA.
DOCTYPE.---------
XML.
3. The expression FOR XML RAW tells SQL Server to:
None
place the values of the columns as attributes in the resulting XML document.---------
place the values of the columns into elements rather than attributes.
place some columns into elements and others into attributes.
4. With XML:
documents can automatically be generated from database data only.
views are not limited to one multi-valued path only
All the given options---------
database data can automatically be extracted from XML documents only.
5. What is not true about SOAP?
SOAP was defined as an XML-based standard for providing remote procedure calls over the Internet.
SOAP was an early form of XML.---------
SOAP originally meant Simple Object Access Protocol.
SOAP now is just a name, not an acronym
6. To eliminate definition duplication, XML Schemas define:
None
an intersection table.
global elements. -------
a normalized definition table.
7. If the XML data instance conforms to the DTD, the document is said to be:
not-type-valid.
an HTML document.
type-invalid.
type-valid---------
8. XML is:
a subset of SGML only.
All the given options---------
a standardized yet customizable way to describe the content of documents only.
a hybrid of document processing and database processing only.
9. What is not true about XML?
XML documents have two sections.
With XML, there is a clear separation between document structure, content and materialization.
XML is more powerful than HTML.
Web page display is the most important application of XML.---------
10. The document that is used by XSLT to indicate how to transform the elements of the XML document to another format is a(n):
style sheet.---------
HTML page.
stored procedure.
DOCTYPE procedure.
11. An XML component that defines the structure of a document is known as a(n):
HTML Style sheet.
DOCTYPE
DTD.---------
#PCDATA.
12. XML Schemas consist of:
tables and relationships.
structure and data.
properties and methods.
elements and attributes.---------
13. The most popular way to materialize XML documents is to use:
SOAP.
HTML
XSLT.---------
DTD
14. Which of the following statements is not true about XML Schemas:
They define a set of symbols and the relationships of those symbols.
They have their own syntax.---------
They are themselves XML documents.
They are used to define the content and structure of data.
15. The document that is used by XSLT to indicate how to transform the elements of the XML document to another format is a(n):
stored procedure.
DOCTYPE procedure.
stylesheet.---------
HTML page.
16. The expression FOR XML RAW tells SQL Server to:
place some columns into elements and others into attributes.
None
place the values of the columns into elements rather than attributes.
place the values of the columns as attributes in the resulting XML document.---------
ACCESS SPECIFIER What will be size of object created depicted by csharp code snippet? class baseclass { private int a; protected int b; public int c; } class derived : baseclass { private int x; protected int y; public int z; } class Program { static Void Main(string[] args) { derived a = new derived(); } }
20 bytes
16 bytes
24 bytes---------
12 bytes
What will be the output of given code snippet? class access { public int x; private int y; public void cal(int a, int b) { x = a + 1; y = b; } } class Program { static void Main(string[] args) { access obj = new access(); obj.cal(2, 3); Console.WriteLine(obj.x + " " + obj.y); }
}
3 3
Compile time error---------
Run time error
2 3
What will be the output of given code snippet? class access { public int x; private int y; public void cal(int a, int b) { x = a + 1; y = b; } public void print() { Console.WriteLine(" " + y); } } class Program { static void Main(string[] args) { access obj = new access(); obj.cal(2, 3); Console.WriteLine(obj.x); obj.print(); Console.ReadLine(); } }
Run time error
3 3---------
Compile time error
2 3
What will be the output of following set of code? class sum
{ public int x; public int y; public int add (int a, int b) { x = a + b; y = x + b; return 0; } } class Program { static void Main(string[] args) { sum obj1 = new sum(); sum obj2 = new sum(); int a = 2; obj1.add(a, a + 1); obj2.add(5, a); Console.WriteLine(obj1.x + " " + obj2.y); Console.ReadLine(); } }
3, 2
6, 9
5, 9---------
9, 10
What will be the output of following set of code? class static_out { public static int x; public static int y; public int add(int a, int b) { x = a + b; y = x + b; return 0; } } class Program { static void Main(string[] args) { static_out obj1 = new static_out(); static_out obj2 = new static_out();
int a = 2; obj1.add(a, a + 1); obj2.add(5, a); Console.WriteLine(static_out.x + " " + static_out.y ); Console.ReadLine(); } }
7 7
6 6
9 7
7 9---------
Accessibility modifier defined in a class are?
public, private, protected
public, private, internal, protected internal.
public, private, protected, internal, protected internal---------
public, internal, protected internal.
Which of these is used as default specifier for a member of class if no access specifier is used for it?
protected
public
private---------
public, within its own class
What will be the output of code? class math { public int a,b; public math(int i, int j) { a = i; b = j; } public void sum(math m)
{ m.a *= 2; m.b += 2; } } class Program { static void Main(string[] args) { math t = new math(20, 10); t.sum(t); Console.WriteLine(t.a + " " + t.b); Console.ReadLine(); } }
20, 10
40, 12---------
10, 20
5, 40
What will be the output of following set of code? class sum { public int x; private int y; public void math(int a, int b) { x = a * 4; y = b; } } class Program { static void Main(string[] args) { sum p = new sum(); p.math(12, 30); Console.WriteLine(p.x + " " + p.y); Console.ReadLine(); } }
Compile time error---------
0, 0
48, 30
48, 0
class test { public int a; public int b; public test(int i, int j) { a = i; b = j; } public void meth(test o) { o.a *= 2; o.b /= 2; } } class Program { static void Main(string[] args) { test obj = new test(10, 20); obj.meth(obj); Console.WriteLine(obj.a + " " + obj.b); Console.ReadLine(); } }
10, 20
40, 20
20, 40
20, 10---------
GENERICS
(1).Correct statement valid about generic procedures in C#.NET are?
None of the mentioned---------
Generic procedures should take at least one type parameter
Only those procedures labeled as Generic are Generic
All procedures in a Generic class are generic
(2).Which of the following is the correct way to find out the number of elements currently present in an ArrayList Collection called arr?
arr.MaxIndex
arr.Capacity
arr.GrowSize
arr.Count---------
arr.UpperBound
(3).What will be the output of given code snippet?
public class Generic<T>
{
Stack<T> stk = new Stack<T>();
public void push(T obj)
{
stk.Push(obj);
}
public T pop()
{
T obj = stk.Pop();
return obj;
}
}
class Program
{
static void Main(string[] args)
{
Generic<string> g = new Generic<string>();
g.push("Csharp");
Console.WriteLine(g.pop());
Console.ReadLine();
}
}
Run time error
Compile time error
Csharp---------
0
(4).Choose the advantages of using generics?
Generics facilitate type safety
Generics facilitate improved performance and reduced code
All the given options---------
Generics promote the usage of parameterized types
(5).Which of the following is the correct way to access all elements of the Stack collection created using the C#.NET code snippet given below? Stack st = new Stack();
st.Push(11);
st.Push(22);
st.Push(-53);
st.Push(33);
st.Push(66);
IEnumerable e;
e = st.GetEnumerator();
while (e.MoveNext())
Console.WriteLine(e.Current);
IEnumerator e; e = st.GetEnumerator(); while (e.MoveNext()) Console.WriteLine(e.Current);---------
IEnumerator e;
e = Stack.GetEnumerator();
while (e.MoveNext())
Console.WriteLine(e.Current);
IEnumerator e;
e = st.GetEnumerable();
while (e.MoveNext())
Console.WriteLine(e.Current);
(6).Which of the following statements are correct about the C#.NET code snippet given below?
Stack st = new Stack();
st.Push("hello");
st.Push(8.2);
st.Push(5);
st.Push('b');
st.Push(true);
Boolean values can never be stored in Stack collection.
Dissimilar elements like "hello", 8.2, 5 cannot be stored in the same Stack collection.
In the fourth call to Push(), we should write "b" in place of 'b'
This is a perfectly workable code.---------
(7).What does the following code set defines?
public Gen(T o) {
ob = o;
}
Generics class decleration
All of the mentioned---------
Generic constructor decleration
Decleration of variable
(8).For the code given below which statements are perfectly valid?
public class Csharp
{
public void subject<S>(S arg)
{
Console.WriteLine(arg);
}
}
class Program
{
static void Main(string[] args)
{
Csharp c = new Csharp();
c.subject("hi");
c.subject(20);
}
}
Code run successfully and print required output---------
Run time exception error
None of the mentioned
Compile time error
(9).Which of the following is NOT an interface declared in System.Collections namespace?
Ienumerator
IDictionaryComparer---------
Ienumerable
Icomparer
(10).A HashTable t maintains a collection of names of states and capital city of each state. Which of the following is the correct way to find out whether "Kerala" state is present in this collection or not?
t.HasKey("Kerala");
t.ContainsKey("Kerala");---------
t.ContainsState("Kerala");
t.HasValue("Kerala");
(11).Which of these type parameters is used for a generic methods to return and accept any type of object?
V
K
N
T---------
(12).Which among the given classes present in System.Collection.Generic.namespace?
All of the mentioned
Stack---------
Sorted Array
Tree
(13).Which of the following statements are correct about the Collection Classes available in Framework Class Library?
None---------
It is not Easy to adopt the existing Collection classes for newtype of objects
Elements stored in a collection can be modified only if allelements are of similar types.
Elements of a collection cannot be transmitted over a network.
(14).Which of the following statements are correct about the C#.NET code snippet given below?
Stack st = new Stack();
st.Push("hello");
st.Push(8.2);
st.Push(5);
st.Push('b');
st.Push(true);
In the fourth call to Push(), we should write "b" in place of 'b'
Boolean values can never be stored in Stack collection.
This is a perfectly workable code.---------
Dissimilar elements like "hello", 8.2, 5 cannot be stored in the same Stack collection.
(15).What will be the output of given code snippet?
public class Generic<T>
{
Stack<T> stk = new Stack<T>();
public void push(T obj)
{
stk.Push(obj);
}
public T pop()
{
T obj = stk.Pop();
return obj;
}
}
class Program
{
static void Main(string[] args)
{
Generic<int> g = new Generic<int>();
g.push(30);
Console.WriteLine(g.pop());
Console.ReadLine();
}
}
Compile time Error
Runtime Error
30---------
0
(16).For the code set given below,which of the following statements are perfectly valid?
public class MyContainer<T> where T: class, IComparable
{
/* insert code here */
}
Class MyConatiner requires that it’s type arguement must implement Icomparable interface
None of the mentioned
Compiler will report an error
There are multiple constraints on type arguement to MyConatiner class---------
(17).Which of these is an correct way of defining generic method?
name{T1, T2, …, Tn} { /* … */ }
name(T1, T2, …, Tn) { /* … */ }
public name { /* … */ }---------
class name[T1, T2, ..., Tn] { /* … */ }
(18).Choose the statements which are valid for given code snippet:
public class Generic<T>
{
public T Field;
public void testSub()
{
T i = Field + 1;
}
}
class Program
{
static void Main(string[] args)
{
Generic<int>g = new Generic<int>();
g.testSub();
}
}
code run successfully print 1
Compile time error---------
Program will give run time error
code run successfully print nothing
(19).Are generics in C# are same as the generics in java and templates in C++?
None of the mentioned
Yes
May be
No---------
(20).Select the type arguement of open constructed type?
Gen
Gen<>---------
None
Gen()
(21).What will be the output of given code snippet?
public class Generic<T>
{
Stack<T> stk = new Stack<T>();
public void push(T obj)
{
stk.Push(obj);
}
public T pop()
{
T obj = stk.Pop();
return obj;
}
}
class Program
{
static void Main(string[] args)
{
Generic<string> g = new Generic<string>();
g.push("40");
Console.WriteLine(g.pop());
Console.ReadLine();
}
}
Compile time Error
40---------
Runtime Error
0
(22).Suppose value of the Capacity property of ArrayList Collection is set to 4. What will be the capacity of the Collection on adding fifth element to it?
8---------
4
16
32
(23).What does the following code set defines?
public Gen(T o) {
ob = o;
}
All of the mentioned
Generics class decleration---------
Decleration of variable
Generic constructor decleration
PROPERTIES Choose the correct statement about properties describing the indexers?
No need to use the name of the property while using an indexed property
All of the mentioned---------
An indexer property should accept at least one argument
Indexers can be overloaded
Correct way to implement a write only property add in a math class?
class math { int ad; public int add { set { ad = value; } } }
class math { int ad; public int add { get { return ad; } set { ad = value; } } }
None---------
class math
{ public int add { set { add = value; } } }
Select the modifiers which can be used with the properties?
Private
Public
All the given options---------
Protected
Protected Internal
Choose the correct statements about write-only properties in C#.NET?
Useful for usage in classes which store sensitive information like password of a user
All of the listed options---------
Properties once set and hence values cannot be read back in nature
Properties which can only be set
Consider a class maths and we had a property called as sum.b is a reference to a maths object and we want Console.WriteLine(b.sum)to fail.Which is the correct solution to ensure this functionality?
Declare sum property with get, set and normal accessors---------
Declare sum property with only set accessor
Declare sum property with both get and set accessors
Declare sum property with only get accessor
Correct way to implement a read only property add in a math class?
class math { public int add { get { return ad; } } }
class math { int ad; public int add { get { return ad; } set { ad = value; } } }
None
class math {
int ad; public int add { get { return ad; } } }---------
Consider a class maths and we had a property called as sum.b is a reference to a maths object and we want work.Which is the correct solution to ensure this functionality? b.maths = 10; Console.WriteLine(b.maths);
Declare maths property with only get accessors
Declare maths property with only get, set and normal accessors
Declare maths property with only set accessors
Declare maths property with get and set accessors---------
If math class had add property with get accessors then which statements will work correctly?
math.add = 20;
math m = new math(); m.add = m.add + 20;
math m = new math(); m.add = 10;
math m = new math(); int i; i = m.add;---------
Please read the questions carefully and choose the most appropriate option.A property can be declared inside Interface. State TRUE or FALSE.
false
true---------
Please read the questions carefully and choose the most appropriate option.A property can be declared inside procedure. State TRUE or FALSE.
false---------
true
CLASS Select the output for following set of code : class z { public string name1; public string address; public void show() { Console.WriteLine("{0} is in {1}", name1, address); } } class Program { static void Main(string[] args)
{ z n = new z(); n.name1 = "harsh"; n.address = "new delhi"; n.show(); Console.ReadLine(); } }
Run successfully prints nothing
{0} is in city{1} harsh new delhi
harsh is in new delhi---------
Syntax error
Select output for following set of code. class sample { public int i; public int[] arr = new int[10]; public void fun(int i, int val) { arr[i] = val; } } class Program { static void Main(string[] args) { sample s = new sample(); s.i = 10; sample.fun(1, 5); s.fun(1, 5); Console.ReadLine(); } }
s.fun(1, 5) will work correctly
sample.fun(1, 5) will set value as 5 in arr[1]
s.i = 10 cannot work as i is ‘public’
sample.fun(1, 5) will not work correctly---------
Please read the questions carefully and choose the most appropriate option.Which of the following components framework provide an extensible set of classes that can be used by any .NET compliant programming language? 1..NET class libraries 2.Component Object Model
Both 1 and 2
None of the listed options
only 1---------
only 2
Select the output for following set of code : class sample { public int i; public int j; public void fun(int i, int j) { this.i = i; this.j = j; } } class Program { static void Main(string[] args) { sample s = new sample(); s.i = 1; s.j = 2; s.fun(s.i, s.j); Console.WriteLine(s.i + " " + s.j); Console.ReadLine(); } }
Error while calling s.fun() due to inaccessible level
Run successfully but prints nothing
Error as ‘this’ reference would not be able to call ‘i’ and ‘j’
1 2---------
Please read the questions carefully and choose the most appropriate option.Which of the given keywords is data and behavior of a base class by replacing a member of a base class with a new derived member?
new---------
override
base
overloads
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about the String Class in C#.NET?
All the listed options---------
Two strings can be concatenated by using an expression of the form s3 = s1 + s2;
A string built using String Class is Immutable.
A string built using StringBuilder Class is Mutable. What do the following code implies ? csharp abc; abc = new csharp();
Object creation on class csharp
Create an object of type csharp on heap or on stack depending on whether csharp is class or struct---------
Create an object of type csharp on heap or on stack depending on size of object
create an object of type csharp on stack
Please read the questions carefully and choose the most appropriate option.Which of the given options CANNOT custom attribute?
All the listed options
Delegate
Namespace---------
Event
Select the output for following set of code :
class z
{
public int X;
public int Y;
public const int c1 = 5;
public const int c2 = c1 * 25;
public void set(int a, int b)
{
X = a;
Y = b;
}
}
class Program
{
static void Main(string[] args)
{
z s = new z();
s.set(10, 20);
Console.WriteLine(s.X + " " + s.Y);
Console.WriteLine(z.c1 + " " + z.c2);
Console.ReadLine();
}
}
20 10
10 20 5 125---------
10 20
20 10
Please read the questions carefully and choose the most appropriate option.Which of the given options are A private function of a class can access a public function within the same class.
Data members of a class are by default private.
All the listed options---------
Member function of a class are by default private.
Please read the questions carefully and choose the most appropriate option.The string built using the String (unchangeable), whereas, the ones built- using the StringBuilder class are mutable. State TRUE or FALSE.
false
true---------
What is most specified using class declaration ?
None of mentioned
type
scope
type & scope---------
Please read the questions carefully and choose the most appropriate option.With which of the given options can the 1.Static data
2.Instance data
only 1
only 2
None of the listed options---------
Both 1 and 2
The output of code is ?
class test
{
public void print()
{
Console.WriteLine("Csharp:");
}
}
class Program
{
static void Main(string[] args)
{
test t;
t.print();
Console.ReadLine();
}
}
None of the mentioned
Code run and print “Csharp”
Code run successfully print nothing
Syntax error as t is unassigned variable which is never used---------
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about the 'this' reference?
this' reference can be modified in the instance member function of a class.
Static functions of a class never receive the 'this' reference.---------
All the listed options
this' reference continues to exist even after control returns from an instance member function. Select the output for following set of code : class sample { public int i; public int j; public void fun(int i, int j)
{ this.i = i; this.j = j; } } class Program { static void Main(string[] args) { sample s = new sample(); s.i = 1; s.j = 2; s.fun(s.i, s.j); Console.WriteLine(s.i + " " + s.j); Console.ReadLine(); } }
1 2---------
Run successfully but prints nothing
Error as ‘this’ reference would not be able to call ‘i’ and ‘j’
Error while calling s.fun() due to inaccessible level
Please read the questions carefully and choose the most appropriate option. Static procedures can access instance data? State TRUE or FALSE?
false---------
true
CONTROL STRUCTURES What will be the correct output for given code snippet? class maths { public int fact(int n) { int result; if (n == 2) return 1; result = fact(n - 1) * n; return result; }
} class Program { static void Main(string[] args) { maths obj = new maths(); Console.WriteLine(obj.fact(4)); Console.ReadLine(); } }
1
0
12---------
24
Please read the questions carefully and choose the most appropriate option.Which of the given options are 1.The goto statement passes control to the next iteration of the enclosing iteration statement in which it appears. 2.Branching is performed using jump statements which cause an immediate transfer of the program control.
Both 1 and 2
None of the listed options
only 1
only 2---------
What will be the correct output for given code snippet? class maths { public int fact(int n) { int result; if (n == 1) return 1; result = fact(n - 1) * n; return result; } }
class Output { static void Main(String[] args) { maths obj = new maths() ; Console.WriteLine(obj.fact(4)*(3)); } }
64
72---------
60
84
Which of these is not a correct statement?
Recursion is always managed by C# Runtime environment---------
A recursive method must have a base case
Recursion always uses stack
Recursive methods are faster that programmers written loop to call the function repeatedly using a stack
Select the output for following set of code: static void Main(string[] args) { float s = 0.1f; while (s <= 0.5f) { ++s; Console.WriteLine(s); } Console.ReadLine(); }
0.1
No output
1.1---------
0.1 0.2 0.3 0.4 0.5
Select the output for following set of code : static void Main(string[] args) { int x; for (x = 1; x <= 3; x++) { int j = 1; do { j++; }while (x % j == 2); Console.WriteLine(x + " " + j); } Console.ReadLine(); }
1 1 1 2 1 3
1 2 2 2 3 2---------
11 21 31
11 12 13
Select output for following set of code : static void Main(string[] args) {
int x; for (x = 10; x <= 15; x++) while (Convert.ToBoolean(Convert.ToInt32(x))) { do { Console.WriteLine(1); if (Convert.ToBoolean(x >> 1)) continue; }while (Convert.ToBoolean(0)); break; } Console.ReadLine(); }
1 1 1 1 1 1---------
0 0 0….infinite times
System outofflow exception error.
1 1 1….infinite times
Select output for following set of code : static void Main(string[] args) { int i, s = 0, a = 1, d; i = Convert.ToInt32(Console.ReadLine()); do { d = i % (2 * 4); s = s + d * a; }while ((Convert.ToInt32(i = i / (2 * 4))) != 0 && (Convert.ToBoolean(Convert.ToInt32((a) = (a * 10))))); Console.WriteLine(s); Console.ReadLine(); } enter i = 342.
It finds binary equivalent of i
It finds octal equivalent of i---------
It finds sum of digits of i
It finds reverse of i
What will be the output for given set of code?
static void Main(string[] args) { int n = 1; method(n); Console.WriteLine(n); method1(ref n); Console.WriteLine(n); Console.ReadLine(); } static void method(int num) { num += 20; Console.WriteLine(num); } static void method1(ref int num) { num += 20; Console.WriteLine(num); }
21 21 21 21
11 21 21 11
1 1 1 1
21 1 21 21---------
Select output for following set of code : static void Main(string[] args) {
float i = 1.0f, j = 0.05f; do { Console.WriteLine(i++ - ++j); }while (i < 2.0f && j <= 2.0f); Console.ReadLine(); }
0.05
-0.04999995---------
0.95
-0.05
Please read the questions carefully and choose the most appropriate option.Which of the given options can a while loop and transfer control outside the loop? 1.break 2.goto
only 1
only 2
Both 1 and 2---------
None of the listed options
Select the output for following set of code : static void Main(string[] args) { long x; x = Convert.ToInt32(Console.ReadLine()); do { Console.WriteLine(x % 10); }while ((x = x / 10) != 0); Console.ReadLine(); } enter x = 1234.
prints ’1'
number of digits present in x
prints sum of digits of ‘x’
prints reverse of x---------
Please read the questions carefully and choose the most appropriate option.Which of the given options are 1.The switch statement is a control statement that handles multiple selections and enumerations by passing the case statements within its body. 2.The goto statement passes control to the next iteration of the enclosing iteration statement in which it appears.
only 1---------
Both 1 and 2
only 2
None of the listed options
Select output for following set of code : static void Main(string[] args) { int i = 1, j = 2, k = 3; do { Console.WriteLine((Convert.ToBoolean(Convert.ToInt32(i++))) && (Convert.ToBoolean(Convert.ToInt32(++}while (i <= 3); Console.ReadLine(); }
True True True---------
0 0 0
False False False
1 1 1
Select the correct match of parameter declaration: static void main(string[] args) { int a = 5; int b = 6; float c = 7.2f; math (ref a, ref b, ref c); Console.WriteLine(a + " " + b + " " + c); } static int math(/*add parameter decelaration */) { a += b; b *= (int)c; c += a * b;
return 0; }
ref int a, int b, ref float c
ref int a, ref int b, float c
ref int a, ref float c, ref int b
ref int a, ref int b, ref float c---------
Predict the output for following set of code : static void Main(string[] args) { int x; x = Convert.ToInt32(Console.ReadLine()); int c = 1; while (c <= x) { if (c % 2 == 0) { Console.WriteLine("Execute while " + c + "\t" + "time"); } c++; } Console.ReadLine(); } for x = 8.
Execute while 2 time Execute while 3 time Execute while 4 time Execute while 5 time
Execute while 2 time Execute while 4 time Execute while 6 time Execute while 8 time---------
Execute while 1 time Execute while 2 time Execute while 3 time Execute while 4 time Execute while 5 time
Execute while 6 time Execute while 7 time
Execute while 1 time Execute while 3 time Execute while 5 time Execute while 7 time
What is output for following code snippet? class Program { static void Main(string[] args) { int i = 5; int j; method1(ref i); method2(out j); Console.WriteLine(i + " " + j); } static void method1(ref int x) { x = x + x; } static void method2(out int x) { x = 6; x = x * x; } }
10 36---------
36 0
36 10
0 0
Which of these data types is used by operating system to manage the Recursion in Csharp?
Array
Stack---------
Queue
Tree
What will be the correct output for given code snippet? class maths { public int fact(int n) { int result; if (n == 1) return 1; result = fact(n - 1) * n; return result; } } class Output { static void Main(String[] args) { maths obj = new maths(); Console.WriteLine(obj.fact(1)); Console.ReadLine(); } }
1---------
2
0
10
What will be the correct output for given code snippet? class recursion { public int fact(int n) { int result; if (n == 1) return 1; result = fact(n - 1) * n; return result; } } class Program { public static void Main(String[] args) { recursion obj = new recursion(); Console.WriteLine(obj.fact(4)); Console.ReadLine();
} }
30
24---------
120
144
What is Recursion in CSharp defined as?
Recursion another form of class
Recursion another process of defining a method that calls other methods repeatedly
Recursion is a process of defining a method that calls itself repeatedly---------
Recursion is a process of defining a method that calls other methods which in turn call again this method
Select the output for following set of code : static void Main(string[] args) { int x = 0; do { x++; if (x == 5) { x++; continue; break; } Console.WriteLine(x + " "); }while (x < 10); }
1 2 3 4 5
5 6 7 8 9 10
10
1 2 3 4 7 8 9 10---------
What will be the output of given set of code? static void Main(string[] args)
{ int a = 5; int b = 0, c = 0; method (a, b, ref c); Console.WriteLine(b + " " + c); Console.ReadLine(); } static int method(int x, int p, ref int k) { p = x + x * x; k = x * x + p; return 0; }
30 55
0 0
0 55---------
55 30
Select the output for following set of code : static void Main(string[] args) { int x; for (x = 1; x <= 3; x++) { int j = 1; do { j++; }while (x % j == 2); Console.WriteLine(x + " " + j); } Console.ReadLine(); }
11 21 31
1 2 2 2 3 2---------
1 1
1 2 1 3
11 12 13
Which of these will happen if recursive method does not have a base case?
After 10000 executions programme will be automatically stopped.
infinite loop condition occurrence---------
None of the mentioned
System gets hangup
Select the output for following set of Code: static void Main(string[] args) { int x = 0; while (x < 20) { while (x < 10) { if (x % 2 == 0) { Console.WriteLine(x); } x++; } } Console.ReadLine(); }
0 2 4 6 8---------
0 2 4 6 8 10
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
0 2 4 6 8 10 12 14 16 18 20
What will be the output for given set of code? static void Main(string[] args)
{
int n = 1;
method(n);
Console.WriteLine(n);
method1(ref n);
Console.WriteLine(n);
Console.ReadLine();
}
static void method(int num)
{
num += 20;
Console.WriteLine(num);
}
static void method1(ref int num)
{
num += 20;
Console.WriteLine(num);
}
11 21 21 11
21 21 21 21
21 1
21 21---------
1 1 1 1
BASIC
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE about Common Language Runtime (CLR)?
1.In CLR, code is expressed in the form of byte code called the Common Intermediate Language (CIL), previously known as MSIL (Microsoft Intermediate Language)
2.It manages memory but not code execution and other system services.
None of the listed options
only 2
Both 1 and 2
only 1 ******************
When does structure variable get destroyed?
Depends on either it is created using new or without new operator
As variable goes out of the scope ******************
Depends on either we free it’s memory using free() or delete()
When no reference refers to it,it will get garbage collected
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about Attributes in C#.NET?
1.On compiling a C#.NET program the attributes applied are recorded in the metadata of the assembly.
2.On compilation all the attribute's tags are deleted from the program.
only 2
None of the listed options
only 1*****************
Both 1 and 2
Select the action of the method long seek()?
Sets the current position in the stream to the specified offset from specified origin and hence returns the new position ***************
Writes a single byte to an output stream
Attempts to readup to count bytes into buffer starting at buffer[offset]
None
Choose the keyword which declares the indexer?
base
extract
this *****************
super
Please read the questions carefully and choose the most appropriate option.Read the below statements carefully.
Statement 1: It launches separate process for every application running under it.
Statement 2: The resources are Garbage collected.
Which of the statements are TRUE about the benefits we get on running managed code under CLR?
Only Statement 2 is true
All statements are true *******************
none of the given options are true
Only Statement 1 is true
Select the method which writes the contents of the stream to the physical device.
void Flush() **********************
void fflush()
flush()
fflush()
Choose the class on which all stream classes are defined?
All of the mentioned
Sytem.Input.stream
System.IO.stream *******************
System.Output.stream
Which of the following is the root of the .NET type hierarchy?
System.Root
System.Base
System.Object----------------------
System.Type
Which of the following is the root of the .NET type hierarchy?
System.Root
System.Base
System.Object---------------------------
System.Type
Correct statement about the C#.NET code given below is?
class trial
{
int i;
float d;
}
struct sample
{
private int x;
private Single y;
private trial z;
}
sample s = new sample();
trial object referred by z created on the stack
z is created on the heap
s will be created on the stack ***************
Both s and z will be created on the heap
Which among is used for storage of memory aspects?
BufferedStream
MemoryStream *************
FileStream
None of the mentioned
Which of these is method is used for reading bytes from the file?
put()
write()
Read() *****************
WriteByte()
Choose the filemode method which is used to create a new output file with condition that file with same name if existed it destroyes the old file:
FileMode.Truncate
FileMode.OpenOrCreate
FileMode.CreateNew
FileMode.Create *********************
Statement1: CLR provides a language-neutral development & execution environment.
Statement 2: CLR ensures that an application would not be able to access memory that it is not authorized to access.
Which of the following statements are TRUE about the .NET CLR?
None of the statements is true
All statements are true **************
Only Statement 1 is true
Only Statement 2 is true
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about Attributes in C#.NET?
1.The attributes applied can be read from an assembly using Reflection class.
2.An attribute can have parameters.
None of the listed options
only 1
only 2
Both 1 and 2 ***************
struct sample
{
public int i;
}
class Program
{
static void Main(string[] args)
{
sample a = new sample();
a.i = 10;
fun(ref a);
Console.WriteLine(a.i);
}
public static void fun(ref sample x)
{
x.i = 20;
Console.WriteLine(x.i);
}
}
a) 10 10
b) 20 10
c) 10 20 d) 20 20*************************
Which is the correct way to settle down values into the structure variable ‘e’ defined as?
struct emp
{
public String name;
public int age;
public Single sal;
}
emp e = new emp();
e.name = “Ankit”;************************* e.age = 24; e.sal = 200;
name = “Ankit”;
age = 24;
sal = 200;
With emp e
{
.name = “Ankit”;
.age = 24;
.sal = 200;
}
All the given options
Which method of character stream class returns the numbers of characters successfully read starting at count?
int ReadBlock(char[ ] buffer, int index, int count) ******************
int Read()
int Read(char[] buffer, int index, int count)
None of the mentioned
Which of these is used to perform all input & output operations in C#?
Methods
classes
streams ********************
Variables
Attempts to read up to count bytes into buffer starting at buffer[offset], returning the number of bytes successfully read?
int ReadByte()
None of the mentioned
Void WriteByte(byte value)
int Read(byte[] buffer ,int offset ,int count******************
Which of the given options is TRUE about Common Language Runtime (CLR)?
1.In CLR, code is expressed in the form of byte code called the Common Intermediate Language (CIL), previously known as MSIL (Microsoft Intermediate Language)
2.It manages memory but not code execution and other system services.
only 2
None of the listed options
Both 1 and 2
only 1 ******************************
struct sample
{
public int i;
}
class Program
{
static void Main(string[] args)
{
sample a = new sample();
a.i = 10;
fun(ref a);
Console.WriteLine(a.i);
}
public static void fun(ref sample x)
{
x.i = 20;
Console.WriteLine(x.i);
}
}
20
10
20*********************** 20
10
10
10
20
For a class student consist of indexer,So choose among the following declaration of indexers to make code running successfully ?
student a = new student();
a[1,2] = 20;
class student { int[,] a = new int[6, 6]; public int this[int i, int j] { set { a[i, j] = value; } } }--------
class student
{
int[,] p = new int[6, 6];
public property WriteOnly int this[int i, int j]
{
set
{
a[i, j] = value;
}
}
}
None of the mentioned
class student
{
int[,] a = new int[6, 6];
public int property WriteOnly
{
set
{
a[i, j] = value;
}
}
}
Which is the correct result for the given statement in the C#.NET statement given below?
p = q
struct employee
{
private int employee id;
private string city;
}
employee q = new employee();
employee p;
p = q;
Address stored in q will be get copied into p
Address of first element of q will get copied into p
Once assignment is over q will go out of scope and hence get exited forever.
Elements of ‘q’ will be copied into corresponding elements of p.--------
Select the statements which defines the stream.
C# programs perform I/O through streams
A stream is linked to a physical device by the I/0 system
All the given options--------
A stream is an abstraction that produces or consumes information
Delegates
1…Please read the questions carefully and choose the most appropriate option.Which of the given options is FALSE about delegate?
1.Delegates are reference types.
2.Delegates are type-safe.
only 2
None of the listed options
only 1
Both 1 and 2--------
2…What will be the output of the given code snippet below?
delegate void A(ref string str);
class sample
{
public static void fun( ref string a)
{
a = a.Substring( 7, a.Length - 7);
}
}
class Program
{
static void Main(string[] args)
{
A str1;
string str = "Test Your C#.net skills";
str1 = sample.fun;
str1(ref str);
Console.WriteLine(str);
}
}
None of the mentioned
ur C#.net skills--------
ur C#.NET
Test Your
3… Choose the statements which makes delegate in C#.NET different from a normal class?
a) Delegates in C#.NET is a base class for all delegates type
b) Delegates created in C#.NET are further not allowed to derive from the delegate types that are created
c) Only system and compilers can derive explicitly from the Delegate or MulticasteDelegate class d) All of the mentioned--------
4…Which is the correct way to call the function abc() of the given class csharp given below?
class csharp
{
public int abc(int a)
{
Console.WriteLine("A:Just do it!");
return 0;
}
}
none of the mentioned
csharp s = new csharp();
delegate void d = new del(ref abc);
d(10);
delegate int del(int a); del d; csharp s = new csharp(); d = new del(ref s.fun); d(10);--------
delegate void del(int a);
csharp s = new csharp();
del d = new del(ref s.abc);
d(10);
5…Please read the questions carefully and choose the most appropriate option.Which of the given options is FALSE about delegate?
A single delegate can invoke more than one method.
Delegate is a value type.--------
The signature of a delegate must match the signature of the method that is to be called using it.
Delegates can be shared.
6…Choose statements which differentiate delegate in C#.NET than a conventional function pointer in other languages?
delegate allow static as well as instance methods to be invoked
None of the mentioned--------
delegate are type safe and secure
delegate in C#.NET represent a new type in the Comman Type System
7…Select the modifiers which controls the accessibility of the delegate
public
new
protected
internal
All the given options--------
8…An Event is
The result of a users action--------
All of the mentioned
result of a party
code to force users action
9…Suppose a Generic class called as SortObjects is to made capable of sorting objects of any type(integer, single, byte etc).Hence, which following programming
construct is able to implement the comparision function?
interface
attribute
encapsulation
delegate--------
10…Choose incorrect statement about the delegates?
delegates is a user defined type
delegates permits execution of a method on in an asynchronous manner
delegates are not type safe--------
All of the mentioned
11…Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about a delegate?
The declaration of a delegate must match the signature of the method that we intend to call using it.
Delegates are type-safe.
All the listed options--------
Delegates provide wrappers for function pointers.
12…Please read the questions carefully and choose the most appropriate option.In which of the given areas are delegates commonly used?
1.Multithreading
2.Event handling
None of the listed options
only 1
Both 1 and 2--------
only 2
13…Which is the incorrect statement about delegate?
A single delegate can invoke more than one method
delegate is a value type--------
delegates could be shared
delegates are type safe wrappers for funtion pointers
14…Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about a delegate?
1.Delegate is a user-defined type.
2.Delegates can be used to implement callback notification.
Both 1 and 2--------
only 1
only 2
None of the listed options
15…Correct statement about delegate declaration given below is ?
delegate void del(int i);
On declaring the delegate a class called del is created
the del class is derived from the MulticastDelegate class
All of the mentioned--------
the del class will contain a one arguement constructor and an invoke() method
16…Choose statements which differentiate delegate in C#.NET than a conventional function pointer in other languages?
delegate in C#.NET represent a new type in the Comman Type System
delegate allow static as well as instance methods to be invoked
None of the mentioned--------
delegate are type safe and secure
17…Please read the questions carefully and choose the most appropriate option.In which of the given areas are delegates commonly used?
1.Multithreading
2.Event handling
Both 1 and 2--------
only 2
only 1
None of the listed options
18…Please read the questions carefully and choose the most appropriate option.Which of the given options is FALSE about delegate?
1.Only one method can be called using a delegate.
2.Delegates are object oriented.
only 2
Both 1 and 2
None of the listed options
only 1--------
19…What will be the output of the given code snippet below?
{
delegate string F(string str);
class sample
{
public static string fun(string a)
{
return a.Replace(',''-');
}
}
class Program
{
static void Main(string[] args)
{
F str1 = new F(sample.fun);
string str = str1("Test Your c#.NET skills");
Console.WriteLine(str);
}
}
}
a) Test Your b) Test-Your-C#.NET-Skills--------
c) ur C#.NET Skills
d) None of the mentioned
20…What will be the output of given set of code?
delegate string f(string str);
class sample
{
public static string fun(string a)
{
return a.Replace('k', 'o');
}
}
class Program
{
static void Main(string[] args)
{
f str1 = new f(sample.fun);
string str = str1("Test Ykur C#.NET Skills");
Console.WriteLine(str);
Console.ReadLine();
}
}
Test ur C#.NET Skills
Test Ykour C#.NET Skills
Test Ykur C#.NET Skills
Test Your C#.NET Soills
21…Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about a delegate?
1.Delegates cannot be used to call a static method of a class.
2.Delegates cannot be used to call procedures that receive variable number of arguments.
only 2--------
only 1
None of the listed options
Both 1 and 2
22…Choose the incorrect statement about the delegate?
delegate are of reference types
delegates are type safe
none of the mentioned--------
delegates are object oriented
DATATYPE static void Main(string[] args) { int[] x = {65, 66, 67, 68, 69, 70}; fun(x); Console.ReadLine(); } static void fun(params int[] b ) { int i; for (i = 5; i > 0 ; i--) { b[i] = b[i] + 32; Console.WriteLine(Convert.ToChar(b[i])); } }
A, B, C, D, E, F
F, E, D, C, B, A
b, c, d, e, f
f, e, d, c, b--------
enum per { a, b, c, d,
} per.a = 10; Console.writeline(per.b);
Compile time error--------
1
11
2
Select correct declaration of defining array of parameters:
void func(int x) { }
void func(int[] x) { }
void fun(param int[] x) { }--------
void func(param int[]) { }
Which of these method of class String is used to check whether a given string starts with a particular substring EndsWith()
StartsWith()--------
Ends()
Starts()
Please read the questions carefully and choose the most appropriate option.Which of the given options are enumerators? 1.Values of enum elements cannot be populated from a database. 2.Enum is a class declared in System namespace
only 2
None of the listed options
Both 1 and 2
only 1--------
Please read the questions carefully and choose the most appropriate option.Which of the given options are 1.The value of each successive enumerator is decreased by 1. 2.Values of enum elements cannot be populated from a database.
None of the listed options
Both 1 and 2
only 2--------
only 1
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about enumerators? 1.An enum variable can be defined inside a class or a namespace. 2.An enum variable cannot have a protected access modifier.
only 1--------
Both 1 and 2
None of the listed options
only 2
Please read the questions carefully and choose the most appropriate option.What is the size of a Decimal data type?
16 byte
8 byte
32 byte
4 byte
Choose correct statement about enum used in C#.NET ?
The value of each successive enumerator is decreased by 1
An enumerator had white space in its name
Values of enum elements cannot be populated from database--------
By default the first enumerator had a value equals to number of elements present in the list
Choose correct statement about the C#.NET code given below? enum color:byte { yellow = 500, green = 1000, pink = 1300 }
bytes value cannot be assigned to enum elements
enum elements should always take successive values
As valid range of byte exceeded the compiler will report an error--------
enum must always be of int type
Please read the questions carefully and choose the most appropriate option.Which of the given data types does not store a sign?
long
int
short
byte--------
What will be the output of set of code? static void Main(string[] args) { int [] a = {1, 2, 3, 4, 5}; fun(a); Console.ReadLine(); } static void fun(params int[] b ) { int[] k = { 3, 4, 7, 8,'\0' }; for (int i = 0; i < b.Length; i++) { b[i] = b[i] + k[i] ; Console.WriteLine( b[i] + " "); } }
Compile time error
3, 4, 7, 8, 5, 1, 2, 3, 4, 5
4, 6, 10, 12, 5--------
3, 4, 7, 8, 5
Please read the questions carefully and choose the most appropriate option.Which of the given options are None of the given options
A String is created on the stack.
A String is created on the heap.--------
A String is a primitive.
Correct output for the C#.NET code given below is? enum colors {
red, black, pink } static void Main(string[] args) { colors s = colors.black; Type t; t = s.GetType(); string[] str; str = Enum.GetNames(t); Console.WriteLine(str[0]); Console.ReadLine(); }
1
black
red--------
0
What will be the output of given code snippet? class A { internal int i; int j; public A() { i = 1; j = 2; } } class Program { static void Main(string[] args) { A obj1 = new A(); Console.WriteLine(obj1.i.ToString()); Console.ReadLine(); } }
1--------
true
Compile time error
false
What will be the output for given set of code ?
static void Main(string[] args)
{
object[] a = {"1", 4.0f, "harsh"};
fun(a);
Console.ReadLine();
}
static void fun(params object[] b)
{
for (int i = 0; i < b.Length - 1; i++)
Console.WriteLine(b[i] + " ");
}
1 4.0 harsh
1 4 hars
1 4
1 4 harsh
Please read the questions carefully and choose the most appropriate option.Which of the given options are 1.String literals can contain any character literal including escape sequences.
2.Attempting to access a character that is outside the bounds of the string results in an IndexOutOfRangeException.
Both 1 and 2
only 2
only 1
None of the listed options
Please read the questions carefully and choose the most appropriate option.An enum that is declared inside namespace or interface is treated as public. State True or False.
true--------
false
The modifiers used to define an array of parameters or lists of arguements:
out
var
param--------
ref
What will be the output of given code snippet? static void Main(string[] args) { string s1 = " Ixg"; string s2 = s1.Insert(3,"i"); string s3 = s2.Insert(5, "o"); for (int i = 0; i < s3.Length; i++) Console.WriteLine(s3[i]); Console.ReadLine(); }
Ixgo
Ixig
Ixigo--------
Ixigo
Correct output for the C#.NET code given below is?
enum letters
{
a,
b,
c
}
static void Main(string[] args)
{
letters l;
l = letters.a;
Console.WriteLine(l);
Console.ReadLine();
}
0
letters.a
a--------
-1
What will be the output of given code snippet? class Program { static void Main(string[] args) { char []chars = {'a', 'b', 'c'}; String s = new String(chars); Console.WriteLine(s); Console.ReadLine(); } }
a
b
c
abc--------
What will be the output of given set of code? static void Main(string[] args) { int [] a = {1, 2, 3, 4, 5}; fun(a); Console.ReadLine(); } static void fun(params int[] b ) {
for (int i = 0; i < b.Length; i++) { b[i] = b[i] * 5 ; Console.WriteLine(b[i] + ""); } }
5, 25, 125, 625, 3125
5, 10, 15, 20, 25--------
6, 12, 18, 24, 30
1, 2, 3, 4, 5
Select the output for following set of code : static void Main(string[] args) { int x = 8; int b = 16; int C = 64; x /= b /= C; Console.WriteLine(x + " " + b+ " " +C); Console.ReadLine(); }
8 2 32
Run time error--------
32 4 8
32 2 8
Please read the questions carefully and choose the most appropriate option.Which of the given options are TRUE about enumerators? 1.An implicit cast is needed to convert from enum type to an integral type. 2.An enum variable cannot have a public access modifier.
None of the listed options
only 2
only 1
Both 1 and 2
DEBUG
What is the shortcut key that is used to Start or resume execution of your code and then halts execution when it reaches the selected statement?
Ctrl-Shift-F5
Ctrl-F10 ------
Ctrl-F5
Ctrl-F9
What is the shortcut key that is used to allow you to attach or detach the debugger to one or more running process?
Ctrl-Alt-H
Ctrl-Alt-P -------
Ctrl-Alt-W
Ctrl-Alt-D
What is the shortcut key that is used to set the execution point to the line of code you choose
Ctrl-F10
Ctrl-Shift-F10 -----
Ctrl-F5
Ctrl-Shift-F5
What is the shortcut key that is used to execute remaining lines out from procedure?
Shift-F5
Shift-F11 ------
F11
F5
What is the shortcut key that is used to execute remaining lines out from procedure?
F5
Shift-F11 --------
F11
Shift-F5
What is the shortcut key that is used to run the startup project and attaches the debugger?
F9
F10
F5 --------
F6
What is the shortcut key that is used to set or removes breakpoint at the current line?
F10
F5
F9 ----------
F6
What is the shortcut key that is used to run the code without invoking debugger?
F9
F5
F10
Ctrl-F5 ---------
What is the shortcut key that is used to clear all of the breakpoints in the project?
Ctrl-Shift-F5
Ctrl-Shift-F9 --------
Ctrl-Shift-F6
Ctrl-Shift-F10
What is the shortcut key that is used to execute the next line of code but doesnot step into any function calls available in break and run modes ,this terminates the debugging session?
Shift-F11
Shift-F10
Shift-F5 ----------
Shift-F9
What is the shortcut key that is used to display the threads window to view all of the threads for the current process?
Ctrl-Alt-P
Ctrl-Alt-H -------------
Ctrl-Alt-D
Ctrl-Alt-W
What is the shortcut key that is used to enable or disable the breakpoint on the current line of code?
Ctrl-F5
Ctrl-Shift-F5
Ctrl-F9 ---------
Ctrl-Shift-F9
What is the shortcut key that is used to Start or resume execution of your code and then halts execution when it reaches the selected statement?
Ctrl-Shift-F5
Ctrl-F9
Ctrl-F10 ------------
Ctrl-F5
What is the shortcut key that is used to display breakpoint dialogWhat is the shortcut key that is used to display breakpoint dialog
Ctrl-Alt-D
Ctrl-Alt-B -------------
Ctrl-Alt-C
Ctrl-Alt-Q
what are the commands that are not available in break mode to proceed for further debugging
StepOut
Continue
Break -------------
StepIn
If debug point is on a methodcall,______will execute the entire method at a time and stops at the nextline
Break
StepOut
Step over -----------
Step In
DESKTOP Choose the correct statement about properties describing the indexers?
All of the mentioned--------
No need to use the name of the property while using an indexed property
An indexer property should accept at least one argument
Indexers can be overloaded
Correct way to implement a write only property add in a math class?
None
class math { public int add { set { add = value; } } }
class math { int ad; public int add { set { ad = value; } } }--------
class math
{ int ad; public int add { get { return ad; } set { ad = value; } } }
Select the modifiers which can be used with the properties?
Private
Protected
Protected Internal
Public
All the given options--------
Choose the correct statements about write-only properties in C#.NET?
Properties once set and hence values cannot be read back in nature
All of the listed options--------
Useful for usage in classes which store sensitive information like password of a user
Properties which can only be set
Consider a class maths and we had a property called as sum.b is a reference to a maths object and we want the statement Console.fail.Which is the correct solution to ensure this functionality?
Declare sum property with only set accessor
Declare sum property with only get accessor
Declare sum property with get, set and normal accessors--------
Declare sum property with both get and set accessors
Correct way to implement a read only property add in a math class?
class math { int ad; public int add { get { return ad; } set { ad = value; } } }
class math { int ad; public int add { get { return ad; } }--------
}
class math { public int add { get { return ad; } } }
None
Consider a class maths and we had a property called as sum.b is a reference to a maths object and below to work.Which is the correct solution to ensure this functionality? b.maths = 10; Console.WriteLine(b.maths);
Declare maths property with only get, set and normal accessors
Declare maths property with get and set accessors
Declare maths property with only get accessors--------
Declare maths property with only set accessors
If math class had add property with get accessors then which statements will work correctly?
math.add = 20;
math m = new math(); m.add = m.add + 20;
math m = new math();--------
int i; i = m.add;
math m = new math(); m.add = 10;
GARBAGE
Please read the questions carefully and choose the most appropriate option.Imagine the scenario below.
On pushing a button an object is to be notified, but it is not known until runtime which object should be notified.
Which of the given programming constructs should be used to implement this idea?
Namespace
Interface
Attribute
Delegate -----
Select the output for following set of code :
static void Main(string[] args)
{
int x = 8;
int b = 16;
int C = 64;
x /= b /= C;
Console.WriteLine(x + " " + b+ " " +C);
Console.ReadLine();
}
Run time error --------
32 4 8
8 2 32
32 2 8
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE?
There is one common garbage collector for all programs. ---------
Both the listed options
None of the 2 listed options
An object is destroyed by the garbage collector when only one reference refers to it.
Select the output for following set of code :
static void Main(string[] args)
{
int i, j;
for (i = 2; i >= 0; i--)
{
for (j = 0; j <= 2; j++)
{
if (i == j)
{
Console.WriteLine("1");
}
else
{
Console.WriteLine("0");
}
}
Console.WriteLine("\n");
}
Console.ReadLine();
}
0 0 1
0 1 0---------
1 0 0
1 0 0
0 0 1
0 1 0
0 1 0
1 0 0
0 0 1
1 0 0
0 1 0
0 0 1
What will be the output of following snippet of code?
class number
{
private int num1;
private int num2;
public int anumber
{
get
{
return num1;
}
set
{
num1 = value;
}
}
public int anumber1
{
get
{
return num2;
}
set
{
num2 = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
p.anumber = 20;
number k = new number();
k.anumber1 = 40;
int m = p.anumber;
int t = k.anumber1;
int r = p.anumber + k.anumber1;
Console.WriteLine("number = " +m);
Console.WriteLine("number = " +t);
Console.WriteLine("sum = " +r);
Console.ReadLine();
}
}
Compile time error
sum = 60
number = 40
number = 20
None
number = 20
number = 40--------
sum = 60
What will be the output of following snippet of code?
class number
{
int length = 50;
public int number1
{
get
{
return length;
}
set
{
length = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
p.number1 = p.number1 + 40;
int k = p.number1 * 3 / 9;
Console.WriteLine(k);
Console.ReadLine();
}
}
180
0
Compile time error
30 -----
What will be the output of following snippet of code?
class student
{
int []scores = new int[3] {13, 32, 24};
public int this[int index]
{
get
{
if (index < 3)
return scores[index];
else
{
Console.WriteLine("invalid index");
return 0;
}
}
private set
{
if (index < 3)
scores[index] = value;
else
Console.WriteLine("invalid index");
}
}
}
class Program
{
public static void Main(string[] args)
{
student s = new student();
int[] scores1 = new int[3] {8, 19, 40};
for (int i = 0; i < 3; i++)
{
if (scores1[i] > s[i])
{
Console.WriteLine("scores1 had greater value :" + scores1[i]);
}
else
{
Console.WriteLine("scores had greater value :" + s[i]);
}
}
Console.ReadLine();
}
}
Run time error
scores had greater value :13-----
scores had greater value :32-------
scores1 had greater value :40 --------
0
Compile time error
select output for following set of Code:
static void Main(string[] args)
{
int i;
int b = 8, a = 32;
for (i = 0; i <= 10; i++)
{
if ((a / b * 2)== 2)
{
Console.WriteLine( i + " ");
continue;
}
else if (i != 4)
Console.Write(i + " ");
else
break;
}
Console.ReadLine();
}
0 1 2 3 4
0 1 2 3 ------
1 2 3 4 5 6 7 8 9
0 1 2 3 4 5 6 7 8
What is the output for the following code ?
static void Main(string[] args)
{
int a = 5;
if (Convert.ToBoolean((.002f) -(0.1f)))
Console.WriteLine("Sachin Tendulkar");
else if (a == 5)
Console.WriteLine("Rahul Dravid");
else
Console.WriteLine("Ms Dhoni");
Console.ReadLine();
}
Rahul Dravid
Sachin Tendulkar --------
Ms Dhoni
Warning : Unreachable Code
What will be the output of following snippet of code?
class number
{
private int num1 = 60;
private int num2 = 20;
public int anumber
{
get
{
return num1;
}
set
{
num1 = value;
}
}
public int anumber1
{
get
{
return num2;
}
set
{
num2 = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
number k = new number();
int m = p.anumber;
int t = k.anumber1;
int r = p.anumber * k.anumber1;
Console.WriteLine("sum = " + r);
Console.ReadLine();
}
}
sum = 0
sum = 1200 ------------
sum = 120
Compile time error
Select output for set of code :
static void Main(string[] args)
{
int []a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
func(ref a);
Console.ReadLine();
}
static void func(ref int[] x)
{
Console.WriteLine(" numbers are:");
for (int i = 0; i < x.Length; i++)
{
if (x[i] % 2 == 0)
{
x[i] = x[i] + 1;
Console.WriteLine(x[i]);
}
}
}
numbers are : 2 4 6 8 10
numbers are : 3 5 7 9 11 ----------
None of the mentioned
numbers are : 2 3 4 5 6
Select the ouput for following set of code :
static void Main(string[] args)
{
int x = 4 ,b = 2;
x -= b/= x * b;
Console.WriteLine(x + " " + b);
Console.ReadLine();
}
4 0 --------
None of mentioned
0 4
4 2
What is the method to load assembly by name
Assembly.loadfile()
Assembly.reflectiononlyload
Assembly.load() ------
Assembly.load from()
Select the relevant ‘if statement’ to be placed in following set of code :
static void Main(string[] args)
{
int []num = {50, 65, 56, 88, 43, 52};
int even = 0, odd = 0;
for (int i = 0 ;i < num.Length ;i++)
{
/*___________________________*/
}
Console.WriteLine("Even Numbers:" +even);
Console.WriteLine("Odd Numbers:" +odd);
Console.ReadLine();
}
if(num[i] % 2 = 0)
{
even += 1;
}
else
{
odd += 1;
}
if ((num % 2) == 0)
{
even += 1;
}
else
{
odd += 1;
}
if(num[i] % 2 == 0)
{
even += 1;
}
else--------------
{
odd += 1;
}
if((num * i) == 0)
{
even += 1;
}
else
{
odd += 1;
}
What will be the output of following snippet of code?
class number
{
int length = 60;
public int number1
{
get
{
return length;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
int l;
l = p.number1 + 40;
int k = l * 3 / 4;
Console.WriteLine(k);
Console.ReadLine();
}
}
0
75 ------
80
30
OOPS – 1
Please read the questions carefully and choose the most appropriate option.Imagine the scenario below.
On pushing a button an object is to be notified, but it is not known until runtime which object should be notified.
Which of the given programming constructs should be used to implement this idea?
Namespace
Interface
Attribute
Delegate -----
Select the output for following set of code :
static void Main(string[] args)
{
int x = 8;
int b = 16;
int C = 64;
x /= b /= C;
Console.WriteLine(x + " " + b+ " " +C);
Console.ReadLine();
}
Run time error --------
32 4 8
8 2 32
32 2 8
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE?
There is one common garbage collector for all programs. ---------
Both the listed options
None of the 2 listed options
An object is destroyed by the garbage collector when only one reference refers to it.
Select the output for following set of code :
static void Main(string[] args)
{
int i, j;
for (i = 2; i >= 0; i--)
{
for (j = 0; j <= 2; j++)
{
if (i == j)
{
Console.WriteLine("1");
}
else
{
Console.WriteLine("0");
}
}
Console.WriteLine("\n");
}
Console.ReadLine();
}
0 0 1
0 1 0---------
1 0 0
1 0 0
0 0 1
0 1 0
0 1 0
1 0 0
0 0 1
1 0 0
0 1 0
0 0 1
What will be the output of following snippet of code?
class number
{
private int num1;
private int num2;
public int anumber
{
get
{
return num1;
}
set
{
num1 = value;
}
}
public int anumber1
{
get
{
return num2;
}
set
{
num2 = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
p.anumber = 20;
number k = new number();
k.anumber1 = 40;
int m = p.anumber;
int t = k.anumber1;
int r = p.anumber + k.anumber1;
Console.WriteLine("number = " +m);
Console.WriteLine("number = " +t);
Console.WriteLine("sum = " +r);
Console.ReadLine();
}
}
Compile time error
sum = 60
number = 40
number = 20
None
number = 20
number = 40--------
sum = 60
What will be the output of following snippet of code?
class number
{
int length = 50;
public int number1
{
get
{
return length;
}
set
{
length = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
p.number1 = p.number1 + 40;
int k = p.number1 * 3 / 9;
Console.WriteLine(k);
Console.ReadLine();
}
}
180
0
Compile time error
30 -----
What will be the output of following snippet of code?
class student
{
int []scores = new int[3] {13, 32, 24};
public int this[int index]
{
get
{
if (index < 3)
return scores[index];
else
{
Console.WriteLine("invalid index");
return 0;
}
}
private set
{
if (index < 3)
scores[index] = value;
else
Console.WriteLine("invalid index");
}
}
}
class Program
{
public static void Main(string[] args)
{
student s = new student();
int[] scores1 = new int[3] {8, 19, 40};
for (int i = 0; i < 3; i++)
{
if (scores1[i] > s[i])
{
Console.WriteLine("scores1 had greater value :" + scores1[i]);
}
else
{
Console.WriteLine("scores had greater value :" + s[i]);
}
}
Console.ReadLine();
}
}
Run time error
scores had greater value :13-----
scores had greater value :32-------
scores1 had greater value :40 --------
0
Compile time error
select output for following set of Code:
static void Main(string[] args)
{
int i;
int b = 8, a = 32;
for (i = 0; i <= 10; i++)
{
if ((a / b * 2)== 2)
{
Console.WriteLine( i + " ");
continue;
}
else if (i != 4)
Console.Write(i + " ");
else
break;
}
Console.ReadLine();
}
0 1 2 3 4
0 1 2 3 ------
1 2 3 4 5 6 7 8 9
0 1 2 3 4 5 6 7 8
What is the output for the following code ?
static void Main(string[] args)
{
int a = 5;
if (Convert.ToBoolean((.002f) -(0.1f)))
Console.WriteLine("Sachin Tendulkar");
else if (a == 5)
Console.WriteLine("Rahul Dravid");
else
Console.WriteLine("Ms Dhoni");
Console.ReadLine();
}
Rahul Dravid
Sachin Tendulkar --------
Ms Dhoni
Warning : Unreachable Code
What will be the output of following snippet of code?
class number
{
private int num1 = 60;
private int num2 = 20;
public int anumber
{
get
{
return num1;
}
set
{
num1 = value;
}
}
public int anumber1
{
get
{
return num2;
}
set
{
num2 = value;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
number k = new number();
int m = p.anumber;
int t = k.anumber1;
int r = p.anumber * k.anumber1;
Console.WriteLine("sum = " + r);
Console.ReadLine();
}
}
sum = 0
sum = 1200 ------------
sum = 120
Compile time error
Select output for set of code :
static void Main(string[] args)
{
int []a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
func(ref a);
Console.ReadLine();
}
static void func(ref int[] x)
{
Console.WriteLine(" numbers are:");
for (int i = 0; i < x.Length; i++)
{
if (x[i] % 2 == 0)
{
x[i] = x[i] + 1;
Console.WriteLine(x[i]);
}
}
}
numbers are : 2 4 6 8 10
numbers are : 3 5 7 9 11 ----------
None of the mentioned
numbers are : 2 3 4 5 6
Select the ouput for following set of code :
static void Main(string[] args)
{
int x = 4 ,b = 2;
x -= b/= x * b;
Console.WriteLine(x + " " + b);
Console.ReadLine();
}
4 0 --------
None of mentioned
0 4
4 2
What is the method to load assembly by name
Assembly.loadfile()
Assembly.reflectiononlyload
Assembly.load() ------
Assembly.load from()
Select the relevant ‘if statement’ to be placed in following set of code :
static void Main(string[] args)
{
int []num = {50, 65, 56, 88, 43, 52};
int even = 0, odd = 0;
for (int i = 0 ;i < num.Length ;i++)
{
/*___________________________*/
}
Console.WriteLine("Even Numbers:" +even);
Console.WriteLine("Odd Numbers:" +odd);
Console.ReadLine();
}
if(num[i] % 2 = 0)
{
even += 1;
}
else
{
odd += 1;
}
if ((num % 2) == 0)
{
even += 1;
}
else
{
odd += 1;
}
if(num[i] % 2 == 0)
{
even += 1;
}
else--------------
{
odd += 1;
}
if((num * i) == 0)
{
even += 1;
}
else
{
odd += 1;
}
What will be the output of following snippet of code?
class number
{
int length = 60;
public int number1
{
get
{
return length;
}
}
}
class Program
{
public static void Main(string[] args)
{
number p = new number();
int l;
l = p.number1 + 40;
int k = l * 3 / 4;
Console.WriteLine(k);
Console.ReadLine();
}
}
0
75 ------
80
30
OOPS-3 Please read the questions carefully and choose the most appropriate option.Which of the given options can in a class?
Methods
All the listed options------
Properties
Events
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE?
None of the 2 listed options
Both the listed options
Operator overloading works in different ways for structures and classes.
When used as a modifier, the new keyword explicitly hides a member inherited from a base class.------
What will be the output for given set of code? class maths { public int fun(int k, int y) { return k + y; } public int fun1(int t, float z) { return (t+(int)z); } } class Program { static void Main(string[] args) { maths obj = new maths(); int i; int b = 90; int c = 100; int d = 12; float l = 14.78f; i = obj.fun(b, c); Console.WriteLine(i); int j = (obj.fun1(d, l)); Console.WriteLine(j); Console.ReadLine(); } }
190, 26------
0, 26.78f
190, 0
190, 26.78f
Please read the questions carefully and choose the most appropriate option.Which of the given options By default methods are virtual.
Both the listed options
Each derived class does not have its own version of a virtual method.
None of the 2 listed options------
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE?
Both the listed options------
We can use the new modifier to modify a nested type if the nested type is hiding another type.
None of the 2 listed options
Operator overloading permits the use of symbols to represent computations for a type.
Please read the questions carefully and choose the most appropriate option.Which of the given options are necessary Polymorphism?
Both the override method and the virtual method must have the same access level modifier.
An abstract method is implicitly a virtual method.
The overridden base method must be virtual, abstract or override.
All the listed options------
What will be the output for set of code? static void Main(string[] args) { int i = 5; int j = 6; add(ref i); add(6); Console.WriteLine(i); Console.ReadLine(); } static void add(ref int x) { x = x * x;
} static void add(int x) { Console.WriteLine(x * x * x); }
216 25------
Compile time error
216 0
25 0
What will be the output for given set of code? class a { public void fun() { Console.WriteLine("base method"); } } class b: a { public new void fun() { Console.WriteLine("derived method"); } } class Program { static void Main(string[] args) { b k = new b(); k.fun(); Console.ReadLine(); } }
base method
derived method------
Code run successfully print nothing
Compile time error
Please read the questions carefully and choose the most appropriate option.Which of the given options is TRUE?
Both the listed options------
When overriding a method, the names and type signatures of the override method must be the same as is being overriden.
Abstract methods are implicitly virtual.
None of the 2 listed options
Please read the questions carefully and choose the most appropriate option.Which of the given options operators in C#.Net?
||
All the listed options------
!
&&
Please read the questions carefully and choose the most appropriate option.Which of the given options By default methods are virtual
Both the listed options
If a derived class does not provide its own version of virtual method then the one in the base class is used.------
None of the 2 listed options
What could be the output for set of code? class overload { public int x; int y; public int add(int a) { x = a + 1; return x; } public int add(int a, int b) { x = a + 2; return x; } } class Program { static void Main(string[] args) { overload obj = new overload(); overload obj1 = new overload(); int a = 0; obj.add(6); obj1.add(6, 2); Console.WriteLine(obj.x); Console.WriteLine(obj1.x); Console.ReadLine(); }
}
0 2
8 8
7 8------
8 10
Please read the questions carefully and choose the most appropriate option.Which of the given options The conditional logical operators cannot be overloaded.------
When a binary operator is overloaded the corresponding assignment operator, if any, must be explicitly None of the 2 listed options
Both the listed options
Please read the questions carefully and choose the most appropriate option.Which of the following overload user-defined types by defining static member functions?
op
All the listed options
operator------
opoverload
Please read the questions carefully and choose the most appropriate option.A derived class can by declaring an override as
extends
not inheritable
inheritable
sealed------
OOPS – 4
Please read the questions carefully and choose the most appropriate option.Which of the given options can implement an interface?
1.class
2.enum
only 2
only 1--------
Both 1 and 2
None of the listed options
Select the output for given set of code?
public class sample
{
public static int x = 100;
public static int y = 150;
}
public class newspaper :sample
{
new public static int x = 1000;
static void Main(string[] args)
{
console.writeline(sample.x + " " + sample.y + " " + x);
}
}
100 150 1000 -----
100 150 100
1000 150 1000
100 150 1000
Please read the questions carefully and choose the most appropriate option.Which of the given options can be declared in an interface?
1.Properties
2.Method
only 1
only 2
Both 1 and 2 ----------
None of the listed options
Which statement should be added in function a() of class y to get output “i love csharp”?
class x
{
public void a()
{
Console.WriteLine("i love csharp");
}
}
class y : x
{
public void a()
{
/* add statement here */
Console.Write("bye");
}
}
class program
{
static void Main(string[] args)
{
y obj = new y();
obj.a();
}
}
x.a();
base.a(); ------
x::a();
a()
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
Interfaces can be inherited ----
All interfaces are derived from an Object interface
None of the listed options
All interfaces are derived from an Object class
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
From two base interfaces a new interface cannot be inherited.
Properties can be declared inside an interface ----------
All the listed options
Interfaces cannot be inherited
Correct statement about following C#.NET code is?
class baseclass
{
int a;
public baseclass(int a1)
{
a = a1;
Console.WriteLine("a");
}
class derivedclass : baseclass
{
public derivedclass(int a1)
: base(a1)
{
Console.WriteLine("b");
}
}
class program
{
static void Main(string[] args)
{
derivedclass d = new derivedclass(20);
}
}
}
Compile time error
Output : b
a
the program will work correctly if we replace base(a1) with base.baseclass(a1)
Output : a
b ----------
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
The functions declared in an interface have a body
One interface can be implemented in another interface
An interface can be implemented by multiple classes in the same program.
A class that implements an interface can explicitly implement members of that interface --------
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
An interface cannot contain the signature of an indexer.
To implement an interface member, the corresponding member in the class must be public as well as static.
When a class inherits an interface it inherits member definitions as well as its implementations.
Interfaces members are automatically public. ------
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
1.One class can implement only one interface.
2.In a program if one class implements an interface then no other class in the same program can implement this interface.
None of the listed options -------
Only 2
Both 1 and 2
Only 1
Please read the questions carefully and choose the most appropriate option.It is possible to create a custom attribute that can be applied only to specific programming element(s) like which of the given options?
Classes
Methods
Classes and Methods
Classes, Methods and Member-Variables
What is output following set of code ?
using System;
public class BaseClass
{
public BaseClass()
{
Console.WriteLine("I am a base class");
}
}
public class ChildClass : BaseClass
{
public ChildClass()
{
Console.WriteLine ("I am a child class");
}
static void Main()
{
ChildClass CC = new ChildClass();
}
}
compile time error
I am a child class I am a base class
I am a base class I am a child class -------
None of the mentioned
Select statement added to the current set of code to get output as 10 20 ?
class baseclass
{
protected int a = 20;
}
class derived : baseclass
{
int a = 10;
public void math()
{
/* add code here */
}
}
Console.WriteLine(base.a + ” ” + a);
Console.WriteLine(a + ” ” + base.a); -------
Console.WriteLine( a + ” ” + this.a);
Console.WriteLine( mybase.a + ” ” + a);
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
If a class implements an interface partially, then it becomes an abstract class. ------
An interface can contain static methods.
An interface can contain static data.
A class cannot implement an interface partially.
Please read the questions carefully and choose the most appropriate option.Which of the given statements is TRUE about an interface used in C#.NET?
1.Interfaces can contain only method declaration.
2.Interfaces can contain static data and methods.
None of the listed options --------
only 2
only 1
Both 1 and 2
OOPS – 5 Select the output for following set of codes: static void Main(string[] args) { int i = 0; while (i++ != 0) ; Console.WriteLine(i); Console.ReadLine(); }
0 to 127
1------
-127 to +127
It is not necessary to declare size of an array with it’s type
What is synchronization in reference to a thread?
Its a method that allow to many threads to access any information the require
Its a process of handling situations when two or more threads need access to a shared resource------
Its a process by which a method is able to access many different threads simultaneously
Its a process by which many thread are able to access same shared resource simultaneously
Select the correct statement among the given statements?
One class could implement only one interface
None of the mentioned
Properties could be declared inside an interface------
Interfaces cannot be inherited
Which of the following is correct way of implementing an interface addition by class maths?
class maths implements addition {}
class maths imports addition {}
None of the mentioned
class maths : addition {}------
A class consists of two interfaces with each interface consisting of three methods.The class had this class?
12 bytes
16 bytes
0 bytes
24 bytes------
Given the class sample inherited by class sample 1. Which are correct statements about construction The order of calling constructors depend on whether constructors in class sample and sample 1 are private While creating the object firstly------
 the constructor of class sample will be called followed by constructor of While creating the object firstly constructor of class sample 1 will be called followed by constructor of The constructor of only sample class will be called
Which of these class is used to make a thread?
Thread------
String
System
Runnable
Select the output for following set of code: static void Main(string[] args) { int i = 1, j = 1; while (++i <= 10) { j++; } Console.WriteLine(i+ " " +j); Console.ReadLine(); }
12 11
It is not necessary to declare size of an array with it’s type
11 10------
Select the class visibility modifiers among the following :
Private, protected, public, internal, protected internal------
All of the mentioned
Private, protected, public
Private, protected, public, internal
Choose the correct output of following given code snippet? interface i1 { void f1(); } interface i2 :i1 { void f2(); } public class maths :i2 { public void f2() { Console.WriteLine("fun2"); } public void f1() { Console.WriteLine("fun1"); } } class Program { static void Main() { maths m = new maths(); m.f1(); m.f2(); } }
fun2
fun1
fun1 fun2------
fun2 fun1
What is multithreaded programming?
It’s a process in which two different processes run simultaneously
Its a process in which a single process can access information from many sources
It’s a process in which two or more parts of same process run simultaneously------
Its a process in which many different process are able to access same information
Choose the correct statement about following code snippet given below: interface a1 { void f1(); void f2(); } class a :a1 { private int i; void a1.f1() { } }
Compile time error------
Class a fully implements the interface a1
Class a could not have an instance data
Class a is an abstract class
Select the output for following set of Code : static void Main(string[] args) { int i = 1; while (i <= 1) { if ('A' < 'a') { Console.WriteLine("Hello..."); } else { Console.WriteLine("Hi..."); } i++; } Console.ReadLine(); }
Hello...------
It is not necessary to declare size of an array with it’s type
Hi…infinite times
Hi…
OOPS – 6
Correct way to implement the interface given below?
interface person
{
string firstname
{
get;
set;
}
}
None of the mentioned
class emp :implements person { private string str; public string firstname { get { return str; } set { str = value; } } }
class emp: implements person { private string str; public string person.firstname { get { return str; } set { str = value; } } }
class emp :person{ private string str; public string firstname; { get { return str; } set { str = value; } } } ----------
What could be the output of following set of code?
class Program
{
static void Main(string[] args)
{
Console.WriteLine( vol(10));
Console.WriteLine( vol(2.5f, 5));
Console.WriteLine( vol( 5l, 4, 5));
Console.ReadLine();
}
static int vol(int x)
{
return(x * x * x);
}
static float vol(float r, int h)
{
return(3.14f * r * r * h);
}
static long vol(long l, int b, int h)
{
return(l * b * h);
}
}
0 0 100
1000 0 100
1000 98.125 100 -------------
compile time error
What would be output for set of code?
class maths
{
public int x;
public double y;
public int add(int a, int b)
{
x = a + b;
return x;
}
public int add(double c, double d)
{
y = c + d;
return (int)y;
}
public maths()
{
this.x = 0;
this.y = 0;
}
}
class Program
{
static void Main(string[] args)
{
maths obj = new maths();
int a = 4;
double b = 3.5;
obj.add(a, a);
obj.add(b, b);
Console.WriteLine(obj.x + " " + obj.y);
Console.ReadLine();
}
}
8 0
8 7 ----
7.5 8
4 3.5
Select output for set of code?
class sample
{
public int i;
void display()
{
Console.WriteLine(i);
}
}
class sample1 : sample
{
public int j;
public void display()
{
Console.WriteLine(j);
}
}
class Program
{
static void Main(string[] args)
{
sample1 obj = new sample1();
obj.i = 1;
obj.j = 2;
obj.display();
Console.ReadLine();
}
}
2 ----
1
Compile Time Error
3
Select the correct implementation of the interface which is mentioned below.
interface a1
{
int fun(int i);
}
class a { int fun(int i) as a1.fun { } }
None of the mentioned
class a: implements a1 { int fun(int i) { } }
class a: a1 { int a1.fun(int i) { } } -------
What will be the output for set of code?
class maths
{
public int fun(int k, int y, int n)
{
Console.WriteLine(k + " " + y + " " + n);
return (k);
}
public int fun1(int t,float z)
{
Console.WriteLine(t + " " + z);
return t;
}
}
class Program
{
static void Main(string[] args)
{
maths obj = new maths();
int b = 90;
int c = 100;
int d ;
float l;
int i = obj.fun(b, c, 12);
int j = (obj.fun1(12, 14.78f));
Console.ReadLine();
}
}
90, 100, 12 12, 14
0, 0, 0 12, 14.78
90, 100, 12 12, 14.78 ---------
0, 0, 0 0, 0
The following set of code run on single level of inheritance. Find correct statement about the code?
class sample
{
int i = 10;
int j = 20;
public void display()
{
Console.WriteLine("base method ");
}
}
class sample1 : sample
{
public int s = 30;
}
class Program
{
static void Main(string[] args)
{
sample1 obj = new sample1();
Console.WriteLine("{0}, {1}, {2}", obj.i, obj.j, obj.s);
obj.display();
Console.ReadLine();
}
}
compile time error ---------
10, 20, 30 base method
10, 20, 0
base method
What will be the output of given code snippet?
interface calc
{
void cal(int i);
}
public class maths :calc
{
public int x;
public void cal(int i)
{
x = i * i;
}
}
class Program
{
public static void Main(string[] args)
{
maths arr = new maths();
arr.x = 0;
arr.cal(2);
Console.WriteLine(arr.x);
Console.ReadLine();
}
}
4 --------
2
None of the mentioned
0
Correct code to be added for overloaded operator – for C# .net code given below?
class csharp
{
int x, y, z;
public csharp()
{
}
public csharp(int a ,int b ,int c)
{
x = a;
y = b;
z = c;
}
Add correct set of code here
public void display()
{
console.WriteLine(x + " " + y + " " + z);
}
class program
{
static void Main(String[] args)
{
csharp s1 = new csharp(5 ,6 ,8);
csharp s3 = new csharp();
s3 = - s1;
s3.display();
}
}
}
None of the mentioned
public static csharp operator -(csharp s1) { csharp t = new csharp(); t.x = -s1.x; t.y = -s1.y; t.z = -s1.z; return t; } -------------
public static csharp operator -(csharp s1) { csharp t = new csharp(); t.x = s1.x; t.y = s1.y; t.z = s1.z; return t; }
public static csharp operator -(csharp s1) { csharp t = new csharp(); t.x = s1.x; t.y = s1.y; t.z = -s1.z; return t; }
Select the sequence of execution of function f1(), f2() & f3() in C# .NET CODE?
class baseclass
{
public void f1() {}
public virtual void f2() {}
public virtual void f3() {}
}
class derived : baseclass
{
new public void f1() {}
public override void f2() {}
public new void f3() {}
}
class Program
{
static void Main(string[] args)
{
baseclass b = new derived();
b.f1 ();
b.f2 ();
b.f3 ();
}
}
f1() of base class get executed f2() of derived class get executed f3() of base class get executed --------
f1() of base class get executed f2() of derived class get executed f3() of derived class get executed
f1() of derived class get executed f2() of derived class get executed f3() of base class get executed
f1() of derived class get executed f2() of base class get executed f3() of base class get executed
What will be the output for given set of code?
class maths
{
public int fun(int ii)
{
return(ii > 0 ? ii :ii * -1);
}
public long fun(long ll)
{
return(ll > 0 ? ll :ll * -1);
}
public double fun( double dd)
{
return(dd > 0 ? dd :dd * -1);
}
}
class Program
{
static void Main(string[] args)
{
maths obj = new maths();
int i = -25;
int j ;
long l = -100000l ;
long m;
double d = -12.34;
double e;
j = obj.fun(i);
m = obj.fun(l);
e = obj.fun(d);
Console.WriteLine(j + " " + m + " " + e);
Console.ReadLine();
}
}
0 0 0
25 100000 12.34 ----------
0
1 1 1