using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you've shown strength and resilience.") {}

    public void Run()
    {
        DisplayStartingMessage();

        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];

        Console.WriteLine($"\nConsider the following prompt:\n--- {prompt} ---\n");
        ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = _questions[rnd.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
