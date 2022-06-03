using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HaigusLehed
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public DateTime AlgusKP { get; set; }
        public DateTime LoppKP { get; set; }
        public string Pohjus { get; set; }
    }
}
