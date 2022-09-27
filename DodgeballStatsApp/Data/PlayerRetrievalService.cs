namespace DodgeballStatsApp.Data;

public class PlayerRetrievalService
{
	private static readonly string[] CPTPlayersNames = new[]
	{
		"Bennie", "Kyle", "Vianne", "Nick", "James", "Frodo"
	};

  private static readonly string[] JHBPlayersNames = new[]
  {
    "Quintin", "Doug", "Jean", "Dmitri", "Justin", "Jason"
  };

  public Task<Player[]> GetCptMenAsync()
	{
		return Task.FromResult(Enumerable.Range(0, 6).Select(index => new Player
		{
			Name = CPTPlayersNames[index],
      Position = index,
      Team = "CPT"
		}).ToArray());
	}

  public Task<Player[]> GetJhbMenAsync()
  {
		return Task.FromResult(Enumerable.Range(0, 6).Select(index => new Player
		{
			Name = JHBPlayersNames[index],
			Position = index,
			Team = "JHB"
		}).ToArray());
	}
}

