using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _contactInfo;
    private static List<Job> _instances = new List<Job> {};

    public Job (string title, string description, string contactInfo)
    {
      _title = title;
      _description = description;
      _contactInfo = contactInfo;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetContactInfo()
    {
      return _contactInfo;
    }
    public void SetContactInfo(string newContactInfo)
    {
      _contactInfo = newContactInfo;
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
