using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { "Elma, Karpuz" };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";


            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[]{product1, product2};

            foreach (Product product in products)
            {

                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("--------Methods------");


            //instance-

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 3);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 4);


            Console.ReadKey();
               
        }
    }
}


// do not repeat yourself- DRY - Clean Code - Best Practice 