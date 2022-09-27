namespace DodgeballStatsApp.Data
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  internal class MatchLog
  {
    public int MatchLogID { get; set; }
    public string ActioningPlayer { get; set; }

    public string Action { get; set; }

    public string RecieveingPlayer { get; set; }

    public string MatchName { get; set; }

    public DateTime CreatedDate { get; set; }
  }
}
