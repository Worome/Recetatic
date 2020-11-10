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
        private string codigo;
        private string periodo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Periodo { get => periodo; set => periodo = value; }

        public clPeriodos()
        {
            Codigo = "";
            Periodo = "";
        }

    }
}
