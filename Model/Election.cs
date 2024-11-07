class Election
{
  public Guid id { get; set; }
  public required List<ElectionOption> options;
  public required List<Vote> castVotes;

  public Election(List<ElectionOption> electionOptions)
  {
    if (electionOptions.Count <= 1)
    {
      throw new ArgumentException("Elections needs at least 2 options");
    }
    options = new List<ElectionOption>();
    castVotes = new List<Vote>();
  }
}