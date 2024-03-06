using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Customer
    {
        public string? Name { get; set; }
        public bool IsClubMember { get; set; }

        public void JoinClub()
        {
            IsClubMember = true;
            Console.WriteLine($"{Name} joined the customer club.");
            
        }

        public override string ToString()
        {
            return $"Customer: {Name} - Club Member: {IsClubMember}";
        }
    }
}