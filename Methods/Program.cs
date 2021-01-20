using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            
            product1.Name = "Elma";
            product1.Price = 7.5;
            product1.Explaining = "Amasya";

            Product product2 = new Product();
           
            product2.Name = "Kiraz";
            product2.Price = 5.5;
            product2.Explaining = "Taze kiraz";

            Product[] products = new Product[] {product1,product2 };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i].Price);
            //}
            //Console.WriteLine("**************");
            foreach (var product in products)
            {
                
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explaining);
                Console.WriteLine("------------");
                
            }
            Console.WriteLine("***** METHODS *****");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            //Console.WriteLine();
            // HATALI KULLANIMIN KODU;
            basketManager.Add2("Armut","Yeşil Armut",10);

            Console.ReadLine();
        }

        
    }
    
}
