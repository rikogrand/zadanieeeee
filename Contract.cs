using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieeeee
{
    class Contract
    {
        public int ContractID { get; set; }
        public DateTime Date { get; set; }
        public int DepositPayed { get; set; }
        public int Order { get; set; }
        public int ContractTotalPrice { get; set; }
        public int ContractTotalPrice_IncIVAT { get; set; }
        public string ProductionProcess { get; set; }

    }
}
