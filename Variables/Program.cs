using System;

namespace Program
{
    class Program
    {
        const double PI = 3.14159; // Constant per al valor de PI

        static void Main(string[] args)
        {
            int queTriar;
            Console.WriteLine("Quin exercici vols provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());

            switch (queTriar)
            {
                case 1: /*Realitza diverses operacions aritmètiques amb les teves edats i les d'un amic o familiar */
                {
                    /* Operacions Aritmètiques */
                    string nom;     
                    int[] edats = new int[2]; // Array per emmagatzemar dues edats

                    Console.WriteLine("Introdueix el teu nom: ");
                    nom = Console.ReadLine();

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"Introdueix l'edat de {(i == 0 ? "tu" : "el teu amic o familiar")}: ");
                        edats[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    /* Operacions aritmètiques */
                    int suma = edats[0] + edats[1];        
                    int diferència = edats[0] - edats[1];  

                    Console.WriteLine($"Hola {nom}! La suma de les vostres edats és: {suma}");
                    Console.WriteLine($"La diferència d'edat entre tu i el teu amic o familiar és: {diferència}");
                }
                break;

                case 2: /*Calcula el volum d'un cilindre a partir del radi de la base i l'altura */
                {
                    /* Càlcul del Volum d'un Cilindre */
                    double radi;   
                    double altura; 
                    double volum;  

                    Console.WriteLine("Introdueix el radi de la base del cilindre (en metres): ");
                    radi = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introdueix l'altura del cilindre (en metres): ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    volum = PI * Math.Pow(radi, 2) * altura;

                    Console.WriteLine($"El volum del cilindre és: {volum} metres cúbics");
                }
                break;

                case 3: /*Resol una equació quadràtica (AX² + BX + C) i determina el nombre de solucions reals */
                {
                    /* Resolució d'una Equació Quadràtica */
                    double A, B, C;

                    Console.WriteLine("Introdueix el valor de A:");
                    A = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introdueix el valor de B:");
                    B = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introdueix el valor de C:");
                    C = Convert.ToDouble(Console.ReadLine());

                    double D = B * B - 4 * A * C;

                    if (D > 0) 
                    {
                        double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                        double x2 = (-B - Math.Sqrt(D)) / (2 * A);
                        Console.WriteLine($"Hi ha dues solucions reals i diferents: x1 = {x1}, x2 = {x2}");
                    }
                    else if (D == 0) 
                    {
                        double x = -B / (2 * A);
                        Console.WriteLine($"Hi ha una solució real doble: x = {x}");
                    }
                    else 
                    {
                        Console.WriteLine("No hi ha solucions reals.");
                    }
                }
                break;

                default:
                    Console.WriteLine("Opció no vàlida.");
                    break;
            }
        }
    }
}