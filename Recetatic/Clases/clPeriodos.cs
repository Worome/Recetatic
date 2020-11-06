using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetatic.Clases
{
    public class clPeriodos
    {
        private int codigo;
        private string periodo;

        public clPeriodos()
        {
            Codigo = 0;
            Periodo = "";
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Periodo { get => periodo; set => periodo = value; }
    }
}
