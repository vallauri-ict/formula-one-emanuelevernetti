using System;

namespace FormulaOneDLL
{
    public class Team
    {
        private int _id { get; set; }
        private string _teamName { get; set; }
        private byte[] _teamLogo { get; set; }
        private string _base { get; set; }
        private string _teamChief { get; set; }
        private string _technicalChief { get; set; }
        private string _powerUnit { get; set; }
        private byte[] _carImage { get; set; }
        private string _country { get; set; }
        private int _worldChampionships { get; set; }
        private int _polePositions { get; set; }

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
