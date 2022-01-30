namespace SportDataApi
{
    public class Standing
    {
        public int team_id { get; set; }
        public int position { get; set; }
        public int points { get; set; }
        public string status { get; set; }
        public string result { get; set; }
        public Overall overall { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
    }


}
