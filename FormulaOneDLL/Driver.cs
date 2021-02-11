using System;

namespace FormulaOneDLL
{
    public class Driver
    {
        public int _id;
        public int _number;
        public string _name;
        public DateTime _dob;
        public string _pob;
        public byte[] _helmetImg;
        public byte[] _img;
        public int _teamId;
        public int _podiums;
        public string _countryCode;

        public Driver(int id, int number, string name, DateTime dob, string pob, byte[] helmetImg, byte[] img, int teamId, int podiums, string countryCode)
        {
            _id = id;
            _number = number;
            _name = name;
            _dob = dob;
            _pob = pob;
            _helmetImg = helmetImg;
            _img = img;
            _teamId = teamId;
            _podiums = podiums;
            _countryCode = countryCode;
        }
    }
}
