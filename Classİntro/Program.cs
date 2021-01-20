using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.KursAdı = "c#";
            course.İzlenmeOrani = 12;
            course.Egitmen = "Engin";
            Console.WriteLine(course.KursAdı + ":" + course.İzlenmeOrani);


            Console.WriteLine("***********");

            ProductReplit product1 = new ProductReplit() { Name = "Laptop", Price = 5500 };
            ProductReplit product2 = new ProductReplit() { Name = "Mouse", Price = 150 };
            ProductReplit product3 = new ProductReplit() { Name = "Klavye", Price = 250 };

            ProductReplit[] products = new ProductReplit[] { product1, product2, product3 };
            Console.WriteLine("---for---");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name + ":" + products[i].Price);
            }
            Console.WriteLine("---ForEach---");
            foreach (var product in products)
            {
                Console.WriteLine(product.Name + ":" + product.Price);
            }
            Console.WriteLine("---While---");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Name + ":" +products[j].Price);
                j += 1;
            }
            Console.ReadLine();

        }
    }
    class Course
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }

}

