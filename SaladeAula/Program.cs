using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SaladeAula
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Voltar_menu = false;


            int num_menu;

           Gerenciamento dados_aluno = new Gerenciamento();
           Gerenciamento nota = new Gerenciamento();
           Gerenciamento falta = new Gerenciamento();

            

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("GERENCIAMENTO DA SALA DE AULA");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("Selecione uma opção:");

                Console.WriteLine("1 - ver a lista da sala");
                Console.WriteLine("2 - adicionar um aluno (a)");
                Console.WriteLine("3 - alterar nome do aluno (a)");
                Console.WriteLine("4 - remover um aluno (a)");
                Console.WriteLine("5 - alterar uma nota");
                Console.WriteLine("6 - alterar uma falta");
                Console.WriteLine("7 - sai do sistema de gerenciamento");



                bool validando_menu = false;
                do
                {
                    validando_menu = int.TryParse(Console.ReadLine(), out num_menu);

                    if (num_menu < 1 || num_menu > 11 || validando_menu == false)
                    {

                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção inválida, tente uma outra opção");
                        Console.BackgroundColor = ConsoleColor.Black;

                        validando_menu = false;
                    }
                } while (!validando_menu);




             
                switch (num_menu)
                {
                    case 1:
                        dados_aluno.Listar();
                        break;
                    case 2:
                        dados_aluno.Inserir();
                        break;
                    case 3:
                        dados_aluno.Editar();
                        break;
                    case 4:
                        dados_aluno.Remover();
                        break;
                    case 5:
                        nota.Alterar();
                        break;
                    case 6:
                        falta.Mudar();
                        break;
                    case 7:

                        break;




                }



                if (num_menu == 7)
                {
                    break;

                } else
                {
                    Console.WriteLine("Deseja voltar ao menu?");
                    Voltar_menu = (Console.ReadLine().ToUpper() == "S") ? true : false;
                }

            } while (Voltar_menu);

            
            Console.WriteLine("Fim do Programa.");
            Console.ReadKey();

        }    }
}
