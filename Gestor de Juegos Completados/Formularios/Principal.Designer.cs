
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
            this.dgvJuegos.AllowUserToAddRows = false;
            this.dgvJuegos.AllowUserToDeleteRows = false;
            this.dgvJuegos.AllowUserToResizeColumns = false;
            this.dgvJuegos.AllowUserToResizeRows = false;
            this.dgvJuegos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJuegos.AutoGenerateColumns = false;
            this.dgvJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJuegos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.dgvJuegos.ReadOnly = true;
            this.dgvJuegos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJuegos.Size = new System.Drawing.Size(1041, 385);
            this.dgvJuegos.TabIndex = 0;
            this.dgvJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.FillWeight = 84F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Borrar
            // 
            this.Borrar.FillWeight = 80F;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForLinkValue = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(30, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(810, 29);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Ingrese un juego...";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(856, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(949, 26);
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
            this.idDataGridViewTextBoxColumn.FillWeight = 55F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // completadoDataGridViewTextBoxColumn
            // 
            this.completadoDataGridViewTextBoxColumn.DataPropertyName = "Completado";
            this.completadoDataGridViewTextBoxColumn.HeaderText = "Completado";
            this.completadoDataGridViewTextBoxColumn.Name = "completadoDataGridViewTextBoxColumn";
            this.completadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.completadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cienporcientoDataGridViewTextBoxColumn
            // 
            this.cienporcientoDataGridViewTextBoxColumn.DataPropertyName = "Cienporciento";
            this.cienporcientoDataGridViewTextBoxColumn.FillWeight = 114F;
            this.cienporcientoDataGridViewTextBoxColumn.HeaderText = "Cienporciento";
            this.cienporcientoDataGridViewTextBoxColumn.Name = "cienporcientoDataGridViewTextBoxColumn";
            this.cienporcientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cienporcientoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // logrosDataGridViewTextBoxColumn
            // 
            this.logrosDataGridViewTextBoxColumn.DataPropertyName = "Logros";
            this.logrosDataGridViewTextBoxColumn.FillWeight = 107F;
            this.logrosDataGridViewTextBoxColumn.HeaderText = "Logros";
            this.logrosDataGridViewTextBoxColumn.Name = "logrosDataGridViewTextBoxColumn";
            this.logrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.logrosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadVecesDataGridViewTextBoxColumn
            // 
            this.cantidadVecesDataGridViewTextBoxColumn.DataPropertyName = "cantidadVeces";
            this.cantidadVecesDataGridViewTextBoxColumn.HeaderText = "Cantidad de Veces";
            this.cantidadVecesDataGridViewTextBoxColumn.Name = "cantidadVecesDataGridViewTextBoxColumn";
            this.cantidadVecesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadVecesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.FillWeight = 95F;
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 89F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvJuegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

