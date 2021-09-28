using System;
using System.Collections.Generic;

namespace BlazingDewey.Shared
{
    public class ScoreboardList
    {
        public static List<ScoreboardClass> scoreboardList = new()
        {
            new ScoreboardClass { FirstName = "Sue", TimeTaken = new TimeSpan(0, 1, 12), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Ebrahim", TimeTaken = new TimeSpan(0, 0, 30), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Blake", TimeTaken = new TimeSpan(0, 0, 32), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Jimmy", TimeTaken = new TimeSpan(0, 0, 31), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Doris", TimeTaken = new TimeSpan(0, 1, 25), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Amy", TimeTaken = new TimeSpan(0, 0, 25), Diffuculty = Difficulty.Easy },
            new ScoreboardClass { FirstName = "Bob", TimeTaken = new TimeSpan(0, 1, 32), Diffuculty = Difficulty.Medium },
            new ScoreboardClass { FirstName = "Joe", TimeTaken = new TimeSpan(0, 1, 45), Diffuculty = Difficulty.Medium },
            new ScoreboardClass { FirstName = "Andrew", TimeTaken = new TimeSpan(0, 1, 15), Diffuculty = Difficulty.Medium },
            new ScoreboardClass { FirstName = "Essex", TimeTaken = new TimeSpan(0, 2, 32), Diffuculty = Difficulty.Hard },
            new ScoreboardClass { FirstName = "Bobby", TimeTaken = new TimeSpan(0, 2, 15), Diffuculty = Difficulty.Hard },
            new ScoreboardClass { FirstName = "Lizzy", TimeTaken = new TimeSpan(0, 3, 05), Diffuculty = Difficulty.Hard }
        };

        public ScoreboardList()
        {

        }

        public static List<ScoreboardClass> GetScoreBoardScores()
        {
            return scoreboardList;
        }
    }

}
