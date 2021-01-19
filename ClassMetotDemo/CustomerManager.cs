
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        //Normally there are database operations in this section.
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Adlı Müsteri Başarıyla Eklendi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Id + "no'lu Müşteri Güncellenmiştir.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + "no'lu Müşteri Silinmiştir.");
        }
    }
}
