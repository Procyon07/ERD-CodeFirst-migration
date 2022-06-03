using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class FirmaHarukontor
    {
        public Guid Id { get; set; }
        public virtual FirmaPeakontor FirmaPeakontor { get; set; }
        public int RegistriNr { get; set; }
        public string Nimi { get; set; }
        public string Luhinimi { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public int KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
    }
}
