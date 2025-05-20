﻿using System.Text.Json;

namespace Lesson20;

internal class Program
{
    static void Main ()
    {
        RunThreads();
        RunThreadPool();
        RunTasks();
    }
    
    static void RunThreads ()
    {
        List<Thread> threads = [];
    
        for (int i = 1; i <= 10; i++)
        {
            int number = i;
            Thread thread = new Thread(() => CalcFactorial(number));
            threads.Add(thread);
            thread.Start();
        }
    
        foreach (var thread in threads)
        {
            thread.Join();
        }
    }
    
    static void RunThreadPool ()
    {
        using CountdownEvent countdown = new CountdownEvent(10);
    
        for (int i = 1; i <= 10; i++)
        {
            int number = i;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                CalcFactorial(number);
                countdown.Signal();
            });
        }
    
        countdown.Wait();
    }
    
    static void RunTasks ()
    {
        int count = 10;
        long[] results = new long[count];
        Task[] tasks = new Task[count];
    
        for (int i = 1; i <= count; i++)
        {
            int number = i;
    
            tasks[number - 1] = Task.Run(() =>
            {
                results[number - 1] = CalcAndReturnFactorial(number);
            });
        }
    
        Task.WhenAll(tasks);
    
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Факториал {i + 1} = {results[i]}");
        }
    }
    
    static void CalcFactorial (int number)
    {
        long result = 1;
    
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
    
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} : Факториал {number} = {result}");
    }
    
    static long CalcAndReturnFactorial (int number)
    {
        long result = 1;
    
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
    
        return result;
    }
}
