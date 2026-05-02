using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numarical_Business.Models
{
    public class FixedPointResult
    {
        public int Iteration { get; set; }
        public double Xi { get; set; }
        public double FXi { get; set; }
        public double Error { get; set; }
    }
}
