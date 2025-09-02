namespace Juego_Adivina_el_Número
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.txtIntento = new System.Windows.Forms.TextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lstIntentos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Adivina el número (1-100)";
            // 
            // labelIngreso
            // 
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Location = new System.Drawing.Point(16, 42);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(95, 13);
            this.labelIngreso.TabIndex = 1;
            this.labelIngreso.Text = "Ingresa un número";
            // 
            // txtIntento
            // 
            this.txtIntento.Location = new System.Drawing.Point(19, 76);
            this.txtIntento.Name = "txtIntento";
            this.txtIntento.Size = new System.Drawing.Size(100, 20);
            this.txtIntento.TabIndex = 2;
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(16, 114);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(75, 23);
            this.btnProbar.TabIndex = 3;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(16, 152);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(203, 13);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Estoy pensando un número del 1 al 100...";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(16, 185);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(57, 13);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "Intentos: 0";
            // 
            // lstIntentos
            // 
            this.lstIntentos.FormattingEnabled = true;
            this.lstIntentos.Location = new System.Drawing.Point(16, 214);
            this.lstIntentos.Name = "lstIntentos";
            this.lstIntentos.Size = new System.Drawing.Size(120, 95);
            this.lstIntentos.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 316);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo Juego";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstIntentos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.txtIntento);
            this.Controls.Add(this.labelIngreso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Juego Adivina el Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.TextBox txtIntento;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ListBox lstIntentos;
        private System.Windows.Forms.Button btnNuevo;
    }
}

