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
    public partial class InfoLibro : Form
    {
        //Creamos una variable para tener el libro seleccionado con el constructor
        Libro _selectedBook;
        public InfoLibro(Libro selected)
        {
            InitializeComponent();

            //Pasamos el libro seleccionado
            _selectedBook = selected;
        }

        private void InfoLibro_Load(object sender, EventArgs e)
        {
            //Creamos el libro que obtenemos para cargar los datos
            Libro prueba = _selectedBook;
            //añadimos los datos donde se necesitan.
            labelTextoTitulo.Text = prueba.TITOL;
            labelTextoDescripcion.Text = prueba.Descrip_Llib;
            labelTextoAutor.Text = prueba.NOM_AUT;

        }
    }
}
