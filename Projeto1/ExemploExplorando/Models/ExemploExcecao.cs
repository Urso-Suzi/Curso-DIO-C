using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {

        public void Metodo1()
        {
             try
            {
             Metodo4();
            } catch (Exception)
            {
                Console.WriteLine("Exeção tratada");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
             Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }


    }

}