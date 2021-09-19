using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackermeDB.DB
{
    public class Students
    {
        public  string firstName { get; set; }
        public  string lastName { get; set; }
        public  string studentID { get; set; }
        public  string cityID { get; set; }
        public  DateTime DOB { get; set; }
        public  string phoneNumber { get; set; }
        public  int alreadyPaid { get; set; }
        public string EmailAdress { get; set; }

        public override string ToString()
        {
            return $"First Name : {firstName}\nLast Name: {lastName}\nID : {studentID}\nPhone Number :{phoneNumber}\nEmail Address :{EmailAdress}\nCity:{cityID}"; 
        }
    }
}