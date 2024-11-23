namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char selection = '\0';
            int num = 0;
            int searchedNumber = 0;
            double sum = 0;
            double avg = 0;
            do
            {
                Console.WriteLine("P-Print Numbers");
                Console.WriteLine("A-Add a number");
                Console.WriteLine("M-Display the mean of the numbers");
                Console.WriteLine("S-Display the smallest Number");
                Console.WriteLine("L-Display the largest number");
                Console.WriteLine("C-Clear the List");
                Console.WriteLine("R-Search for an element");
                Console.WriteLine("V-Lenght of the list");
                Console.WriteLine("Q-Quit");
                selection = Convert.ToChar(Console.ReadLine());
                if (selection == 'P' || selection == 'p')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("The List is Empty");
                        continue;
                    }
                    else
                    {

                        Console.Write("[ ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} ");

                        }
                        Console.WriteLine(" ]");
                        continue;
                    }

                }
                else if (selection == 'A' || selection == 'a')
                {
                    Console.Write("Please Enter Your Number :");
                    num = Convert.ToInt32(Console.ReadLine());
                    bool isDuplicate = false;
                    
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (num == numbers[i])
                            {
                                Console.WriteLine("Sorry Duplicated Number cannot be added");
                                isDuplicate = true;
                                break;
                            }

                        }
                        if (!isDuplicate)
                        {
                            Console.WriteLine($"{num} is added");
                            numbers.Add(num);
                        }


                    
                }
                else if (selection == 'M' || selection == 'm')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate average - no data");
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        avg = sum / numbers.Count;
                        Console.WriteLine($"The Avg is :{avg}");
                        continue;

                    }
                }
                else if (selection == 'S' || selection == 's')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the mallest number - List is Empty");
                    }
                    else
                    {
                        int min = numbers[0];
                        for (int i = 1; i < numbers.Count - 1; i++)
                        {
                            if (numbers[i] < numbers[i + 1])
                            {
                                if (numbers[i] < min)
                                {
                                    min = numbers[i];
                                }
                            }
                            else
                            {
                                if (numbers[i + 1] < min)
                                {
                                    min = numbers[i + 1];
                                }
                            }
                        }
                        Console.WriteLine($"The smallest number is : {min}");
                    }

                }
                else if (selection == 'L' || selection == 'l')
                {
                    int max = numbers[0];
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to find the largest number -List is Empty");
                    }
                    else
                    {
                        for (int i = 1; i < numbers.Count - 1; i++)
                        {
                            if (numbers[i] > numbers[i + 1])
                            {
                                if (numbers[i] > max)
                                {
                                    max = numbers[i];
                                }

                            }
                            else
                            {
                                if (numbers[i + 1] > max)
                                {
                                    max = numbers[i + 1];
                                }
                            }

                        }
                        Console.WriteLine($"The Largest number is : {max}");

                    }

                }
                else if (selection == 'Q' || selection == 'q')
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                else if (selection == 'C' || selection == 'c')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("The List is already Empty !");
                    }
                    else
                    {
                        Console.WriteLine("The List is cleared Successfully");
                        numbers.Clear();
                    }
                }
                else if (selection == 'R' || selection == 'r')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Sorry The List is Empty");
                    }
                    else
                    {
                        Console.Write("Enter The number which you want to search :");
                        searchedNumber = Convert.ToInt32(Console.ReadLine());
                        bool isFound = false;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (searchedNumber == numbers[i])
                            {
                                Console.WriteLine($"The Number is Found at this {i+1} index !");
                                isFound = true;
                                break;
                            }

                        }
                        if (!isFound)
                        {
                            Console.WriteLine("Sorry The number isnot in the list");
                        }

                    }
                }else if (selection == 'V' || selection == 'v')
                {
                    if(numbers.Count == 0)
                    {
                        Console.WriteLine("The List is Empty");
                    }
                    else
                    {
                        Console.WriteLine(numbers.Count);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Choice Please Try Again");
                }


            } while (selection != 'Q');
        }
    }
}
