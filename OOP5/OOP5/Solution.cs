using System;
using System.Collections.Generic;

namespace OOP5
{
    class Solution
    {
        public static Dictionary<string, string> countries = new Dictionary<string, string>();
        static IncomeData incomeData = new IncomeData()
        {
            Company = "Yandex",
            CountryCode = "RU",
            ContactFirstName = "Ivan",
            ContactLastName = "Zaicev",
            CountryPhoneCode = 7,
            PhoneNumber = 9034312312
        };
        static Solution()
        {
            countries["CA"] = "Canada";
            countries["RU"] = "Russia";
            countries["UA"] = "Ukraine";
        }
        
          
        static void Main(string[] args)
        {
            IncomeDataAdapter adapter = new IncomeDataAdapter(incomeData);
            PrintContact(adapter);
            PrintCustomer(adapter);
        }

        static void PrintCustomer(ICustomer customer)
        {
            Console.WriteLine("company: " + customer.getCompanyName());
            Console.WriteLine("country: " + customer.getCountryName());
        }
        static void PrintContact (IContact contact)
        {
            Console.WriteLine("name: " + contact.getName());
            Console.WriteLine("phone number: " + contact.getPhoneNumber());
        }

        class IncomeDataAdapter : ICustomer, IContact
        {
            private IIncomeData incomeData;
            public IncomeDataAdapter(IIncomeData incomeData)
            {
                this.incomeData = incomeData;
            }

            public string getCompanyName()
            {
                return incomeData.getCompany();
            }

            public string getCountryName()
            {
                return countries[incomeData.getCountryCode()];
            }

            public string getName()
            {
                return incomeData.getContactLastName() + ", " + incomeData.getContactFirstName();
            }

            public string getPhoneNumber()
            {
                string baseNumber = incomeData.getPhoneNumber().ToString();                
                while (baseNumber.Length < 10)
                {
                    baseNumber = '0' + baseNumber;
                }
                return "+" + incomeData.getCountryPhoneCode().ToString() + "(" + baseNumber.Substring(0, 3) + ")" + baseNumber.Substring(3);               
            }
        }
    }
    
}
