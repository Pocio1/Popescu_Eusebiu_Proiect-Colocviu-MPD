using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Popescu_Eusebiu_Proiect_Colocviu_MPD.List
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name = "Client Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
