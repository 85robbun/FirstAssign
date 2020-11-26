using System;
using System.Collections.Generic;
using System.Threading;

namespace inLamNing
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            bool playagain = true;
            List<double> arrayList = new List<double>();
            do
            {
                Console.Clear();

                Console.WriteLine(@"
'##::::'##:'##::: ##::'#######::'########::'########:'##::::'##::'#######::'########:::'#######::'##::::'##:
 ##:::: ##: ###:: ##:'##.... ##: ##.... ##:... ##..:: ##:::: ##:'##.... ##: ##.... ##:'##.... ##:. ##::'##::
 ##:::: ##: ####: ##: ##:::: ##: ##:::: ##:::: ##:::: ##:::: ##: ##:::: ##: ##:::: ##: ##:::: ##::. ##'##:::
 ##:::: ##: ## ## ##: ##:::: ##: ########::::: ##:::: #########: ##:::: ##: ##:::: ##: ##:::: ##:::. ###::::
 ##:::: ##: ##. ####: ##:::: ##: ##.. ##:::::: ##:::: ##.... ##: ##:::: ##: ##:::: ##: ##:::: ##::: ## ##:::
 ##:::: ##: ##:. ###: ##:::: ##: ##::. ##::::: ##:::: ##:::: ##: ##:::: ##: ##:::: ##: ##:::: ##:: ##:. ##::
. #######:: ##::. ##:. #######:: ##:::. ##:::: ##:::: ##:::: ##:. #######:: ########::. #######:: ##:::. ##:
:.......:::..::::..:::.......:::..:::::..:::::..:::::..:::::..:::.......:::........::::.......:::..:::::..::
:'######:::::'###::::'##::::::::'######::'##::::'##:'##::::::::::'###::::'########::'#######::'########::
'##... ##:::'## ##::: ##:::::::'##... ##: ##:::: ##: ##:::::::::'## ##:::... ##..::'##.... ##: ##.... ##:
 ##:::..:::'##:. ##:: ##::::::: ##:::..:: ##:::: ##: ##::::::::'##:. ##::::: ##:::: ##:::: ##: ##:::: ##:
 ##:::::::'##:::. ##: ##::::::: ##::::::: ##:::: ##: ##:::::::'##:::. ##:::: ##:::: ##:::: ##: ########::
 ##::::::: #########: ##::::::: ##::::::: ##:::: ##: ##::::::: #########:::: ##:::: ##:::: ##: ##.. ##:::
 ##::: ##: ##.... ##: ##::::::: ##::: ##: ##:::: ##: ##::::::: ##.... ##:::: ##:::: ##:::: ##: ##::. ##::
. ######:: ##:::: ##: ########:. ######::. #######:: ########: ##:::: ##:::: ##::::. #######:: ##:::. ##:
 ");

                Console.WriteLine("Welcome");

                var numArray = new int[3];
                var opArray = new[] { '+', '-', '*', '/' };

                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Please enter the first number ");
                    numArray[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the second number ");
                    numArray[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the third number ");
                    numArray[2] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Please Enter First operator");
                    opArray[0] = Char.Parse(Console.ReadLine());

                    Console.Write("Please Enter Second operator");
                    opArray[1] = Char.Parse(Console.ReadLine());
                }

                int[] numbers = numArray;
                char[] operations = opArray;

                double result = numbers[0];

                var x = 0;
                for (var i = 1; i < numbers.Length; i++)
                {
                    switch (operations[x])
                    {
                        case '+':
                            {
                                result += numbers[i];
                                break;
                            }
                        case '-':
                            {
                                result -= numbers[i];
                                break;
                            }
                        case '*':
                            {
                                result *= numbers[i];
                                break;
                            }
                        case '/':
                            {
                                result /= numbers[i];
                                break;
                            }
                        default:
                            break;
                    }
                    x++;
                }
                //Printing  result "unorthodox" solution
                string print;

                print = (numbers[0].ToString() + operations[0].ToString() + numbers[1].ToString() + operations[1].ToString() + numbers[2].ToString());
                Console.WriteLine(" result : " + print + " = " + result);

                //Storing the value to list , task requirement
                arrayList.Add((double)result);

                if (result < 100)
                {
                    Console.WriteLine("  < Thats less than a hundred");
                }
                else if (result > 100)
                {
                    Console.WriteLine("   >Thats more than a hundred");
                }
                else
                {
                    Console.WriteLine("Cool, you now have a hundred, clap clap");
                }

                //Getting the stored value from the list and assigning new "sum"
                double sum = 0;
                foreach (var value in arrayList)
                {
                    sum += value; // Prints items
                }

                Console.WriteLine("Press Y or enter to play again, or press N to exit !");
                var answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    playagain = true;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thank you for playing. The sum of all is = " + sum);
                    Console.Write("Calculator exiting in:  ");
                    Console.Write("3........");
                    Thread.Sleep(1000);
                    Console.Write("2........");
                    Thread.Sleep(1000);
                    Console.Write("1........");
                    Thread.Sleep(1000);
                    Console.Write("PeaceOut");
                    Console.WriteLine(@"
 | |__ _  _ ___
 | '_ \ || / -_)
 |_.__/\_, \___");
                    playagain = false;
                }
            } while (playagain == true);
        }
    }
}