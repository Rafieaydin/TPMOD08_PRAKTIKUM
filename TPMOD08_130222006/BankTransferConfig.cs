using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD08_130222006.BankTransferConfig
{
    internal class BankTransferConfig
    {
        public String lang { get; set; }
        public transfers transfer { get; set; }
        public String methods { get; set; }
        public confirmations confirmation { get; set; }


    }

    internal class transfers
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    internal class  confirmations 
    {
        public String en { get; set; }
        public String id { get; set; }
    }


}
