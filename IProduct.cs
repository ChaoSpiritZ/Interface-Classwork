using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Classwork
{
    interface IProduct
    {
        void TurnOn();
        void TurnOff();
        bool IsBatteryEmpty();
        void SetErrorHandler(IProductError errorHandler); //who takes care of the errors
    }
}
