using Quiz;
using System;

namespace Quiz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CountSummary();
            //StringLength();
            //Reverse();
            //LargestNumber();
            //Divider();
            //LimitPrime();
            //MiddleChar();
            //GetSaturday();
            //TotalString();
            //SecondGreatest();
            //CheckKurawal("{}}");
            Display();


            //1
            static void CountSummary()
            {
                Console.Write("Enter number integer : ");
                string input = Console.ReadLine();
                int sum = 0;

                // convert input to array
                char[] digits = input.ToCharArray();

                // Loop through each digit
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += int.Parse(digits[i].ToString());
                }
                Console.WriteLine("Total sum : {0}", sum);
            }
         
        //2
        static void StringLength()
            {
                Console.Write("Enter number integer: ");
                int number = int.Parse(Console.ReadLine());

                int digitCount = 0;
                while (number != 0)
                {
                    number /= 10;
                    digitCount++;
                }
                Console.WriteLine("Count: " + digitCount);
            }

        //3
        static void Reverse()
            {
                Console.Write("Enter number integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = number.ToString().Length; i > 0; i--)
                {
                    Console.Write(number.ToString()[i - 1] + " ");
                }
            }

        //4
        static void LargestNumber()
            {
                int max = int.MinValue;
                int input;
                Console.Write("Enter integer [ Type 0 for exit ] : ");
                input = int.Parse(Console.ReadLine());
                while (input != 0)
                {
                    if (input > max)
                    {
                        max = input;
                    }
                    Console.Write("Enter integer [ Type 0 for exit ] : ");
                    input = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Angka terbesar : {0}", max);
            }

        //5
        static void Divider()
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        //6
        static void LimitPrime()
            {
                Console.Write("Enter limit number: ");
                int limit = int.Parse(Console.ReadLine());

                // Create a boolean array "prime[0..n]" and initialize all entries it as true.
                // A value in prime[i] will finally be false if i is Not a prime, else true.
                bool[] primes = Enumerable.Repeat(true, limit + 1).ToArray();

                for (int p = 2; p * p <= limit; p++)
                {
                    // If prime[p] is not changed, then it is a prime
                    if (primes[p])
                    {
                        // Update all multiples of p
                        for (int i = p * 2; i <= limit; i += p)
                            primes[i] = false;
                    }
                }

                // Print all prime numbers
                for (int i = 2; i <= limit; i++)
                    if (primes[i])
                        Console.Write(i + " ");
            }

        //7
        static void MiddleChar()
            {
                Console.Write("Enter strings: ");
                string input = Console.ReadLine();

                // Split the input string into an array of words
                string[] words = input.Split(' ');

                // Loop through each word in the array
                for (int i = 0; i < words.Length; i++)
                {
                    char[] word = words[i].ToCharArray();
                    for (int j = 1; j < word.Length - 1; j++)
                    {
                        word[j] = '*';
                    }
                    words[i] = new string(word);
                }

                // Join the words back together and display the result
                string result = string.Join(" ", words);
                Console.WriteLine(result);
            }

        //8
        static void GetSaturday()
            {
                Console.Write("Input tanggal : ");
                DateTime input = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)input.DayOfWeek + 7) % 7;
                DateTime nextSaturday = input.AddDays(daysUntilSaturday);
                Console.WriteLine("Hari sabtu : {0:dd/MM/yyyy}", nextSaturday);
                Console.WriteLine("{0} hari lagi!", daysUntilSaturday);
            }

        //9
        static void TotalString()
            {
                Console.Write("Enter strings: ");
                string input = Console.ReadLine();

                Console.Write("Find string: ");
                string find = Console.ReadLine();

                int count = 0;
                int index = input.IndexOf(find);
                while (index != -1)
                {
                    count++;
                    index = input.IndexOf(find, index + find.Length);
                }

                Console.WriteLine("Total kata yang muncul: {0} dari text: {1}", count, input);
            }

        //10
        static void SecondGreatest()
            {
                int[] numbers = new int[5];
                int firstGreatest, secondGreatest;


                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter {0}. number: ", i + 1);
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                firstGreatest = secondGreatest = int.MinValue;
                //looping check array
                for (int i = 0; i < 5; i++)
                {
                    if (numbers[i] > firstGreatest)
                    {
                        secondGreatest = firstGreatest;
                        firstGreatest = numbers[i];
                    }
                    else if (numbers[i] > secondGreatest && numbers[i] != firstGreatest)
                    {
                        secondGreatest = numbers[i];
                    }
                }

                Console.WriteLine("Second Greatest: {0}", secondGreatest);
            }

        //11
        static bool CheckKurawal(string input)
            {
                int openCurly = 0;
                int closeCurly = 0;

                // loop through each character in the input string
                foreach (char c in input)
                {
                    if (c == '{')
                        openCurly++;
                    else if (c == '}')
                        closeCurly++;
                }
                // if the number of open curly braces is equal to the number of closed curly braces, return true
                if (openCurly == closeCurly)
                    return true;
                else
                    return false;
            }

        static void Display()
            {
                int row, col, num;
                num = 10;
                row = 5;
                col = 5;
                //1
                for (int i = col; i < num; i++)
                {
                    for (int j = num; j > col; j--)
                    {
                        if (j > i)
                            Console.Write($"{j} ");
                    
                    }
                    Console.WriteLine();
                }

                //2
                Console.WriteLine();
                for (int i = 1; i <= row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (j < i)
                            Console.Write($"{i + j} ");
                    }
                    Console.WriteLine();
                }

                //3
                Console.WriteLine();
                for (int i = 1; i < col*2; i++)
                {
                    if (i <= col)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{j} ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 1; j <= col * 2 - i; j++)
                        {
                            Console.Write($"{j} ");
                        }
                        Console.WriteLine();
                    }
                }
            }

        }



    }
}