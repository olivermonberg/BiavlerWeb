using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BiavlerWeb.Models
{
    public class Varroataelling
    {
        [Key]
        public long Id { get; set; }
        public string Bistade { get; set; }
        public string Dato { get; set; }
        public int AntalVarroamider { get; set; }
        public int Observationsvarighed { get; set; }
        public string Bemaerkning { get; set; }
        public string UserId { get; set; }
    }
}
