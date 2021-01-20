using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 10,
                Name = "Ali",
                Surname = "Deniz",
                Phone = 1234566

            };
            Customer customer2 = new Customer()
            {

                Id = 15,
                Name = "Emin",
                Surname = "Harran",
                Phone = 222333444,



            };
            Customer customer3 = new Customer()
            {

                Id = 586486,
                Name = "Rıza",
                Surname = "Kara",
                Phone = 233548

            };
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customers);
            customerManager.Add(customer1);
            customerManager.Delete(customer3);


            Console.ReadLine();



        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
    }
    class CustomerManager
    {
        public void Add(Customer customer)
        {

            Console.WriteLine("Hoşgeldiniz,Sizinle çalışmaktan dolayı çok mutluyuz Sayın : " + customer.Name + customer.Surname);

        }
        public void Delete(Customer customer)
        {

            Console.WriteLine("Sizleri tekrar aramızda görmek dileğiyle. Hoşcakalın " + customer.Name  +  customer.Surname);

        }
        public void CustomerList(Customer[] customers)
        {
            Console.WriteLine("Customer List:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Phone);
            }

        }




    }
}
