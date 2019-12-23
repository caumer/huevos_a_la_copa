using System;

namespace huevos_a_la_copa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique la masa del huevo");
            Console.WriteLine("escriba \"M\" para huevos grandes y \"m\" para huevos pequeños");

            String masa = Console.ReadLine() ;

            int masaPequeño = 47; //m Masa del huevo
            double masaGrande = 64; //M Masa del huevo
            double densidad = 1.038; //p 
            double capacidadCalorica = 3.7; //c
            double conductividadTermica = 0.0054; //K
            double temperaturaEbullicion = 100; //Dada en Celsius

            if (masa == "m")
            {
                Console.WriteLine("\nIngrese la temperatura del huevo");
                int temperaturaHuevo = int.Parse(Console.ReadLine());

                double tiempoParcial1 = Math.Pow(masaPequeño, 2.0 / 3) * capacidadCalorica * Math.Pow(densidad, 1.0 / 3);
                double tiempoParcial2 = conductividadTermica * Math.Pow(Math.PI, 2) * Math.Pow(((4 * Math.PI) / 3), 2.0 /3);
                double tiempoParcial3 = 0.76 * ((temperaturaHuevo - temperaturaEbullicion) / (66.5 - temperaturaEbullicion));

                double tiempo = tiempoParcial1/tiempoParcial2 * Math.Log(tiempoParcial3);

                Console.WriteLine("El tiempo maxima para la preparacion es {0} segundos", tiempo);

            }
            else
            {
                Console.WriteLine("\nIngrese la temperatura del huevo");
                int temperaturaHuevo = int.Parse(Console.ReadLine());

                double tiempoParcial1 = Math.Pow(masaGrande, 2.0 / 3) * capacidadCalorica * Math.Pow(densidad, 1.0 / 3);
                double tiempoParcial2 = conductividadTermica * Math.Pow(Math.PI, 2) * Math.Pow(((4 * Math.PI) / 3), 2.0 / 3);
                double tiempoParcial3 = 0.76 * ((temperaturaHuevo - temperaturaEbullicion) / (66.5 - temperaturaEbullicion));

                double tiempo = tiempoParcial1 / tiempoParcial2 * Math.Log(tiempoParcial3);

                Console.WriteLine("El tiempo maxima para la preparacion es {0} segundos", tiempo);
            }
        }
    }
}
