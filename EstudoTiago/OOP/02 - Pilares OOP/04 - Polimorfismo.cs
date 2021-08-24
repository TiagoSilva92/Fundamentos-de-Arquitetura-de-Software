using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            :base("Padrão", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Testar()
        {

        }

        public override void Ligar()
        {

        }

        public override void Desligar()
        {

        }
    }
}
