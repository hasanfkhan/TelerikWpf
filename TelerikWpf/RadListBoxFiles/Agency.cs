using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWpf.RadListBoxFiles
{
    public class Agency
    {
        public Agency()
        {
            
        }

        public Agency(string name, string phone, string zip)
        {
            Name = name;
            Phone = phone;
            Zip = zip;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
    }
}
