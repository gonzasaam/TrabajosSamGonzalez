namespace Estudiantes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(318, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(56, 136);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(56, 196);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 3:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(56, 270);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(398, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar estudiante";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar estudiante";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(398, 222);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 23);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar a txt";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colNota1,
            this.colNota2,
            this.colNota3,
            this.colPromedio,
            this.colEstado});
            this.dgvEstudiantes.Location = new System.Drawing.Point(175, 288);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(410, 150);
            this.dgvEstudiantes.TabIndex = 11;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colNota1
            // 
            this.colNota1.HeaderText = "Nota 1";
            this.colNota1.Name = "colNota1";
            this.colNota1.ReadOnly = true;
            // 
            // colNota2
            // 
            this.colNota2.HeaderText = "Nota 2";
            this.colNota2.Name = "colNota2";
            this.colNota2.ReadOnly = true;
            // 
            // colNota3
            // 
            this.colNota3.HeaderText = "Nota 3";
            this.colNota3.Name = "colNota3";
            this.colNota3.ReadOnly = true;
            // 
            // colPromedio
            // 
            this.colPromedio.HeaderText = "Promedio";
            this.colPromedio.Name = "colPromedio";
            this.colPromedio.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}

