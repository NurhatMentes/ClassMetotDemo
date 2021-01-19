using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
           

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Nurhat";
            customer1.LastName = "Menteş";
            customer1.Address = "İstanbul";
            customerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Yunus";
            customer2.LastName = "Emre";
            customer2.Address = "Ankara";
            customerManager.Add(customer2);

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Zeynep";
            customer3.LastName = "Sarıdağ";
            customer3.Address = "Konya";
            customerManager.Add(customer3);


 
            Customer[] customers = new Customer[]{customer1,customer2,customer3};

            Console.WriteLine("----------------------------ALL CUSTOMERS-------------------------");
            //we have listed all customers
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + ":" + customer.FirstName + " " + customer.LastName + " " + customer.Address);

                Console.WriteLine("-----------------------------------------------------------------");
            }


            Console.ReadLine();
        }
    }
}
