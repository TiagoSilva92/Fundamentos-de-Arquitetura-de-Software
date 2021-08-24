using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Casa
    {
        //Definição de Classe
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public int Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        //Definição de Objeto
        public Objeto()
        {
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 1000000,
                NumeroVagas = 3
            };
        }
    }
}
