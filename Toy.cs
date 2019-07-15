using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Classwork
{
    class Toy : IProduct, IWifi
    {

        private bool _isAnnoying;
        private IProductError _errorHandler = null;

        public Toy(bool isAnnoying)
        {
            _isAnnoying = isAnnoying;
        }

        public void TurnOn()
        {
            Console.WriteLine("toy not on");
            if(_errorHandler != null)
            {
                _errorHandler.Error("NOT WORKING MAYDAY MAYDAY!!!");
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("toy off");
        }

        public bool IsBatteryEmpty()
        {
            return true;
        }

        public bool IsConnected()
        {
            return true;
        }

        public void SetErrorHandler(IProductError errorHandler)
        {
            _errorHandler = errorHandler;
        }
    }
}
