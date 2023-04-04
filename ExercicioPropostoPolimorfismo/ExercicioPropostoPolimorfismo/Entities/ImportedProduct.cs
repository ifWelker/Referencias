using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioPropostoPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, double customFee)
            : base (name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public string PriceTag()
        {
            return Name
                + " - $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + $"(Custom fee: ({CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
