using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Classwork
{
    class ProductOperator : IProductError
    {
        private IProduct[] _products;

        public ProductOperator()
        {
            _products = new IProduct[4];
            _products[0] = new Toy(true);
            _products[0].SetErrorHandler(this);
            _products[1] = new Toy(false);
            _products[1].SetErrorHandler(this);
            _products[2] = new HomeElectronic("White");
            _products[2].SetErrorHandler(this);
            _products[3] = new HomeElectronic("Black");
            _products[3].SetErrorHandler(this);
        }

        public void TurnOnAllProducts()
        {
            for(int i = 0;i < _products.Length;i++)
            {
                _products[i].TurnOn();
            }
        }

        public void TurnOffAllProducts()
        {
            for (int i = 0; i < _products.Length; i++)
            {
                _products[i].TurnOff();
            }
        }

        public void Error(string errDesc)
        {
            Console.WriteLine(errDesc);
        }
    }
}
