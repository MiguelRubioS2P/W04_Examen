using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04_Examen
{
    public class Libro
    {
        //Esta manera de declara los metodos es usando propiedades, por defecto pones 
        //el atributo y los metodos que debe tener, este caso get y set.
        public int ID_LLIB { get; set; }
        public string TITOL { get; set; }

        //Este atributo esta para poder usar dapper para mostrar los datos de manera mas sencilla
        public string FullInfo
        {
            get
            {
                return ID_LLIB + ":\t" + TITOL;
            }
        }
        public string Descrip_Llib { get; set; }
        public string NOM_AUT { get; set; }
    }
}
