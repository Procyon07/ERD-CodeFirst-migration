using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Palve
    {
        public Guid Id { get; set; }
        public virtual FirmaPeakontor FirmaPeakontor { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public string PalveSisu { get; set; }
        public string Pohjus { get; set; }
        public string Ettepanek { get; set; }
        public DateTime Kuupaev { get; set; }
    }
}
