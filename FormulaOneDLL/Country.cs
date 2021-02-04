namespace FormulaOneDLL
{
    public class Country
    {
        public string _countryCode { get; set; }
        public string _countryName { get; set; }

        public Country(string _countryCode, string _countryName)
        {
            this._countryCode = _countryCode;
            this._countryName = _countryName;
        }
    }
}
