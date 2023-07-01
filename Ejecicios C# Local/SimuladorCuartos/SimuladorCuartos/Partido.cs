using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCuartos
{
    class Partido
    {
        string nT1;
        double t1;
        string nT2;
        double t2;
        public Partido(string nT1, double t1, string nT2, double t2)
        {
            Console.WriteLine($"{nT1} vs {nT2}");

            this.nT1 = nT1;
            this.t1 = t1;
            this.nT2 = nT2;
            this.t2 = t2;
        }

          public string ResultadoFinal()
            {


                Random goles = new Random();


                //Goles equipo 1
                double golesPromedioEquipo1 = t1 / 15;
                int MarcadorT1 = goles.Next((int)golesPromedioEquipo1, 5);


            //Goles equipo 2
            double golesPromedioEquipo2 = t2 / 15;
            int MarcadorT2 = goles.Next((int)golesPromedioEquipo2, 5);


                if (MarcadorT1 > MarcadorT2)
                {
                    Console.WriteLine($"{nT1} {MarcadorT1} - {MarcadorT2} {nT2}");

                    return $"Avanza {nT1}";
                }

                else if (MarcadorT1 == MarcadorT2)
                {
                    Console.WriteLine($"{nT1} {MarcadorT1} - {MarcadorT2} {nT2}");
                    
                return $"Avanza {nT2} por penaltis";

                }

                else
                {
                    Console.WriteLine($"{nT1} {MarcadorT1} - {MarcadorT2} {nT2}");
                   
                return $"Avanza {nT2}";
                }

            }
        
    }
}
