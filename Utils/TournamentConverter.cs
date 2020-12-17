using System.Collections.Generic;

namespace Tennis_Simulation
{
    static class TournamentConverter
    {
        public static List<ITournament> ConvertTournaments(List<Tournament> tournaments)
        {
            List<ITournament> alltournaments = new List<ITournament>();
            for (int i = 0; i < tournaments.Count; i++)
            {
                if (tournaments[i].type == "elimination")
                {
                    alltournaments.Add(new EliminationTournament(tournaments[i].id, tournaments[i].surface, tournaments[i].type));
                }
                else if (tournaments[i].type == "league")
                {
                    alltournaments.Add(new LeagueTournament(tournaments[i].id, tournaments[i].surface, tournaments[i].type));
                }

            }

            return alltournaments;
        }
    }
}
