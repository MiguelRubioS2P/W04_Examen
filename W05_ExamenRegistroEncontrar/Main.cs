using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W05_ExamenRegistroEncontrar.Clases;

namespace W05_ExamenRegistroEncontrar
{
    public partial class Main : Form
    {
        //Creamos variable de conexión a BBDD
        private const string connectionString = "Server=localhost;Database=biblioteca;Uid=usuari;Pwd=seCret_16";
        public Main()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //Controlamos que sean los mismos valores
            if (textBoxContra.Text == textBoxCContra.Text)
            {
                //Conexión a BBDD
                MySqlConnection con = new MySqlConnection(connectionString);

                //Necesitamos obtener la última id que hay en la tabla 
                string sql = "select max(ID_USR) from USUARIS";
                
                //Por si no hay iniciamos una variable en 0
                int newId = 0;

                try
                {

                    newId = con.Query<int>(sql).FirstOrDefault();

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Warning: Exception thrown " + ex.Message);

                }

                string sqlInsert = $"insert into USUARIS (id_usr, dni_usr, nom_usr, llinatge1, pob_usr, email_usr, password) values" +
                $" ({newId + 1},'{textBoxDni.Text}','{textBoxNombre.Text}','{textBoxApellidos.Text}','{comboBoxPoblacion.Text}','{textBoxEmail.Text}'," +
                $"'{textBoxContra.Text}')";


                try
                {

                    var rowsAffected = con.Execute(sqlInsert);

                    if (rowsAffected == 1)
                    {
                        //una ventana de dialogo
                        MessageBox.Show("User registered correctly", "User Manager", MessageBoxButtons.OK);

                        // "" es menos seguro que poner string.Empty
                        textBoxDni.Text = string.Empty;
                        textBoxNombre.Text = string.Empty;
                        textBoxApellidos.Text = string.Empty;
                        comboBoxPoblacion.Text = string.Empty;
                        textBoxEmail.Text = string.Empty;
                        textBoxContra.Text = string.Empty;
                        textBoxCContra.Text = string.Empty;

                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    Console.WriteLine("Warning: Exception thrown " + ex.Message);

                }


                con.Close();

            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            List<Usuario> userName = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"select * from USUARIS where NOM_USR like '%{textBoxBuscador.Text}%' or LLINATGE1 like '%{textBoxBuscador.Text}%' or POB_USR like '%{textBoxBuscador.Text}%'";
            userName = connection.Query<Usuario>(sql).ToList();

            if (userName.Count == 0)
            {
                //modal para dar feedback al usuario
                MessageBox.Show("Is Empty", "User Manager", MessageBoxButtons.OK);
            }
            else
            {
                listBoxUsuarios.DataSource = userName;
                listBoxUsuarios.DisplayMember = "infoUser";
            }


            textBoxBuscador.Text = string.Empty;

            connection.Close();

        }

        private void textBoxBuscador_Click(object sender, EventArgs e)
        {
            //truco para vaciar el listbox
            List<Usuario> vaciar = new List<Usuario>();
            listBoxUsuarios.DataSource = vaciar;
        }
    }
}
