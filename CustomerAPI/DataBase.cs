using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI
{
    public class DataBase
    {
        public static List<Customer> GetAllCustomer()
        {
            List<Customer> list = new List<Customer>();

            Customer c1 = new Customer();
            c1._id = 1;
            c1.name = "João da Silva";
            c1.type = "1";
            c1.cpf = "11111111111";
            c1.indicator = "2";
            c1.rg = "11111111";
            c1.email = "joao@email.com";
            c1.workPhone = "271234567";
            c1.personalPhone = "99999999";

            Customer c2 = new Customer();
            c2._id = 2;
            c2.name = "Maria José";
            c2.type = "1";
            c2.cpf = "22222222222";
            c2.indicator = "3";
            c2.rg = "22222222";
            c2.email = "maria@email.com";
            c2.workPhone = "271234567";
            c2.personalPhone = "99999999";

            Customer c3 = new Customer();
            c3._id = 3;
            c3.name = "Larissa";
            c3.type = "1";
            c3.cpf = "33333333333";
            c3.indicator = "3";
            c3.rg = "33333333";
            c3.email = "larissa@email.com";
            c3.workPhone = "271234567";
            c3.personalPhone = "99999999";

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);

            return list;
        }
    }
}
