using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private List<string> _availablePrompts;
    private Random _rand;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do one thing today, what would it be?"
        };

        _availablePrompts = new List<string>(_prompts);
        _rand = new Random();
    }

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }

        int index = _rand.Next(_availablePrompts.Count);
        string selectedPrompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);

        return selectedPrompt;
    }
}
