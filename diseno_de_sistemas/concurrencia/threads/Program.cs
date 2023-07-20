// This code creates two threads that both print the numbers from 1 to 10.

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create two threads.
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers);

        // Start the threads.
        thread1.Start();
        thread2.Start();

        // Wait for the threads to finish.
        thread1.Join();
        thread2.Join();

        // Exit the program.
        Console.WriteLine("Exiting...");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}