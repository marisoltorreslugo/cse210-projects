public class Entry
{
  public string _date;
  public string _promtText;
  public string _entryText;
  public string _mood;

  public void Display()
  {
    Console.WriteLine($"\nDate: {_date} - Prompt: {_promtText}");
    Console.WriteLine($"{_entryText}");
    Console.WriteLine($"Mood: {_mood}");
  }
}