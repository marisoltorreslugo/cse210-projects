public class PromptGenerator
{
  public List<string> _prompts = new List<string>
  {
    "What was the best part of my day?",
    "What made me smile today?",
    "What was the biggest challenge I faced today?",
    "What is something new I learned today?",
    "Who made a positive difference in my day?",
    "What am I most grateful for today?",
    "What is something I wish I had done differently today?",
    "How did I help someone today?",
    "What was the strongest emotion I felt today, and why?",
    "What is one thing I want to improve tomorrow?"
  };
  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    string prompt = _prompts[index];
    return prompt;
  }
}