using System;

namespace SportDataApi.Markets
{

    public class Rootobject
    {
        public Query query { get; set; }
        public Datum[] data { get; set; }
    }

    public class Query
    {
        public string apikey { get; set; }
        public string season_id { get; set; }
        public string date_from { get; set; }
        public string live { get; set; }
    }

    public class Datum
    {
        public int match_id { get; set; }
        public int status_code { get; set; }
        public string status { get; set; }
        public string match_start { get; set; }
        public DateTime match_start_iso { get; set; }
        public int minute { get; set; }
        public int league_id { get; set; }
        public int season_id { get; set; }
        public Stage stage { get; set; }
        public Group group { get; set; }
        public Round round { get; set; }
        public int referee_id { get; set; }
        public Team home_team { get; set; }
        public Team away_team { get; set; }
        public Stats stats { get; set; }
        public Venue venue { get; set; }
    }

    public class Stats
    {
        public int home_score { get; set; }
        public int away_score { get; set; }
        public object ht_score { get; set; }
        public string ft_score { get; set; }
        public object et_score { get; set; }
        public object ps_score { get; set; }
    }

}
