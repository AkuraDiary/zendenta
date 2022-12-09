using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zendenta.model
{
    public class Patient
    {
        public Byte[] img { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public DateTime nextAppointment { get; set; }
        public DateTime lastAppointment { get; set; }
        public DateTime registerDate { get; set; }

        public static List<Patient> dummyListPatien = new List<Patient>(10);

        public static void fillList()
        {
            for (int i = 0; i < 10; i++)
            {
                dummyListPatien.Add(new Patient());
            }
        }
    }  
}
