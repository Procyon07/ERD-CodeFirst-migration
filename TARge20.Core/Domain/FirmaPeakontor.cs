using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class FirmaPeakontor
    {
        [Key]
        public Guid Id { get; set; }
        public int RegistriNumber { get; set; }
        public string Nimi { get; set; }
        public string Luhinimi { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public int KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
    }
}
