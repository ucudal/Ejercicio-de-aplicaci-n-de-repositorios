//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
 
            //var train = new Train("identificador1");
            //train.StartEngines();

            /*for (int i = 0; i < 100; i++){
                var train = new Train("identificador1");
                Console.WriteLine(train.Contador);
            }*/

            for (int i = 0; i < 10000000; i++){
                var train = new Train("identificador2");
                Console.WriteLine(train.Contador);
            }

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2==t3);

        }
    }
}