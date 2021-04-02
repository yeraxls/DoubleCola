using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string> {
                "Sheldon",
                "Leonard",
                "Penny",
                "Rajesh",
                "Howard"
            };
            var cola = new QueueManagement();
            cola.EmpezarCuenta(723070, lista);
        }
    }
}
