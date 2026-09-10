using System;

public class PromptGenerator
{
    public List<string> _prompts = [
           "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What would you do if you felt completely fearless?",
        "What about yourself are you grateful for?",
        "What is one simple goal you want to focus on this week?",
        "What is something you would like to change about your daily routine?",
        "Who is someone you admire, and what qualities do they have?",
        "What simple moments bring you joy?",
        "How would you describe yourself to a stranger?"
       ];

    public List<string> _blessingPrompts = [
        "How did I see the hand of the Lord in my life today?",
        "What about yourself are you grateful for?",
        "What simple moments bring you joy?"
       ];

    public PromptGenerator() { }

    public string GetPrompt()
    {
        int numPrompt = _prompts.Count;
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, numPrompt);
        return _prompts[num];
    }
}