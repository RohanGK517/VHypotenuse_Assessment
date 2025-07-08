using System;
namespace ConsoleApp
{
    public class Class2
    {
        public void Demo2()
        {
            const int maxAttempts = 3;
            const int maxTransactions = 4;
            int correctPin;
            int pin;
            int balance = 10000;
            int attempts = 0;

            Console.WriteLine("Set your 4-digit ATM PIN:");
            if (!int.TryParse(Console.ReadLine(), out correctPin) || correctPin < 1000 || correctPin > 9999)
            {
                Console.WriteLine("Invalid PIN. Must be a 4-digit number.");
                return;
            }

            Console.Clear();

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your 4-digit PIN: ");
                if (!int.TryParse(Console.ReadLine(), out pin))
                {
                    Console.WriteLine("Invalid input! Please enter digits only.\n");
                    continue;
                }

                if (pin >= 1000 && pin <= 9999 && pin == correctPin)
                {
                    Console.Clear();
                    Console.WriteLine("Login Successful!\n");

                    int transactions = 0;

                    while (transactions < maxTransactions)
                    {
                        Console.WriteLine("\nMain Menu:");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Withdraw");
                        Console.WriteLine("4. Calculator");
                        Console.WriteLine("5. Exit");
                        Console.Write("Choose an option (1-5): ");

                        if (!int.TryParse(Console.ReadLine(), out int choice))
                        {
                            Console.WriteLine("Invalid input. Enter a number between 1 and 5.\n");
                            continue;
                        }

                        Console.Clear();

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"Your current balance is: ₹{balance}\n");
                                transactions++;
                                break;

                            case 2:
                                Console.Write("Enter amount to deposit: ₹");
                                if (int.TryParse(Console.ReadLine(), out int deposit) && deposit > 0)
                                {
                                    balance += deposit;
                                    Console.WriteLine("Deposit successful!\n");
                                    transactions++;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid deposit amount!\n");
                                }
                                break;

                            case 3:
                                Console.Write("Enter amount to withdraw: ₹");
                                if (int.TryParse(Console.ReadLine(), out int withdraw))
                                {
                                    if (withdraw > 0 && withdraw <= balance)
                                    {
                                        balance -= withdraw;
                                        Console.WriteLine("Withdrawal successful!\n");
                                        transactions++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient balance or invalid amount!\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input! Please enter a valid number.\n");
                                }
                                break;

                            case 4:
                                Console.WriteLine("Calculator - Choose operation:");
                                Console.WriteLine("a. Addition (+)");
                                Console.WriteLine("b. Subtraction (-)");
                                Console.WriteLine("c. Multiplication (*)");
                                Console.WriteLine("d. Division (/)");
                                Console.WriteLine("e. Modulus (%)");
                                Console.Write("Enter operation (a-e): ");
                                char op = Console.ReadKey().KeyChar;
                                Console.WriteLine();

                                Console.Write("Enter first number: ");
                                if (!double.TryParse(Console.ReadLine(), out double num1))
                                {
                                    Console.WriteLine("Invalid number!\n");
                                    break;
                                }

                                Console.Write("Enter second number: ");
                                if (!double.TryParse(Console.ReadLine(), out double num2))
                                {
                                    Console.WriteLine("Invalid number!\n");
                                    break;
                                }

                                switch (op)
                                {
                                    case 'a':
                                        Console.WriteLine($"Result: {num1 + num2}\n");
                                        break;
                                    case 'b':
                                        Console.WriteLine($"Result: {num1 - num2}\n");
                                        break;
                                    case 'c':
                                        Console.WriteLine($"Result: {num1 * num2}\n");
                                        break;
                                    case 'd':
                                        if (num2 != 0)
                                            Console.WriteLine($"Result: {num1 / num2}\n");
                                        else
                                            Console.WriteLine("Error: Division by zero!\n");
                                        break;
                                    case 'e':
                                        if (num2 != 0)
                                            Console.WriteLine($"Result: {num1 % num2}\n");
                                        else
                                            Console.WriteLine("Error: Division by zero!\n");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid arithmetic option!\n");
                                        break;
                                }
                                transactions++;
                                break;

                            case 5:
                                Console.WriteLine("Thank you for using the ATM embedded Calculator. Goodbye!");
                                return;

                            default:
                                Console.WriteLine("Invalid choice! Please choose between 1 and 5.\n");
                                break;
                        }
                    }

                    Console.WriteLine("You have reached the maximum number of transactions. Session ended.");
                    return;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Incorrect PIN. Attempts left: {maxAttempts - attempts}\n");
                }
            }

            Console.WriteLine("Too many failed attempts. Card blocked.");
        }
    }
}
