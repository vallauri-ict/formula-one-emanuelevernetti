using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL.DTO
{
    public class dtoDriver
    {
        public string _name { get; set; }
        public int _number { get; set; }
        public string _teamName { get; set; }
        public string _countryCode { get; set; }
        public int _podiums { get; set; }
        public DateTime _dob { get; set; }
        public string _pob { get; set; }
        public byte[] _helmetImg { get; set; }
        public byte[] _img { get; set; }

        public dtoDriver(string name, int number, string teamName, string countryCode, int podiums, DateTime dob, string pob, byte[] helmetImg, byte[] img)
        {
            _name = name;
            _number = number;
            _teamName = teamName;
            _countryCode = countryCode;
            _podiums = podiums;
            _dob = dob;
            _pob = pob;
            _helmetImg = helmetImg;
            _img = img;
        }
    }
}
