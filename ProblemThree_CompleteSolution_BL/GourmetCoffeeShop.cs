using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        private int v1;
        private string itemName;
        private Dictionary<int, double> coffeePriceDict;

        public GourmetCoffeeShop(int v1, string itemName, Dictionary<int, double> coffeePriceDict)
        {
            this.v1 = v1;
            this.itemName = itemName;
            this.coffeePriceDict = coffeePriceDict;
        }

        public int ItemName { get; set; }

        public override double PayPerPiece(int quantity)
        {
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
