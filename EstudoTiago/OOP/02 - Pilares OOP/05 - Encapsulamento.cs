using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class AutomacaoCafe
    {
        public void Servircafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
