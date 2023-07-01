using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // Definir una clase Equipo con propiedades Nombre y Aficion
    class Equipo
    {
        public string Nombre { get; set; }
        public int Aficion { get; set; }
    }

    // Definir una lista de ocho equipos de Suramérica con sus respectivas aficiones
    static List<Equipo> equipos = new List<Equipo>()
    {
        new Equipo() { Nombre = "Brasil", Aficion = 100 },
        new Equipo() { Nombre = "Argentina", Aficion = 90 },
        new Equipo() { Nombre = "Colombia", Aficion = 80 },
        new Equipo() { Nombre = "Uruguay", Aficion = 70 },
        new Equipo() { Nombre = "Perú", Aficion = 60 },
        new Equipo() { Nombre = "Chile", Aficion = 50 },
        new Equipo() { Nombre = "Paraguay", Aficion = 40 },
        new Equipo() { Nombre = "Ecuador", Aficion = 30 }
    };

    // Definir un método que simula un partido entre dos equipos y devuelve el ganador
    static Equipo SimularPartido(Equipo equipo1, Equipo equipo2)
    {
        // Generar un número aleatorio entre 0 y la suma de las aficiones de los dos equipos
        Random random = new Random();
        int resultado = random.Next(0, equipo1.Aficion + equipo2.Aficion);

        // Si el número es menor que la afición del primer equipo, gana el primer equipo
        if (resultado < equipo1.Aficion)
        {
            return equipo1;
        }
        // Si no, gana el segundo equipo
        else
        {
            return equipo2;
        }
    }

    // Definir un método que simula una eliminatoria entre una lista de equipos y devuelve el campeón
    static Equipo SimularEliminatoria(List<Equipo> equipos)
    {
        // Mientras haya más de un equipo en la lista, seguir simulando partidos
        while (equipos.Count > 1)
        {
            // Crear una lista vacía para guardar los ganadores de cada partido
            List<Equipo> ganadores = new List<Equipo>();

            // Recorrer la lista de equipos de dos en dos
            for (int i = 0; i < equipos.Count; i += 2)
            {
                // Simular un partido entre el equipo i y el equipo i+1
                Equipo ganador = SimularPartido(equipos[i], equipos[i + 1]);

                // Añadir el ganador a la lista de ganadores
                ganadores.Add(ganador);

                // Mostrar el resultado del partido
                Console.WriteLine($"{equipos[i].Nombre} vs {equipos[i + 1].Nombre} => {ganador.Nombre}");
            }

            // Reemplazar la lista de equipos por la lista de ganadores
            equipos = ganadores;

            // Dejar una línea en blanco entre cada ronda
            Console.WriteLine();
        }

        // Devolver el único equipo que queda en la lista, que es el campeón
        return equipos[0];
    }

    static void Main(string[] args)
    {
        // Crear una variable para controlar el bucle
        bool continuar = true;

        // Mientras el usuario quiera continuar, hacer otro simulacro
        while (continuar)
        {
            // Ordenar la lista de equipos aleatoriamente usando LINQ
            var equiposOrdenados = equipos.OrderBy(e => Guid.NewGuid()).ToList();

            // Simular una eliminatoria con los equipos ordenados y obtener el campeón
            Equipo campeon = SimularEliminatoria(equiposOrdenados);

            // Mostrar el campeón
            Console.WriteLine($"El campeón es {campeon.Nombre}!");

            // Preguntar al usuario si quiere hacer otro simulacro
            Console.WriteLine("¿Quieres hacer otro simulacro? (S/N)");
            string respuesta = Console.ReadLine();

            // Si la respuesta es N, salir del bucle
            if (respuesta == "N")
            {
                continuar = false;
            }
        }
    }
}