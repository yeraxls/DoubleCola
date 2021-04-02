using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Cola
{
    class QueueManagement
    {
        public void EmpezarCuenta(int num, List<string> personajes)
        {
            if (personajes.Count > num)
                Console.WriteLine(personajes[num - 1]);
            else
                PrimeraAmpliacionLista(num, personajes);
            Console.ReadLine();
        }

        private void PrimeraAmpliacionLista(int num, List<string> personajes)
        {
            int indice = 0;
            while(personajes.Count< num)
            {
                personajes.Add(personajes[indice]);
                personajes.Add(personajes[indice]);
                indice++;
            }

            Console.WriteLine(personajes[num]);

        }
    }
}
