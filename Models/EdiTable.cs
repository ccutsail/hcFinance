using System;
using System.Collections.Generic;

namespace hcFinance.Models
{
    public partial class EdiTable
    {
        public string AccountNumber { get; set; }
        public int? Carc1 { get; set; }
        public string Carc1Desc { get; set; }
        public int? Carc2 { get; set; }
        public string Carc2Desc { get; set; }
        public int? Carc3 { get; set; }
        public string Carc3Desc { get; set; }
        public int? Carc4 { get; set; }
        public string Carc4Desc { get; set; }
        public int? Carc5 { get; set; }
        public string Carc5Desc { get; set; }
        public double? Pl { get; set; }
    }
}
