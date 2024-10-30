using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager
{
    internal class Coffe
    {
        public readonly string name;
        public readonly int coffeReq;
        public readonly int waterReq;
        public readonly int milkReq;

        public Coffe(string name, int coffeReq, int waterReq, int milkReq)
        {
            this.name = name;
            this.coffeReq = coffeReq;
            this.waterReq = waterReq;
            this.milkReq = milkReq;
        }
        public string DisplayData()
        {
            return $"{name} | {coffeReq} | {waterReq} | {milkReq}";
        }
    }
}
