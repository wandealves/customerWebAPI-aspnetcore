using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI
{
    public class Customer
    {
        public int _id { get; set; }
        public string name { get; set; }

        public string type { get; set; }

        public string cpf { get; set; }

        public string indicator { get; set; }

        public string rg { get; set; }

        public string email { get; set; }

        public string workPhone { get; set; }

        public string personalPhone { get; set; }
        public Customer()
        {
        }
    }
}
