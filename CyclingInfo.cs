using System;
using System.IO;
using System.Reflection;
namespace Cycling
{
    internal class Program
    {
        static void ReadFile(string path)
        {
            //---- Establish communication
            FileStream F1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader F1_SR = new StreamReader(F1);
            //---- Read
            string record = "";
            while ((record = F1_SR.ReadLine()) != null)
            {
                Console.WriteLine(record);
            }
            //---- Close communication
            F1_SR.Close();
            F1.Close();
        }
        static void WriteFile(string path, string record)
        {
            //---- Establish communication
            FileStream F1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter F1_SW = new StreamWriter(F1);
            //---- Write
            F1_SW.WriteLine(record);
            //---- Close communication
            F1_SW.Close();
            F1.Close();
        }
        static void Main(string[] args)
        {
            // Set the file name
            string FilePath = @"C:\Users\never\Documents\Ejercicios\Programming\Cyclists.txt";
            if (File.Exists(FilePath))
            {
                Console.WriteLine("The file exists. It cannot be overwritten. Closing...");
                return;
            }
            else
            {
                WriteFile(FilePath, "NAME" + " ; " + "BICYCLE MODEL" + " ; " + "RACE NUMBER\n");
                // Establish an infinite loop as long as the response is Y or N.
                while (true)
                {
                    Console.WriteLine("Do you want to add a participant? (Y/N): ");
                    string Response = Console.ReadLine();
                    if (Response.ToUpper() == "N")
                    {
                        Console.WriteLine("File so far:\n");
                        ReadFile(FilePath);
                        Console.WriteLine("\nExiting...\n");
                        break;
                    }
                    else if (Response.ToUpper() == "Y")
                    {
                        Console.Write("Enter the cyclist's name: ");
                        string cyclist = Console.ReadLine();
                        Console.Write("Enter the bicycle model: ");
                        string model = Console.ReadLine();
                        Console.Write("Enter the cyclist's race number: ");
                        string raceNumber = Console.ReadLine();

                        WriteFile(FilePath, cyclist + " ; " + model + " ; " + raceNumber);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N. Yes or no");
                    }
                }
            }
        }
    }
}
