using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Order
    {
        double _taxPct;
        double _deliveryCosts;
        Pizza p;
        Customer c;

        
        public Order(Pizza pizza, Customer customer)
        {
            p = pizza;
            c = customer; 
            TaxPct = 25.0;
            DeliveryCosts = 40.0;
        }

        
        double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        double DeliveryCosts
        {
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }

        
        public override string ToString()
        {
            
            return $"Order Details:\n{p}\n{c}\nTaxPct: {TaxPct} - Delivery cost: {DeliveryCosts} - Total: {CalculateTotalPrice()} kr";
        }

        
        public double CalculateTotalPrice()
        {
            return p.Price * (1 + TaxPct / 100) + DeliveryCosts;
        }
    }
}