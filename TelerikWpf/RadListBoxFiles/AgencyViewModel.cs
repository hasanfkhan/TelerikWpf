using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWpf.RadListBoxFiles
{
    public class AgencyViewModel
    {
        private ObservableCollection<Agency> agencies;

        public ObservableCollection<Agency> Agencies
        {
            get
            {
                return agencies ?? (agencies = new ObservableCollection<Agency>
                    {
                        new Agency() {Name = "Exotic Liquids", Phone = "(171) 555-2222", Zip = "EC1 4SD"},
                        new Agency() {Name = "Tokyo Traders", Phone = "(100) 555-4822", Zip = "70117"},
                        new Agency() {Name = "Speciality Biscuits Ltd.", Phone = "(161) 555-4448", Zip = "M14 GSD"},
                        new Agency() {Name = "Mayumi's", Phone = "(06) 431-7877", Zip = "545"},
                        new Agency() {Name = "New Orleans Cajun Delights", Phone = "(100) 555-4822", Zip = "70117"}
                    });
            }
        }
    }
}
