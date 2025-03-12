namespace TaskMaster
{
  public class Task
  {
    public string? Id { get; set; }
    public string? Description { get; set; }
    public bool Completed { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool Deleted { get; set; }

    public Task(string id, string description)
    {
      Id = id;
      Description = description;
      CreatedAt = DateTime.Now;
      ModifiedAt = DateTime.Now;
      Deleted = false;
      Completed = false;
    }
  }
}