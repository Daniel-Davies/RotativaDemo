using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotativaDemo.Models
{
    public class LeagueTable
    {
        public DateTime DateCreated { get; set; }
        public int matchWeek { get; set; }

        public List<LeagueRow> rows { get; set; }

        public LeagueTable()
        {
            this.DateCreated = DateTime.Now.Date;
            this.rows = new List<LeagueRow>();
            this.matchWeek = 33;
        }

        public void createTableInstance()
        {
            string[] teams = { "Arsenal", "Bournemouth", "Brighton & Hove", "Burnley", "Cardiff", "Chelsea", "Crystal Palace", "Everton",
                               "Fulham", "Huddersfield Town", "Leicester City", "Liverpool", "Manchester City", "Manchester United", "Newcastle United",
                                "Southampton", "Tottenham Hotspur", "Watford", "West Ham United", "Wolverhampton Wanderers"};

            int[] gamesPlayed = new int[] { 33, 33, 33, 34, 33, 34, 33, 34, 33, 33, 33, 34, 33, 34, 33, 34, 33, 33, 33, 34 };

            Random rnd = new Random();
            int[] accesses = Enumerable.Range(0, 20).OrderBy(c => rnd.Next()).ToArray();


            int[] points = new int[] { 82, 80, 66, 64, 63, 61, 47, 47, 46, 46, 42, 39, 38, 36, 35, 33, 33, 28, 17, 14 };


            for (int i = 0; i < gamesPlayed.Length; i++)
            {
                rows.Add(new LeagueRow(i+1, teams[accesses[i]], gamesPlayed[accesses[i]], points[i]));
            }
        }
    }
}
