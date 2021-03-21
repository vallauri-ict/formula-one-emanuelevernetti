namespace FormulaOneDLL
{
    public class Country
    {
        public string _countryCode { get; set; }
        public string _countryName { get; set; }

        public Country(string countryCode, string countryName)
        {
            _countryCode = countryCode;
            _countryName = countryName;
        }

        public override string ToString()
        {
            return _countryCode + " - " + _countryName;
        }
    }
}
