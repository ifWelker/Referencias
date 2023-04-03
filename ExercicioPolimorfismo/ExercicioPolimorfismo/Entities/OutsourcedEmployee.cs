using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee()
        {
            
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge)
            : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddtionalCharge;
        }
    }

    
}
