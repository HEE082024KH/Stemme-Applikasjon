class ElectionOption
{
  Guid id;
  string? name;

  public ElectionOption(string name)
  {
    this.name = name;
    id = Guid.NewGuid();
  }
}