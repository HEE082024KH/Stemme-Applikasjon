var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

VotingService votingService = new();

app.MapGet("/health", () => "Server OK!");
app.MapPost("/valg", () =>
{
  Election newElection = votingService.AddNewElection();
  return Results.Ok(new { id = $"/valg{newElection.id}" });
});

app.Run();
