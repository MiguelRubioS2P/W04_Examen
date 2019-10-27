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

namespace W04_Examen
{
    public partial class AutorBuscador : Form
    {

        private string connectionMysql = "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16";

        public AutorBuscador()
        {
            InitializeComponent();
        }

        private void buttonBuscador_Click(object sender, EventArgs e)
        {

            List<Autor> autores = new List<Autor>();
            MySqlConnection connection = new MySqlConnection(connectionMysql);
            string sql = $"select * from autors where" +
                $" NOM_AUT like '%{textBoxBuscador.Text}%'";
            autores = connection.Query<Autor>(sql).ToList();

            listBoxAutores.DataSource = autores;
            listBoxAutores.DisplayMember = "FullInfo";

            connection.Close();

        }

        private void buttonIrLibros_Click(object sender, EventArgs e)
        {
            //Ocultamos este form
            this.Hide();

            //Creamos una variable para tener todos los form abiertos
            var forms = Application.OpenForms;

            //Bucle para encontrar el que tenga el nombre que deseamos
            foreach (Form form in forms)
            {
                if (form.Name == "LibrosBuscador")
                {
                    form.Show();
                }
            }

        }

        private void AutorBuscador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
