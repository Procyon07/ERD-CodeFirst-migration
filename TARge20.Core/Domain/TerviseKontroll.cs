using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class TerviseKontroll
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public DateTime KontrollKP { get; set; }
        public string Asutus { get; set; }
        public string Tulemus { get; set; }
    }
}
