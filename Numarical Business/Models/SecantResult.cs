using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numarical_Business.Models
{
    public class SecantResult
    {
        public int Iteration { get; set; }
        public double XiMinus1 { get; set; }
        public double FXiMinus1 { get; set; }
        public double Xi { get; set; }
        public double FXi { get; set; }
        public double Error { get; set; }
    }
}
