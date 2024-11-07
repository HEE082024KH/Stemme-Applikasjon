class VotingService
{
  private List<Election> activeElection;

  public VotingService()
  {
    activeElection = new List<Election>();
  }
  public Election AddNewElection()
  {
    var hardcodedOptions = new List<ElectionOption>
    {
      new ElectionOption("Høyre"),
      new ElectionOption("Frp"),
    };
    Election newElection = new Election(hardcodedOptions);

    activeElection.Add(newElection);

    return newElection;
  }
}