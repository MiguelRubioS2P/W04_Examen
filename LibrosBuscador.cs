using MySql.Data.MySqlClient;
using Dapper;
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
    public partial class LibrosBuscador : Form
    {
        //Creamos una variable global para manejar la conexión con la base de datos.
        private string connectionMysql = "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16";
        AutorBuscador autorForm = null;
        bool existe = false;
        public LibrosBuscador()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Creamos una list para añadir todos los datos que obtengamos de la BBDD
            List<Libro> libros = new List<Libro>();

            //Creamos la conexión con la BBDD 
            MySqlConnection connection = new MySqlConnection(connectionMysql);

            //Creamos una variable para guardar la query
            string sql = $"select llibres.ID_LLIB, llibres.DESCRIP_LLIB, llibres.TITOL, autors.ID_AUT, autors.NOM_AUT  from autors, lli_aut, llibres where llibres.ID_LLIB = lli_aut.FK_IDLLIB and autors.ID_AUT = lli_aut.FK_IDAUT and llibres.titol like '%{textBoxBuscador.Text}%'";

            //Añadimos la lista mediante dapper
            libros = connection.Query<Libro>(sql).ToList();

            //Tenemos 3 maneras de añadir los datos al listbox

            //Primer método
            //for (int i = 0; i < libros.Count; i++)
            //{
            //    listBoxLibros.Items.Add(libros[i].TITOL);
            //}

            //Segundo método
            //foreach (var libro in libros)
            //{
            //    listBoxLibros.Items.Add(libro.ID_LLIB + ". " + " " + libro.TITOL);
            //}

            //Tercer método
            listBoxLibros.DataSource = libros;
            listBoxLibros.DisplayMember = "FullInfo";

            //Cerramos conexión
            connection.Close();

        }

        private void buttonIrAutores_Click(object sender, EventArgs e)
        {

            this.Hide();
            if (!existe)
            {
                autorForm = new AutorBuscador();
                autorForm.Show();
                autorForm.Location = new Point(this.Location.X + this.Size.Width + 10,
                    this.Location.Y);
                existe = true;
            }

            autorForm?.Show();

        }

        private void listBoxLibros_DoubleClick(object sender, EventArgs e)
        {
            //Creamos un libro con el elemento seleccionado
            Libro selectedBook = listBoxLibros.SelectedItem as Libro;

            //Creamos un form con el libro
            InfoLibro modal = new InfoLibro(selectedBook);

            //Hacemos que sea tipo dialogo
            DialogResult result = modal.ShowDialog(this);

            //Controlamos los botones, no funciona actualmente
            if (result == DialogResult.OK)
            {



            }
            else if (result == DialogResult.Cancel)
            {



            }

            //Libera recursos de memoria
            modal.Dispose();

        }
    }
}
