using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class PuhkusteNimekiri
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public DateTime AlguseKP { get; set; }
        public DateTime LoppKP { get; set; }
    }
}
