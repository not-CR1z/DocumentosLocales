using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equipos + Afición por millones

            Aficion Argentina = new Aficion("Argentina",40);
            Aficion Brasil = new Aficion("Brasil",50);
            Aficion Colombia = new Aficion("Colombia",18);
            Aficion Chile = new Aficion("Chile",15);
            Aficion Bolivia = new Aficion("Bolvia",5);
            Aficion Uruguay = new Aficion("Uruguay",20);
            Aficion Peru = new Aficion("Perú",15);
            Aficion Venezuela = new Aficion("Venezuela",10);

            Partido()
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


        Aficion[] Match1 = new Aficion[2];
            Match1[0] = Argentina;
            Match1[1] = Venezuela;

            //Selección

            string seleccionArgentina = Argentina.getSeleccion();
            string seleccionBrasil = Brasil.getSeleccion();
            string seleccionColombia = Colombia.getSeleccion();
            string seleccionBolivia = Bolivia.getSeleccion();
            string seleccionChile = Chile.getSeleccion();
            string seleccionUruguay = Uruguay.getSeleccion();
            string seleccionPeru = Peru.getSeleccion();
            string seleccionVenezuela = Venezuela.getSeleccion();


            //Promedio de goles

            double golesArg = Argentina.getAficion();
            double golesBra = Brasil.getAficion();
            double golesCol = Colombia.getAficion();
            double golesChi = Chile.getAficion();
            double golesBol = Bolivia.getAficion();
            double golesUru = Uruguay.getAficion();
            double golesPer = Peru.getAficion();
            double golesVen = Venezuela.getAficion();

            //Partido cuartos

            Partido Match1 = new Partido(seleccionArgentina ,golesArg, seleccionVenezuela , golesVen);
            string resultado=Match1.ResultadoFinal();
            Console.WriteLine(resultado);


        }
    }
}
