using System;
using System.Collections.Generic;
using System.Threading;

namespace FirstAssign
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
                    Console.Write("Please Enter First operator");
                    opArray[0] = Char.Parse(Console.ReadLine());

                    Console.Write("Please Enter Second operator");
                    opArray[1] = Char.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Please enter the first number ");
                    numArray[0] = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number ");
                    numArray[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the third number ");
                    numArray[2] = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("<Thats less than a hundred");
                }
                else if (result > 100)
                {
                    Console.WriteLine(">Thats more than a hundred");
                }
                else
                {
                    Console.WriteLine("Cool, you now have a hundred, clap clap");
                }

                //play again or extit promt
                Console.WriteLine("Play again, Y or N ");
                var press = Console.ReadKey();

                if (press.Key == ConsoleKey.Y)

                {
                    Console.Clear();
                    Console.WriteLine(@"
                      _             _                     __ _           _
                     | |     ___   | |_    ___     o O O / _` |  ___    | |
                     | |__  / -_)  |  _|  (_-<    o      \__, | / _ \   |_|
                     |____| \___|  _\__|  /__/_  TS__[O] |___/  \___/  _(_)_
                    |-----_ | ///_|-----_ | ****|{======_|////_ |''''_| **|
                    `-0-0-`-0-0 --0-0-`-  0 - 0 -.o--000`-0-0-`-0 0 -.--0 0");
                    Console.WriteLine("Great choice! Calculator starts in:  ");
                    Console.Write("3........");
                    Thread.Sleep(1000);
                    Console.Write("2........");
                    Thread.Sleep(1000);
                    Console.Write("1........");
                    Thread.Sleep(1000);

                    playagain = true;
                }
                else if (press.Key == ConsoleKey.N)
                {
                    playagain = false;
                }
            } while (playagain == true);

            double sum = 0;

            foreach (var value in arrayList)
            {
                sum += value; // Adde stored value
            }
            
            Console.Clear();
            Console.WriteLine("Your  totall is = " + sum);
            Console.WriteLine (@"
                   ╔══╗
                   ╚╗╔╝
                   ╔╝(¯`v´¯)
                   ╚══`.¸.[C#]
                          [ThankYouForPlaying]
                         __________
                        | ________ |
                        ||12345678||
                        |----------|
                        |[M|#|C][-]|
                        |[7|8|9][+]|
                        |[4|5|6][x]|
                        |[1|2|3][%]|
                        |[.|O|:][=]|
                        \__________/ ");
            Console.WriteLine("Press enter To Exit");
            Console.ReadLine();
            Console.Write("Calculator exiting in:  ");
            Console.Write("3........");
            Thread.Sleep(1000);
            Console.Write("2........");
            Thread.Sleep(1000);
            Console.Write("1........");
            Thread.Sleep(1000);
            Console.Write("PeaceOut"); 
        }
    }
}