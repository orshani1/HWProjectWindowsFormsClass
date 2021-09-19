using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWProjectWindowsFormsClass;

namespace HackermeDB.DB
{
    public static class MyDB
    {
        public static int Count { get; set; }
        public static List<Students>  studentsList = new List<Students>();  
        public static IDictionary<Students,Courses> courseDictionary { get; set; }
        
    }
}
