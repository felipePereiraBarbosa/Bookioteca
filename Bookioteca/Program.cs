using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> essesLivros = new List<Livro>();

            int i = 0;
            while (true)
            {
                i++;
                Livro _livro = new Livro();
                Console.Write("Informe o título do " + i + " livro: ");
                _livro.Titulo = Convert.ToString(Console.ReadLine());
                if (_livro.Titulo == string.Empty)

                {
                    break;
                }
                Console.Write("Informe o autor do  " + i + " livro: ");
                _livro.Autor = Convert.ToString(Console.ReadLine());
                if (_livro.Autor == string.Empty)

                {
                    break;
                }
                Console.Write("Informe o volume do " + i + " livro:  ");
                _livro.Volume = Convert.ToString(Console.ReadLine());
                if (_livro.Volume == string.Empty)

                {
                    break;
                    //autor, volume, observação, emprestimo, data do emprestimo.
                }
                Console.Write("Informe se existe alguma observação a ser feita sobre o  " + i + " livro: ");
                _livro.Observação = Convert.ToString(Console.ReadLine());
                if (_livro.Observação == string.Empty)

                {
                    break;
                }
                Console.Write("Informe se houve empréstimo do " + i + " livro: ");
                _livro.Emprestimo = Convert.ToString(Console.ReadLine());
                if (_livro.Emprestimo == string.Empty)

                {
                    break;
                }
                Console.Write("Informe a data do empréstimo do  " + i + " livro: ");
                _livro.DataDeEmprestimo = Convert.ToString(Console.ReadLine());
                if (_livro.DataDeEmprestimo == string.Empty)

                {
                    break;
                    //autor, volume, observação, emprestimo, data do emprestimo.
                }

                essesLivros.Add(_livro);
            }
            foreach (Livro _livro in essesLivros.OrderBy(l => l.Titulo))
            {
                Console.WriteLine(_livro.Titulo);
                Console.WriteLine(_livro.Autor);
                Console.WriteLine(_livro.Volume);
                Console.WriteLine(_livro.Observação);
                Console.WriteLine(_livro.Emprestimo);
                Console.WriteLine(_livro.DataDeEmprestimo);
            }
            Console.ReadKey();
        }
    }
}
