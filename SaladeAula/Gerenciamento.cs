using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace SaladeAula
{
    public class Gerenciamento
    {

        //ALUNOS

        List<Alunos> lista_de_alunos = new List<Alunos>();

        public void Inserir()
        {
            Console.WriteLine("Qual o nome do aluno (a)?");
            string nome_aluno = Console.ReadLine();

            Console.WriteLine("Estava presente? (S ou N)");
            string falta_aluno = Console.ReadLine();

            Console.WriteLine("Qual o nome do curso?");
            string nome_curso = Console.ReadLine();

            Console.WriteLine("Qual o nome da 1ª materia");
            string materia_1 = Console.ReadLine();

            Console.WriteLine("Qual o nome da 2ª materia");
            string materia_2 = Console.ReadLine();

            Console.WriteLine("Qual a nota da 1ª materia");
            double Nota_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a nota da 2ª materia");
            double Nota_2 = Convert.ToDouble(Console.ReadLine());



            lista_de_alunos.Add(new Alunos()
            {
                Nome = nome_aluno,
                Falta = falta_aluno,
                Nome_curso = nome_curso,
                Materia1 = materia_1,
                Materia2 = materia_2,
                Nota_Materia1 = Nota_1,
                Nota_Materia2 = Nota_2,

            });
        }

        public void Listar()
        {
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Numero    Nome                 Presença    Curso       Nota1    Nota2");

                for (int i = 0; i < lista_de_alunos.Count; i++)
                {
                    Console.WriteLine(
                        "{0}          {1}                {2}      {3}       {4}        {5}",
                        i,
                        lista_de_alunos[i].Nome,
                        lista_de_alunos[i].Falta,
                        lista_de_alunos[i].Nome_curso,
                        lista_de_alunos[i].Nota_Materia1,
                        lista_de_alunos[i].Nota_Materia2
                    );
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno (a) cadastrado");
            }
        }

        public void Editar()
        {
            if (lista_de_alunos.Count > 0)
            {

                Console.WriteLine("Qual o número do aluno (a) que deseja alterar o nome?");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(
                    "Qual o novo nome do (a) atual {0} ",
                    lista_de_alunos[i].Nome
                 );

                lista_de_alunos[i].Nome = Console.ReadLine();


                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Edição feita com sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;

            }

            else
            {
                Console.WriteLine("Nenhum aluno (a) cadastrado");
            }
        }



        public void Remover()
        {
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o número do aluno (a) que deseja remover?");
                int i = Convert.ToInt32(Console.ReadLine());

                lista_de_alunos.RemoveAt(i);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Aluno (a) removido!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("Nenhum aluno (a) cadastrado");
            }
        }







        public void Alterar()
        {
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o numero do aluno (a) que vai ter a nota alterada?");
                int e = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Deseja mudar a nota da 1ª ou da 2ª materia? (1 ou 2)");
                int materia = Convert.ToInt32(Console.ReadLine());

                if (materia == 1)
                {
                    Console.WriteLine("Qual a nova nota do aluno (a) {0} na materia {1} ?",
                        lista_de_alunos[e].Nome, lista_de_alunos[e].Materia1);

                    lista_de_alunos[e].Nota_Materia1 = Convert.ToDouble(Console.ReadLine());

                }
                else if (materia == 2)
                {
                    Console.WriteLine("Qual a nova nota do aluno (a) {0} na materia de {1}?",
                        lista_de_alunos[e].Nome, lista_de_alunos[e].Materia1);

                    lista_de_alunos[e].Nota_Materia2 = Convert.ToDouble(Console.ReadLine());

                }
            } else
            {
                Console.WriteLine("Nenhum aluno (a) cadastrado");
            }
        }



        public void Mudar()
        {
            if (lista_de_alunos.Count > 0)
            {


                Console.WriteLine("Deseja mudar a falta de qual aluno (a)?");
                int e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ele (ela) estava presente?");

                lista_de_alunos[e].Falta = Console.ReadLine();

            } else
            {
                Console.WriteLine("Nenhum aluno (a) cadastrado");
            }


        }






    }
}
