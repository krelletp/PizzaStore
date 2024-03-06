using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Store
    {
        public void Start()
        {
            
            Pizza p1 = new Pizza("Margherita", 65);
            Pizza p2 = new Pizza("Calzone", 95);
            Pizza p3 = new Pizza("Fire årstider", 105);

            
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();

            // Creating Order objects with correct associations
            Order o1 = new Order(p1, c1);
            Order o2 = new Order(p2, c2);
            Order o3 = new Order(p3, c3);

            // Printing order information
            Console.WriteLine("Order Information:");
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
        }

    }
}