using System;
using System.Collections.Generic;
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
            // Verificar que el índice de la fila y la columna sean válidos
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar que la celda sea un DataGridViewLinkCell
                if (dgvJuegos.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell celda)
                {
                    // Verificar que el valor de la celda no sea nulo y sea una cadena
                    if (celda.Value != null && celda.Value is string value)
                    {
                        if (value == "Editar")
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
                        else if (value == "Borrar")
                        {
                            if (MessageBox.Show("¿Queres eliminar este juego?", "¡Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                BorrarJuego(int.Parse((dgvJuegos.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                                MessageBox.Show("Juego Eliminado", "Confirmación");
                                PopulateJuegos();
                            }
                            else
                                PopulateJuegos();
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateJuegos(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
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

