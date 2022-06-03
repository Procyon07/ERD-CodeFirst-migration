using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vihje
    {
        public Guid Id { get; set; }
        public virtual FirmaPeakontor FirmaPeakontor { get; set; }
        public string VihjeSisu { get; set; }
        public string Pohjus { get; set; }
        public DateTime Kuupaev { get; set; }
    }
}
