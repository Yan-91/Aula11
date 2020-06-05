using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculo infoPlayer = new Calculo();
           System.Console.WriteLine(infoPlayer.Calcular());

           System.Console.WriteLine(infoPlayer.Calcular(90));

           System.Console.WriteLine(infoPlayer.Calcular(90,3));

           System.Console.WriteLine( infoPlayer.Calcular("Fallen","Fnx") );

        }
    }
}
