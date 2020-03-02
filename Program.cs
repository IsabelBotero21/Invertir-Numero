using System;
using static System.Console;
namespace numeroInverso {
    class Program {
        static void Main (string[] args) {
            int numero = 0;
            int primerModular = 0;
            int tercerModular = 0;
            int segundoModular = 0;
            WriteLine ("Digite un número");
            numero = Convert.ToInt32 (ReadLine ());
            primerModular = numero % 10;
            WriteLine ("Primer digito" + primerModular);
            numero = numero - primerModular;
            WriteLine (numero);
            segundoModular = numero / 10;
            segundoModular = segundoModular % 10;
            WriteLine ("Segundo digito es:" + segundoModular);
            tercerModular = numero/100;
           WriteLine ("Tercer digito es:" + tercerModular);
            WriteLine ("Número inverso");
           WriteLine($"{primerModular}{segundoModular}{tercerModular}");
        }
    }
}