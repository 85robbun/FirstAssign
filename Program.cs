using System;

namespace KalkUpp
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            bool active = true;
            do
            {
                Console.WriteLine("CalcArray");
                var numArray = new int[3];
                var opArray = new[] { '+', '-', '*', '/' };

                //Begränsade beräkningarna till 3 input pga Uppgiftens krav.
                //Det hade varit "cleanare" att låta användaren matta in siffor
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Enter the firstNumber ");
                    numArray[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the SecondNumber ");
                    numArray[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the ThirdNumber ");
                    numArray[2] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Please Enter First operator");
                    opArray[0] = Char.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter Second operator");
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
                Console.WriteLine("Result: {0}", result);
                Console.WriteLine("\nType 'Exit' to leave :( Or try another calculation :)\n");
                if (result < 100)
                {
                    Console.WriteLine("Less than a hundred");
                }
                else if (result > 100)
                {
                    Console.WriteLine("More than a hundred");
                }
                else
                {
                    Console.WriteLine("Cool, you now have a hundred, clap clap");
                }

                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }

                Console.WriteLine("Result: {0}", result);
                Console.WriteLine("\nType 'Exit' to leave :( Or try another calculation :)\n");
            } while (active == true);


        }
    }
}