using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Juegos_Completados
{
    public partial class DatosJuegos : Form
    {
        private Capa_de_Negocio _capaDeNegocio;
        private Juego _juego;
        public DatosJuegos()
        {
            InitializeComponent();
            _capaDeNegocio = new Capa_de_Negocio();
        }

        #region EVENTOS
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarJuego();
            Mensaje();
            this.Close();
            ((Principal)this.Owner).PopulateJuegos();
        }

        #endregion

        #region METODOS PRIVADOS

        private void GuardarJuego()
        {
            Juego juego = new Juego();

            juego.Nombre = txtNombre.Text;
            juego.Completado = cboCompletado.Text;
            juego.Cienporciento = cboCienPorciento.Text;
            juego.Logros = cboLogros.Text;
            juego.cantidadVeces = int.Parse(cboCantidad.Text);
            juego.Nota = int.Parse(cboNota.Text);
            juego.Fecha = dtpFecha.Value;

            juego.Id = _juego != null ? _juego.Id : 0;

            _capaDeNegocio.SalvarJuego(juego);
        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            cboCompletado.Text = string.Empty;
            cboCienPorciento.Text = string.Empty;
            cboLogros.Text = string.Empty;
            cboCantidad.Text = string.Empty;
            cboNota.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
        }

        private void Mensaje()
        {
            if (_juego != null)
            {
                MessageBox.Show("Juego Actualizado Correctamente", "¡Aviso!");
            }
            else
                MessageBox.Show("Juego Agregado Correctamente", "¡Aviso!");
        }

        #endregion

        #region METODOS PUBLICOS

        public void CargarJuego(Juego juego)
        {
            _juego = juego; //para traer el id, al objeto juego.
            if (juego != null)
            {
                LimpiarForm();

                txtNombre.Text = juego.Nombre;
                cboCompletado.Text = juego.Completado;
                cboCienPorciento.Text = juego.Cienporciento;
                cboLogros.Text = juego.Logros;
                cboCantidad.Text = juego.cantidadVeces.ToString();
                cboNota.Text = juego.Nota.ToString();
                dtpFecha.Value = juego.Fecha;
            }
        }


        #endregion
    }
}
