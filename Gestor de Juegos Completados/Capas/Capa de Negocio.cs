using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Juegos_Completados
{
    public class Capa_de_Negocio
    {
        Capa_de_Acceso_a_Datos _capaDeAccesoADatos;

        public Capa_de_Negocio()
        {
            _capaDeAccesoADatos = new Capa_de_Acceso_a_Datos();
        }

        public Juego SalvarJuego(Juego juego)
        {
            if (juego.Id == 0)
                _capaDeAccesoADatos.InsertarJuego(juego);
            else
                _capaDeAccesoADatos.ActualizarJuego(juego);

            return juego;
        }

        public void BorrarJuego(int id)
        {
            _capaDeAccesoADatos.BorrarJuego(id);
        }

        public List<Juego> GetJuegos(string buscar = null)
        {
            return _capaDeAccesoADatos.GetJuegos(buscar);
        }


    }
}
