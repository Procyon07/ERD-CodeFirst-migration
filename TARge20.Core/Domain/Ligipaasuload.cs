using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ligipaasuload
    {
        public Guid Id { get; set; }
        public virtual FirmaPeakontor FirmaPeakontor { get; set; }
        public virtual FirmaHarukontor FirmaHarukontor { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public Char Kasutajatunnus { get; set; }
        public Char Parool { get; set; }
        public DateTime ViimaneKulastus { get; set; }
    }
}
