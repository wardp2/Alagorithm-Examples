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

                        //Ways to combine and sorted arrays
            //With sort method
            /*int[] arr1 = new int[] { 0, 2, 4 };
            int[] arr2 = new int[] { 1, 3, 5 };
            int[] arr3 = arr1.Concat(arr2).ToArray();
            Array.Sort(arr3);

            foreach (int num in arr3)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
            */

            //With BubbleSort method
            int[] arr1 = new int[] { 0, 2, 4 };
            int[] arr2 = new int[] { 1, 3, 5 };
            int[] arr3 = arr1.Concat(arr2).ToArray(); //arr3[0, 2, 3, 1, 3, 5]
            int temp = 0;
            for (int i= 0; i <arr3.Length; i++)
                for (int j=i+1; j<arr3.Length-1; j++)
                    if(arr3[i]>arr3[j])
                    {
                        temp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = temp;
                    }
            foreach (int num in arr3)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

                        //Generate 10 random non-duplicating numbers between 0 and 30
            Random random = new Random();
            List<int> randNums = new List<int>();
            while (randNums.Count < 10)
            {
                int var = random.Next(0, 30);
                if (!randNums.Contains(var))
                {
                    randNums.Add(var);
                }
            }
            foreach (int num in randNums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

            //Calculate the distance between the hands on a clock
            Console.WriteLine("Enter a military time.");
            int time = Convert.ToInt32(Console.ReadLine());
            int hour = time / 100;
            int min = time % 100;
            int hourdeg = hour * 30;
            if(hourdeg>360)
            {
                hourdeg = hourdeg - 360;
            }
            int mindeg = min * 6;
            int difference = Math.Abs(hourdeg - mindeg);
            Console.WriteLine(difference);
            Console.ReadLine();

                        //program to store words in a sentence based on their character composition
            List<string> noE = new List<string>();
            Console.WriteLine("Enter a sentence.");
            string mySent = Console.ReadLine();
            string[] mySentArr = mySent.Split(' ');
            foreach (string word in mySentArr)
            {
                if (!word.Contains('e'))
                {
                    noE.Add(word);
                }
            }
            foreach (string word in noE)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();


                        //reverse a any sized number

            Console.WriteLine("Enter a number.");
            int myNum = int.Parse(Console.ReadLine());
            int reversedNum = 0;
            while(myNum !=0)
            {
                int remainderDigit = myNum % 10;
                reversedNum = (reversedNum * 10) + remainderDigit;
                myNum = myNum / 10;
            }
            Console.WriteLine(reversedNum);
            Console.ReadLine();


                        //Fibonacci sequence at a certain point

            Console.WriteLine("Enter a number to return the Fibonacci value at that point.");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            List<int> fibList = new List<int>();
            for (int i = 0; i<n; i++)
            {
                int temp= a;
                a = b;
                b = temp + a;
                fibList.Add(b);
            }
            foreach (int num in fibList)
            {
                Console.WriteLine(num);
            }
                
            //Console.WriteLine(a);
            Console.ReadLine();

                        //check to see if words are anagrams

            Console.WriteLine("Enter your first word.");
            string first = Console.ReadLine();
            Console.WriteLine("Enter your second word.");
            string second = Console.ReadLine();
            char[] arr1 = first.ToLower().ToCharArray();
            Array.Sort(arr1);
            string newword1 = new string (arr1);
            char[] arr2 = second.ToLower().ToCharArray();
            Array.Sort(arr2);
            string newword2 = new string(arr2);
            if (newword1== newword2)
            {
                Console.WriteLine("The words you entered are anagrams.");
            }
            else if (newword1 != newword2)
            {
                Console.WriteLine("You did not enter an anagram.");
            }
            Console.ReadLine();

                        //is prime

            Console.WriteLine("Enter a number.");
            int myNum = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i<(myNum/2); i++)
            {
                if(myNum%i==0)
                {
                    count++;
                }
            }
            if (count >= 2)
            Console.WriteLine(myNum + " is not prime.");
            else Console.WriteLine(myNum + " is prime.");
            Console.ReadLine();

                        //Store a reversed array in a new array
            int[] arr1 = new int[5] { 1, 3, 5, 6, 7 };
            int[] arr2 = new int[5];
            for (int i = arr1.Length-1, j = 0; i >= 0; i--, j++)
            {
                arr2[j] += arr1[i];
            }
            foreach (int num in arr2)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

                        //Swap numbers not using more memory
            Console.WriteLine("Enter a number.");//10
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number.");//8
            int secNum = int.Parse(Console.ReadLine());
            firstNum = firstNum + secNum;//10+8=18
            secNum = firstNum - secNum;//18-8=10
            firstNum = firstNum - secNum;
            Console.WriteLine(firstNum);
            Console.WriteLine(secNum);
            Console.ReadLine();


            //Random shuffle of cards

            string[] suite = new string[4] { "Diamonds", "Clubs", "Spades", "Hearts" };
            string[] value = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
            List<string> shuffle = new List<string>();
            Random rnd = new Random();
            while (shuffle.Count<52)
            {
                 string randomCard = value[rnd.Next(value.Length)] + " of " + suite[rnd.Next(suite.Length)];
                 if (!shuffle.Contains(randomCard))
                {
                    shuffle.Add(randomCard);
                    //Console.WriteLine(randomCard);
                }
            }
            foreach(string card in shuffle)
            {
                Console.WriteLine(card);
            }
            Console.ReadLine();

            //Reverse a any number w/o methods
             Console.WriteLine("Enter a number.");
            int myNum = int.Parse(Console.ReadLine());
            int reverseNum = 0;
            while (myNum > 0)
            {
                 int rightDig = myNum % 10;
                 reverseNum = (reverseNum * 10) + rightDig;
                 myNum = myNum / 10;
            }
            Console.WriteLine(reverseNum);
            Console.ReadLine();

                        //Check a string for duplicates
            Console.WriteLine("Enter a word.");
            string input = Console.ReadLine();
            char[] inputArray = input.ToLower().ToCharArray();
            Array.Sort(inputArray);
            string inputSort = new string(inputArray);
            int count = 0;
            for(int i = 0; i <inputSort.Length-1; i++)
            {
                if(inputSort[i]==inputSort[i+1])
                {
                    count++;
                }
            }
            if (count>0)
            {
                Console.WriteLine("duplicates");
            }
            else
            {
                Console.WriteLine("no duplicates");
            }
            Console.ReadLine();

            //Print a multiplication table
            Console.WriteLine("Enter a number.");
            int max = Convert.ToInt32(Console.ReadLine());
            int min = 1;
            for(int i = min; i<= max; i++)
            {
                for(int j = min; j<=max; j++)
                {
                    Console.Write(j*i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

                        //string compression
            string lower = "aaabbcccc";
            string ans = "";
            int count = 1;
            for (int i = 0; i < lower.Length - 1; i++)
            {
                if (lower[i] == lower[i + 1])
                    count++;
                else
                {
                    ans = ans + lower[i] + count;
                    count = 1;
                }
            }
            ans = ans + lower[lower.Length - 1] + count;
            if(lower.Length < ans.Length)
                Console.WriteLine(lower);
            else
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
