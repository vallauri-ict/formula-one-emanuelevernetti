using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL
{
    public class Driver
    {
        private int _id;
        private int _number;
        private string _name;
        private DateTime _dob;
        private string _pob;
        private byte[] _helmetImg;
        private byte[] _img;
        private int _teamId;
        private int _podiums;
        private string _countryCode;

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
