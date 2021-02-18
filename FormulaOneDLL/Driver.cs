using System;

namespace FormulaOneDLL
{
    public class Driver
    {
        public int _id { get; set; }
        public int _number { get; set; }
        public string _name { get; set; }
        public DateTime _dob { get; set; }
        public string _pob { get; set; }
        public byte[] _helmetImg { get; set; }
        public byte[] _img { get; set; }
        public int _teamId { get; set; }
        public int _podiums { get; set; }
        public string _countryCode { get; set; }

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
