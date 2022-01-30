namespace SportDataApi
{
    public class Team
    {
        public int team_id { get; set; }
        public string name { get; set; }
        public string short_code { get; set; }
        public string common_name { get; set; }
        public string logo { get; set; }
        public Country country { get; set; }
    }

}
