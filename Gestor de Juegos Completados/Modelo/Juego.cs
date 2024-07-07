using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Juegos_Completados
{
    public class Juego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Completado { get; set; }

        public string Cienporciento { get; set; }

        public string Logros { get; set; }

        public int cantidadVeces { get; set; }

        public int Nota { get; set; }

        public DateTime Fecha { get; set; }
    }
}
