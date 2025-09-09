using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {
                InitializeComponent();

                // Configurar columnas del DataGridView
                dgvEstudiantes.Columns.Add("Nombre", "Nombre");
                dgvEstudiantes.Columns.Add("Nota1", "Nota 1");
                dgvEstudiantes.Columns.Add("Nota2", "Nota 2");
                dgvEstudiantes.Columns.Add("Nota3", "Nota 3");
                dgvEstudiantes.Columns.Add("Promedio", "Promedio");
                dgvEstudiantes.Columns.Add("Estado", "Estado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);

                // Validar notas
                if (!ValidarNota(nota1) || !ValidarNota(nota2) || !ValidarNota(nota3))
                {
                    MessageBox.Show("Las notas deben estar entre 1.0 y 7.0");
                    return;
                }

                // Calcular promedio
                double promedio = (nota1 + nota2 + nota3) / 3;
                string estado = promedio >= 4.0 ? "Aprobado" : "Reprobado";

                // Agregar a la tabla
                dgvEstudiantes.Rows.Add(nombre, nota1, nota2, nota3, promedio.ToString("0.0"), estado);

                // Limpiar campos
                txtNombre.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos en las notas");
            }
        }

        private bool ValidarNota(double nota)
        {
            return nota >= 1.0 && nota <= 7.0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                dgvEstudiantes.Rows.RemoveAt(dgvEstudiantes.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivo de texto|*.txt";
            saveFile.Title = "Guardar estudiantes";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    foreach (DataGridViewRow row in dgvEstudiantes.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine(
                                $"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}, {row.Cells[4].Value}, {row.Cells[5].Value}"
                            );
                        }
                    }
                }
                MessageBox.Show("Datos exportados correctamente");
            }
        }
    }
}
    

