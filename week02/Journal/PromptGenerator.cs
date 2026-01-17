using System;
using System.IO;
using System.Collections.Generic; 

public class PromptGenerator
{
    public List<string> _prompts; 
    public Random _random = new Random(); 
    public PromptGenerator()
    {
        _prompts = new List<string>(File.ReadAllLines("Prompts.txt")); 
      
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}
