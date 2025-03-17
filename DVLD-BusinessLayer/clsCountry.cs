using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public clsCountry()
        {
            ID = -1;
            CountryName = "";
        }
        public clsCountry(int id, string countryName)
        {
            this.ID = id;
            this.CountryName = countryName;
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
        public static clsCountry Find(string name)
        {
            int id = -1;

            if (clsCountryData.GetCountryByName(ref id, name))
                return new clsCountry(id, name);
            else
                return null;
        }
        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountryData.GetCountryInfoByID(CountryID, ref CountryName))

                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
    }
}
