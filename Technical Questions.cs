using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string myInput;
         double myDouble;
         Console.Write("Please input a number.");
         myInput = Console.ReadLine();
         myDouble = Double.Parse(myInput);

         if (myDouble < 0 || myDouble == 0)
         {
             Console.WriteLine("Your number is not greater than 0.");
         }
         else if (myDouble > 0 && myDouble < 10)
         {
             Console.WriteLine("Your number is between 0 and 10");
         }
         else
         {
             Console.WriteLine("Your number is greater than 10");
         }
         Console.Read();
         */


            /*Console.WriteLine("Enter a number to see it's cube: ");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);
            Console.WriteLine("The cube of " + number + " is " + number*number*number + ".");
            Console.Read();
            */


            //Display a declared string's variable length w/o length function

            /* string str;
             int count = 0;
             Console.WriteLine("Find the length of a string.");
             Console.WriteLine("Enter a word: ");
             str = Console.ReadLine();
             foreach (char c in str)
             {
                 count++;
             }
             Console.Write("Length of the string is: " + count);
             Console.Read();
            */


            //Count the vowels in a word

            /*Console.WriteLine("Count the vowels in a word.");
            string input = Console.ReadLine();
            string lowerinput = input.ToLower();
            int counter = 0;
            for (int i = 0; i < lowerinput.Length; i++)
            {
                if (lowerinput[i] == 'a' || lowerinput[i] == 'e'
                    || lowerinput[i] == 'i' || lowerinput[i] == 'o'
                     || lowerinput[i] == 'u')
                {
                    counter++;
                }
                
            }
                Console.WriteLine("There are " + counter + " vowels in the string");
            Console.ReadLine();
            */

            //Take a user input and count the number of words

            /*Console.WriteLine("Enter a sentence.");
            string input = Console.ReadLine();
            string[] input = input.Split(' ');
            Console.WriteLine(input.Length);
            */

            //Take a string and reverse it

            /*
            Console.WriteLine("Input a word.");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            string reverse = " ";
            
            for (int i = word.Length -1; i>=0; i--)
            {
                reverse += wordArray[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
            */

            //Takes User input integer, print out a triangle with the number the user input

            Console.WriteLine("Enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i =1; i<=number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

                        //convert lower to upper and upper to lower

            Console.WriteLine("Enter a string.");
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                Convert.ToInt32(c);
                if (c >= 65 && c <= 90)
                {
                    Console.Write(Convert.ToChar(c + 32));
                }
                else if (c >= 97 && c <= 122)
                {
                    Console.Write(Convert.ToChar(c - 32));
                }
            }
            Console.ReadLine();



                        //print a triangle of numbers
            Console.WriteLine("Enter a number.");
            int myNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= myNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
            // continue combining digits in a 2 digit number until the result is a single digit
            Console.WriteLine("Enter a two digit number.");
            int myNum = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            while (myNum > 9)
            {
                firstNum = myNum % 10;
                secondNum = myNum / 10;
                myNum = firstNum + secondNum;
            }
            Console.WriteLine(myNum);
            Console.ReadLine();

                        //Caesar Cipher
        {
            Console.WriteLine("Enter a lower case word");
            string myWord = Console.ReadLine();
            Console.WriteLine("Enter a number between 1 and 25");
            int myNum = Convert.ToInt32(Console.ReadLine());
            int newAscii = 0;
            foreach (char c in myWord)
            {
                if (c + myNum < 122)
                {
                    newAscii = c + myNum;
                }
                else if (c + myNum > 122)
                {
                    newAscii = c + c + myNum - 122 - 1;
                }
                Console.Write(Convert.ToChar(newAscii));
            }
            Console.ReadLine();
            

            // reverse an int without using strings ex. 547
            Console.WriteLine("Enter a three digit number.");
            int myNum = int.Parse(Console.ReadLine());
            int right = myNum % 10; //7
            int leftTwo = myNum / 10; //54
            int middle = leftTwo % 10; //4
            int left = leftTwo / 10; //5
            Console.WriteLine((100 * right) + (10 * middle) + (left));
            Console.ReadLine();


        }
    }
}
