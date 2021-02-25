using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL.DTO
{
    public class dtoTeam
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
        public int number1 { get; set; }
        public string name1 { get; set; }
        public int number2 { get; set; }
        public string name2 { get; set; }

        public dtoTeam(int id, string teamName, byte[] teamLogo, string @base, string teamChief, string technicalChief, string powerUnit, byte[] carImage, string country, int worldChampionships, int polePositions, int number1, string name1, int number2, string name2)
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
            this.number1 = number1;
            this.name1 = name1;
            this.number2 = number2;
            this.name2 = name2;
        }
    }
}
