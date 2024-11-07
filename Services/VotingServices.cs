class VotingService
{
  public Election AddNewElection()
  {
    var hardcodedOptions = new List<ElectionOption>
    {
      new ElectionOption("Høyre"),
      new ElectionOption("Frp"),
    };
    Election newElection = new Election(hardcodedOptions);
    return newElection;
  }
}