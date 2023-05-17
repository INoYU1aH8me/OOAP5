using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    interface IIncomeData
    {
        string getCountryCode();        //For example: UA
        string getCompany();            //For example: JavaRush Ltd.
        string getContactFirstName();   //For example: Ivan
        string getContactLastName();    //For example: Ivanov
        int getCountryPhoneCode();      //For example: 38
        long getPhoneNumber();           //For example: 501234567
    }
}
