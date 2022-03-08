using System;
using System.Collections.Generic;
using System.Linq;

namespace ListPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> listapessoa = new List<Pessoa>();

            string nome;
            int idade;
            string opcao;
            do
            {
                Console.WriteLine("Digite o nome da Pessoa: ");
                nome = Console.ReadLine().ToUpper();
                Console.WriteLine("Digite a idade da Pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Quer continuar? [ S / N ]");
                    opcao = Console.ReadLine().ToUpper();
                    if(opcao != "S" && opcao != "N")
                    {
                        
                        Console.WriteLine("Digite uma opção válida");
                    }
                }while(opcao != "S" && opcao != "N");



                    /*
                     * if (nome != "")
                {
                    listapessoa.Add(new Pessoa(nome, idade));

                }
                    */
            } while (nome != "");

            Console.WriteLine("A lista tem " + listapessoa.Count + " elementos:");

            //Imprimir cada item da lista
            listapessoa.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));

            //Ordenar
            Console.WriteLine(" -- LISTA ORDENADA -- ");
            //listapessoa.Sort(); // Não funciona
            listapessoa = listapessoa.OrderByDescending(lp => lp.Nome).ToList();
            listapessoa.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));

            Console.WriteLine(" -- ORDENAR POR NOME -- ");
            listapessoa = listapessoa.OrderBy(lp => lp.Nome).ToList();
            listapessoa.ForEach((pessoa) => Console.WriteLine(pessoa.ToString()));

            Console.WriteLine(" -- ORDENAR POR IDADE -- ");
            listapessoa = listapessoa.OrderBy(lp => lp.Idade).ToList();

            Console.WriteLine("Fazendo busca na lista");
            localizaPessoaMaisJovem(listapessoa);

            static void localizaPessoaMaisJovem(List<Pessoa> pessoas)
            {

                List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa p) { return p.Idade < 25; });

                Console.WriteLine("Idade é menor que 25");
                jovem.ForEach(delegate (Pessoa p)
                {
                    Console.WriteLine(String.Format("{0} {1}", p.Idade, p.Nome));
                });


            }




        }
    }
}
