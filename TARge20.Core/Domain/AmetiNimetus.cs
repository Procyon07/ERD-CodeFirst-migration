using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AmetiNimetus
    {
        public Guid Id { get; set; }
        public virtual Tootaja Tootaja { get; set; }
        public string EsemeNimetus { get; set; }
        public string Kvalifikatsioonid { get; set; }
        public string TooUlesanded { get; set; }
    }
}
