public class Job
{
  // The C# convention is to start member variables with an underscore _
  public string _jobTitle;
  public string _company;
  public int _startYear;
  public int _endYear;

  public Job()
  {
  }
  public void Display()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}