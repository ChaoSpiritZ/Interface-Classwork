using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Classwork
{
    class HomeElectronic : IProduct
    {
        private string _color;
        private IProductError _errorHandler = null;

        public HomeElectronic(string color)
        {
            _color = color;
        }

        public void TurnOn()
        {
            Console.WriteLine("electronic on");
        }

        public void TurnOff()
        {
            Console.WriteLine("electronic off");
        }

        public bool IsBatteryEmpty()
        {
            return false;
        }

        public void SetErrorHandler(IProductError errorHandler)
        {
            _errorHandler = errorHandler;
        }
    }
}
