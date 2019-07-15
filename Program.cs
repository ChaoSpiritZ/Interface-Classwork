using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductOperator PO = new ProductOperator();
            PO.TurnOnAllProducts();
            PO.TurnOffAllProducts();
        }
    }
}
