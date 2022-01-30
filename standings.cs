using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportDataApi
{


    public class Rootobject
    {
        public Query query { get; set; }
        public Data data { get; set; }
    }

    public class Query
    {
        public string apikey { get; set; }
        public string season_id { get; set; }
    }

    public class Data
    {
        public int season_id { get; set; }
        public int league_id { get; set; }
        public int has_groups { get; set; }
        public Standing[] standings { get; set; }
    }

    public class Overall
    {
        public int games_played { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int goals_diff { get; set; }
        public int goals_scored { get; set; }
        public int goals_against { get; set; }
    }

    public class Home
    {
        public int games_played { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int goals_diff { get; set; }
        public int goals_scored { get; set; }
        public int goals_against { get; set; }
    }

    public class Away
    {
        public int games_played { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int goals_diff { get; set; }
        public int goals_scored { get; set; }
        public int goals_against { get; set; }
    }


}
