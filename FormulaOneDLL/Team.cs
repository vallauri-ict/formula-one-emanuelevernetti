namespace FormulaOneDLL
{
    public class Team
    {
        public int _id { get; set; }
        public string _teamName { get; set; }
        public byte[] _teamLogo { get; set; }
        public string _base { get; set; }
        public string _teamChief { get; set; }
        public string _technicalChief { get; set; }
        public string _powerUnit { get; set; }
        public byte[] _carImage { get; set; }
        public string _country { get; set; }
        public int _worldChampionships { get; set; }
        public int _polePositions { get; set; }

        public Team(int id, string teamName, byte[] teamLogo, string @base, string teamChief, string technicalChief, string powerUnit, byte[] carImage, string country, int worldChampionships, int polePositions)
        {
            _id = id;
            _teamName = teamName;
            _teamLogo = teamLogo;
            _base = @base;
            _teamChief = teamChief;
            _technicalChief = technicalChief;
            _powerUnit = powerUnit;
            _carImage = carImage;
            _country = country;
            _worldChampionships = worldChampionships;
            _polePositions = polePositions;
        }
    }
}
