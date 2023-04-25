using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static linqNforeach.Program;

namespace linqNforeach
{
    class Program
    {
        public class Customer
        {
            public string Name { get; set; }
            public int dogsOwned { get; set; }

            public Customer(string name, int dogsowned) 
            {
                Name = name;
                dogsOwned = dogsowned;
            }
        }
        static void Main(string[] args)
        {
            Customer[] cst = new Customer[4];
            cst[0] = new Customer("Kenneth", 3);
            cst[0] = new Customer("Khailah", 1);
            cst[0] = new Customer("Dhorrene", 2);
            cst[0] = new Customer("Gabriel", 4);

            var res = from c in cst
                      where c.dogsOwned > 1
                      select c;

            foreach(var c in res) 
            {
                if (c.dogsOwned > 3 )
                {
                    Console.WriteLine(c.Name + " receives free dog consultation and treats!" );
                    Console.ReadLine();
                }
            }
        }
    }
}
