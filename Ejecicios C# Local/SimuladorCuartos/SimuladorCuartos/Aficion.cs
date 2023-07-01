using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCuartos
{
    class Aficion
    {
        public Aficion(string paramSeleccion, int paramAficion)
        {
            aficion = paramAficion;
            seleccion = paramSeleccion;
        }

        public string getSeleccion()
        {
            return seleccion;
        }

        public int getAficion()
        {
            return aficion;
        }

        int aficion;
        string seleccion;
    }
}
