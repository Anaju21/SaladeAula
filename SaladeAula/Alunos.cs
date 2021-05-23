using System;
using System.Collections.Generic;
using System.Text;

namespace SaladeAula
{


    public class Alunos: Cursos
    {
        string nome;
        string falta;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Falta
        {
            get { return falta; }
            set { falta = value; }
        }







    }
}
