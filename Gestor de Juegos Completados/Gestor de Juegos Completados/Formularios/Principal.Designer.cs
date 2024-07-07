
namespace Gestor_de_Juegos_Completados
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cienporcientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juegoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AutoGenerateColumns = false;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.completadoDataGridViewTextBoxColumn,
            this.cienporcientoDataGridViewTextBoxColumn,
            this.logrosDataGridViewTextBoxColumn,
            this.cantidadVecesDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.Editar,
            this.Borrar});
            this.dgvJuegos.DataSource = this.juegoBindingSource;
            this.dgvJuegos.Location = new System.Drawing.Point(30, 67);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(745, 369);
            this.dgvJuegos.TabIndex = 0;
            this.dgvJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForLinkValue = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(30, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(514, 29);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(560, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(653, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // completadoDataGridViewTextBoxColumn
            // 
            this.completadoDataGridViewTextBoxColumn.DataPropertyName = "Completado";
            this.completadoDataGridViewTextBoxColumn.HeaderText = "Completado";
            this.completadoDataGridViewTextBoxColumn.Name = "completadoDataGridViewTextBoxColumn";
            // 
            // cienporcientoDataGridViewTextBoxColumn
            // 
            this.cienporcientoDataGridViewTextBoxColumn.DataPropertyName = "Cienporciento";
            this.cienporcientoDataGridViewTextBoxColumn.HeaderText = "Cienporciento";
            this.cienporcientoDataGridViewTextBoxColumn.Name = "cienporcientoDataGridViewTextBoxColumn";
            // 
            // logrosDataGridViewTextBoxColumn
            // 
            this.logrosDataGridViewTextBoxColumn.DataPropertyName = "Logros";
            this.logrosDataGridViewTextBoxColumn.HeaderText = "Logros";
            this.logrosDataGridViewTextBoxColumn.Name = "logrosDataGridViewTextBoxColumn";
            // 
            // cantidadVecesDataGridViewTextBoxColumn
            // 
            this.cantidadVecesDataGridViewTextBoxColumn.DataPropertyName = "cantidadVeces";
            this.cantidadVecesDataGridViewTextBoxColumn.HeaderText = "cantidadVeces";
            this.cantidadVecesDataGridViewTextBoxColumn.Name = "cantidadVecesDataGridViewTextBoxColumn";
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // juegoBindingSource
            // 
            this.juegoBindingSource.DataSource = typeof(Gestor_de_Juegos_Completados.Juego);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 470);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvJuegos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Juegos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource juegoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cienporcientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Borrar;
    }
}

