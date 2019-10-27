using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W05_ExamenRegistroEncontrar.Clases
{
    public class Usuario
    {

        public int ID_USR { get; set; }
        public string DNI_USR { get; set; }
        public string NOM_USR { get; set; }
        public string LLINATGE1 { get; set; }
        public string POB_USR { get; set; }
        public string EMAIL_USR { get; set; }
        public string PASSWORD { get; set; }
        public string infoUser
        {
            get
            {
                return ID_USR + ":\t" + NOM_USR;
            }
        }

    }
}
