using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;


namespace WindowsFormsApp1
{
    public partial class From1 : Form
    {
        private Button btnCargarProductos;
        private ListBox lstProductos;

        public Form1()
        {
            //boton para cargar los productos 
            btnCargarProductos = new Button();
            btnCargarProductos.Text = "OK";
            btnCargarProductos.Location = new Point(10, 10);
            btnCargarProductos.Size = new Size(120, 50);

            // suscribir el evento click al boton 
            btnCargarProductos.Click += new EventHandler(btnCargarProductos_Click);

            lstProductos = new ListBox();
            lstProductos.Location = new Point(10, 60);
            lstProductos.Size = new Size(300, 300);
            lstProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            //añadir botones al formulario para mostrarlos
            this.Controls.Add(lstProductos);
            this.Controls.Add(btnCargarProductos);

            //configurar las propiedades del formulario 
            this.Text = "OK";
            this.ClientSize = new Size(320, 370);
        }
        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();

            //try catch evita ecepciones, avisa lo que esta fallando 

            try
            {
                //string de la conexion de su app

                string connetionString = ConfigurationManager.ConnectionString["MiConexionBD"].ConnectionString;
                string query = "SELECT Nombre, Precio FROM Productos ORDER BY  Nombre;";

                using (SqlConnection conecction = new SqlConnection(connetionString))

                using (SqlCommand command = new SqlCommand(query, conecction)
                {
                       Connection.Open();

                     using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        decimal precio = Convert.ToDecimal(reader["Precio"]);

                        lstProductos.Items.Add($"{nombre} - ${precio:N2}");

                    }
                    



                  }




            }
        }
    }
}
