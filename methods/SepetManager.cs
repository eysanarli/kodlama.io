using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product) 
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + product.Name);

           
  
            
        }

        public void Ekle2 (string productName, string explanation, double price, int stock)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + productName);
        }
    }
}
