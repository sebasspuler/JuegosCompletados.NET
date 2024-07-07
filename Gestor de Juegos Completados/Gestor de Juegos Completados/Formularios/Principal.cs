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
    public partial class Principal : Form
    {
        Capa_de_Negocio _capaDeNegocio;
        public Principal()
        {
            InitializeComponent();
            _capaDeNegocio = new Capa_de_Negocio();
        }

        #region EVENTOS

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirDatosJuegos();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PopulateJuegos();


        }

        private void dgvJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell celda = (DataGridViewLinkCell)dgvJuegos.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (celda.Value.ToString() == "Editar")
            {
                DatosJuegos datosJuegos = new DatosJuegos();
                datosJuegos.CargarJuego(new Juego
                {
                    Id = int.Parse((dgvJuegos.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Nombre = dgvJuegos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Completado = dgvJuegos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Cienporciento = dgvJuegos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Logros = dgvJuegos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    cantidadVeces = int.Parse(dgvJuegos.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    Nota = int.Parse(dgvJuegos.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    Fecha = DateTime.Parse(dgvJuegos.Rows[e.RowIndex].Cells[7].Value.ToString())
                });
                datosJuegos.ShowDialog(this);
            }
            else if (celda.Value.ToString() == "Borrar")
            {
                BorrarJuego(int.Parse((dgvJuegos.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                MessageBox.Show("Juego Eliminado", "¡Aviso!");
                PopulateJuegos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateJuegos(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }

        #endregion


        #region METODOS PRIVADOS

        private void AbrirDatosJuegos()
        {
            DatosJuegos datosJuegos = new DatosJuegos();
            datosJuegos.ShowDialog(this);
        }

        private void BorrarJuego(int id)
        {
            _capaDeNegocio.BorrarJuego(id);
        }

        #endregion

        #region METODOS PUBLICOS

        public void PopulateJuegos(string buscar = null)
        {
            List<Juego> juegos = _capaDeNegocio.GetJuegos(buscar);
            dgvJuegos.DataSource = juegos;
        }


        #endregion


    }
}
