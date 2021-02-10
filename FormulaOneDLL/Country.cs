namespace FormulaOneDLL
{
    public class Country
    {
        private string _countryCode { get; set; }
        private string _countryName { get; set; }

        public Country(string countryCode, string countryName)
        {
            _countryCode = countryCode;
            _countryName = countryName;
        }
    }
}
