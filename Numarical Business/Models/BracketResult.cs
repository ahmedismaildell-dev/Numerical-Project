using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numarical_Business.Models
{
    public class BracketResult
    {
        public int Iteration { get; set; }
        public double Xl { get; set; }
        public double FXl { get; set; }
        public double Xu { get; set; }
        public double FXu { get; set; }
        public double Xr { get; set; }
        public double FXr { get; set; }
        public double Error { get; set; }
    }
}
