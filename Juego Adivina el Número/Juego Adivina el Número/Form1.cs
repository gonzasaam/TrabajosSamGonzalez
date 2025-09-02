using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Adivina_el_Número
{
    public partial class Form1 : Form
    {
        private readonly Random _rng = new Random();
        private int _secreto;
        private int _intentos;
        private bool _ganado;

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
            this.AcceptButton = btnProbar; // Enter presiona "Probar"
        }

        private void IniciarJuego()
        {
            _secreto = _rng.Next(1, 101); // 1..100
            _intentos = 0;
            _ganado = false;

            lblMensaje.Text = "Estoy pensando un número del 1 al 100…";
            lblContador.Text = "Intentos: 0";
            lstIntentos.Items.Clear();
            txtIntento.Clear();
            txtIntento.Enabled = true;
            btnProbar.Enabled = true;
            txtIntento.Focus();
        
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            if (_ganado) return;

            // Validación básica
            if (!int.TryParse(txtIntento.Text.Trim(), out int n))
            {
                MessageBox.Show("Escribe un número entero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntento.SelectAll();
                txtIntento.Focus();
                return;
            }
            if (n < 1 || n > 100)
            {
                MessageBox.Show("El número debe estar entre 1 y 100.", "Fuera de rango",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntento.SelectAll();
                txtIntento.Focus();
                return;
            }

            _intentos++;
            lblContador.Text = $"Intentos: {_intentos}";

            string resultado;
            if (n < _secreto) resultado = $"{n} es MENOR que el número secreto.";
            else if (n > _secreto) resultado = $"{n} es MAYOR que el número secreto.";
            else
            {
                resultado = $"¡Acertaste! El número era {n}.";
                _ganado = true;
                txtIntento.Enabled = false;
                btnProbar.Enabled = false;
                MessageBox.Show($"¡Felicitaciones! Ganaste en {_intentos} intentos.", "¡Bien hecho!");
            }

            lstIntentos.Items.Add($"Intento {_intentos}: {resultado}");
            lblMensaje.Text = resultado;

            txtIntento.SelectAll();
            txtIntento.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            IniciarJuego();
        }
    }
}
