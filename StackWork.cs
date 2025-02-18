using System;
using System.Collections;

public class Stacks
{
    public static void Main()
    {
        // Define the stack
        Stack myStack = new Stack();

        // Create the menu
        Console.WriteLine("Welcome to the stack application.");
        Console.WriteLine("\nChoose an option");

        string option = "";
        do
        {
            Console.WriteLine("\n-------Menu-------");
            Console.WriteLine("1. Add element to the stack");
            Console.WriteLine("2. Remove element from the stack");
            Console.WriteLine("3. Stack length");
            Console.WriteLine("4. Show the stack");
            Console.WriteLine("5. Exit");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddToStack(ref myStack);
                    break;

                case "2":
                    RemoveFromStack(ref myStack);
                    break;

                case "3":
                    StackLength(ref myStack);
                    break;

                case "4":
                    WriteStack(ref myStack);
                    break;

                case "5":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("\nIncorrect option. Please enter an option between 1 and 5");
                    break;
            }
        } while (option != "5");
    }

    public static void StackLength(ref Stack stack)
    {
        Console.WriteLine("\nStack length: " + stack.Count);
    }

    public static void AddToStack(ref Stack stack)
    {
        if (stack.Count < 10)
        { 
            Console.Write("\nEnter value: ");
            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                stack.Push(value);
                WriteStack(ref stack);
            }
            catch
            {
                Console.WriteLine("Error: Only numbers are allowed.");
            }
        }
        else
        {
            Console.WriteLine("The stack already contains 10 elements. No more elements can be added.");
        }
    }

    public static void RemoveFromStack(ref Stack stack)
    {
        if (stack.Count > 0)
        {
            int value = (int)stack.Pop();
            Console.WriteLine("Element " + value + " removed");
        }
        else
        {
            Console.WriteLine("The stack is empty.");
        }
        WriteStack(ref stack);
    }

    public static void WriteStack(ref Stack stack)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine("\nElements in the stack:");
            foreach (int item in stack)
            {
                Console.WriteLine("| " + item + " |");
            }
        }
        else
        {
            Console.WriteLine("The stack is empty.");
        }
    }
}
