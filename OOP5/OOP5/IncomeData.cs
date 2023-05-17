using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class IncomeData : IIncomeData
    {
        public string CountryCode;
        public string Company;
        public string ContactFirstName;
        public string ContactLastName;
        public int CountryPhoneCode;
        public long PhoneNumber;

        public string getCountryCode()
        {
            return CountryCode;
        }
        public string getCompany()
        {
            return Company;
        }

        public string getContactFirstName()
        {
            return ContactFirstName;
        }

        public string getContactLastName()
        {
            return ContactLastName;
        }

        public int getCountryPhoneCode()
        {
            return CountryPhoneCode;
        }

        public long getPhoneNumber()
        {
            return PhoneNumber;
        }
    }
}
