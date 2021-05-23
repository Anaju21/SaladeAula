using System;
using System.Collections.Generic;
using System.Text;

namespace SaladeAula
{
    public class Cursos
    {
        string nome_curso;
        string materia1;
        string materia2;
        double Nota_materia1;
        double Nota_materia2;



        public string Nome_curso
        {
            get { return nome_curso; }
            set { nome_curso = value; }
        }

        public string Materia1
        {
            get { return materia1; }
            set { materia1 = value; }
        }

        public string Materia2
        {
            get { return materia2; }
            set { materia2 = value; }
        }

        public double Nota_Materia1
        {
            get { return Nota_materia1; }
            set { Nota_materia1 = value; }
        }

        public double Nota_Materia2
        {
            get { return Nota_materia2; }
            set { Nota_materia2 = value; }
        }

    }
}
