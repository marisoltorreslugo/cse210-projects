using System.IO;
public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }
  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter outputfile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        outputfile.WriteLine($"{entry._date}|{entry._promtText}|{entry._entryText}|{entry._mood}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    List<Entry> loadedEntries = new List<Entry>();

    using (StreamReader inputFile = new StreamReader(file))
    {
      string line;

      while ((line = inputFile.ReadLine()) != null)
      {
        string[] parts = line.Split('|', 4);

        if (parts.Length != 4)
        {
          throw new FormatException("Invalid journal file format.");
        }

        Entry newEntry = new Entry();
        newEntry._date = parts[0];
        newEntry._promtText = parts[1];
        newEntry._entryText = parts[2];
        newEntry._mood = parts[3];
        loadedEntries.Add(newEntry);
      }
    }
    _entries = loadedEntries;
  }
}