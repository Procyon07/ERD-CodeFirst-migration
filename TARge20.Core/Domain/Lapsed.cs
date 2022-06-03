using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Lapsed
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public string Eesnimi { get; set; }
        public string Perenimi { get; set; }
    }
}
