using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Laenatud
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public string EsemeNimetus { get; set; }
        public int EsemeKood { get; set; }
        public DateTime LaenutusKP { get; set; }
        public DateTime TagastusKP { get; set; }
    }
}
