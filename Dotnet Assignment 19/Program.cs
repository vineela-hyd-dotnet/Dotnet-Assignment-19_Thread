using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");

       
        Thread thread1 = new Thread(PrintNumbers);

      
        Thread thread2 = new Thread(PrintAlphabets);

       
        thread1.Start();
        thread2.Start();

      
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Main Thread Ended");
    }

    // Method to print numbers from 1 to 5
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"[Thread 1] Number: {i}");
            Thread.Sleep(500); 
        }
    }

   
    static void PrintAlphabets()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"[Thread 2] Alphabet: {c}");
            Thread.Sleep(500); 
        }
    }
}
