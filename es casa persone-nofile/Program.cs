using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_casa_persone_nofile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Persone = new List<Persona>();
            Console.WriteLine("n' persone:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("caratteristiche:");
                Persona p = Persona.Parse(Console.ReadLine());
                Persone.Add(p);
            }
            List<Persona> persone_maggiorenni = new List<Persona>();
            foreach (var Persona in Persone)
            {
                if (Persona.Eta >= 18)
                    Console.WriteLine(Persona.Nome);
            }
            Console.ReadKey();
        }
    }
}

