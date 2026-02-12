using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary
{
    public class State
    {
        public string StateName { get; set; }
        public long Population { get; set; }
        public string FlagDescription { get; set; }
        public string StateFlower { get; set; }
        public string StateBird { get; set; }
        public string Colors { get; set; }
        public string LargestCities { get; set; }
        public string Capital { get; set; }
        public decimal MedianIncome { get; set; }
        public double ComputerJobPercentage { get; set; }
    }
}
