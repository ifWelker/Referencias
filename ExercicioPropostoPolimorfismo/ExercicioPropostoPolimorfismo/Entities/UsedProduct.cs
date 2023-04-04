using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioPropostoPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
            
        }

        public UsedProduct(string name, double price,DateTime manufacturedate)
            : base (name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString(CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy") 
                + ")";
        }
    }
}
