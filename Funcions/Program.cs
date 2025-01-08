using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int queTriar;
            Console.WriteLine("Exercici a provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());

            switch (queTriar)
            {
                case 1:
                    // Exercici 1
                    Console.WriteLine("Cercador de Valors Mínims i Màxims d'una Llista de Nombres Aleatoris");
                    List<int> numeros1 = new List<int>();
                    Random random1 = new Random();

                    // Generar 55 números aleatoris i afegir-los a la llista
                    for (int i = 0; i < 55; i++)
                    {
                        int numeroAleatori = random1.Next(22, 1560);
                        numeros1.Add(numeroAleatori);
                    }

                    // Cercar el valor més petit
                    int valorMinim = numeros1[0];
                    for (int i = 1; i < numeros1.Count; i++)
                    {
                        if (numeros1[i] < valorMinim)
                        {
                            valorMinim = numeros1[i];
                        }
                    }

                    // Cercar el valor més gran
                    int valorMaxim = numeros1[0];
                    for (int i = 1; i < numeros1.Count; i++)
                    {
                        if (numeros1[i] > valorMaxim)
                        {
                            valorMaxim = numeros1[i];
                        }
                    }

                    // Mostrar els resultats
                    Console.WriteLine("El valor més petit és: " + valorMinim);
                    Console.WriteLine("El valor més gran és: " + valorMaxim);
                    break;

                case 2:
                    // Exercici 2
                    Console.WriteLine("El controlador");
                    List<int> numeros2 = new List<int>();
                    Random random2 = new Random();

                    // Generar 333 números aleatoris i afegir-los a la llista
                    for (int i = 0; i < 333; i++)
                    {
                        int numeroAleatori = random2.Next(1, 1000);
                        numeros2.Add(numeroAleatori);
                    }

                    // Calcular la mitjana de tots els números
                    double suma = 0;
                    foreach (int num in numeros2)
                    {
                        suma += num;
                    }
                    double mitjana = suma / numeros2.Count;
                    Console.WriteLine("La mitjana de tots els números és: " + mitjana);

                    // Comptar quants números són múltiples de 4
                    int multiplesDeQuatre = 0;
                    foreach (int num in numeros2)
                    {
                        if (num % 4 == 0)
                        {
                            multiplesDeQuatre++;
                        }
                    }
                    Console.WriteLine("Quantitat de números múltiples de 4: " + multiplesDeQuatre);

                    // Comptar quants números són més grans que la mitjana
                    int majorsQueMitjana = 0;
                    foreach (int num in numeros2)
                    {
                        if (num > mitjana)
                        {
                            majorsQueMitjana++;
                        }
                    }
                    Console.WriteLine("Quantitat de números més grans que la mitjana: " + majorsQueMitjana);
                    break;

                case 3:
                    // Exercici 3
                    Console.WriteLine("Comptatge de Vocals en una Frase");
                    string frase = Console.ReadLine().ToLower();
                    int comptadorA = 0;
                    int comptadorE = 0;
                    int comptadorI = 0;
                    int comptadorO = 0;
                    int comptadorU = 0;

                    // Comprovar cada caràcter per veure si és una vocal
                    for (int i = 0; i < frase.Length; i++)
                    {
                        char c = frase[i];
                        switch (c)
                        {
                            case 'a':
                                comptadorA++;
                                break;
                            case 'e':
                                comptadorE++;
                                break;
                            case 'i':
                                comptadorI++;
                                break;
                            case 'o':
                                comptadorO++;
                                break;
                            case 'u':
                                comptadorU++;
                                break;
                        }
                    }

                    // Mostrar els resultats
                    Console.WriteLine("Nombre de vocals 'a': " + comptadorA);
                    Console.WriteLine("Nombre de vocals 'e': " + comptadorE);
                    Console.WriteLine("Nombre de vocals 'i': " + comptadorI);
                    Console.WriteLine("Nombre de vocals 'o': " + comptadorO);
                    Console.WriteLine("Nombre de vocals 'u': " + comptadorU);
                    break;

                case 4:
                    // Exercici 4
                    Console.WriteLine("Simulador del Caixer Automàtic");

                    double saldo = 1000.0; // Saldo inicial
                    bool continuar = true;

                    while (continuar)
                    {
                        Console.WriteLine("\nSelecciona una operació:");
                        Console.WriteLine("1. Treure efectiu");
                        Console.WriteLine("2. Dipòsit");
                        Console.WriteLine("3. Consultar saldo");
                        Console.WriteLine("4. Sortir");

                        int opcio = Convert.ToInt32(Console.ReadLine());

                        // Realitzar l'operació seleccionada
                        if (opcio == 1)
                        {
                            Console.WriteLine("Introdueix la quantitat a treure: ");
                            double quantitatTreure = Convert.ToDouble(Console.ReadLine());
                            if (quantitatTreure <= saldo)
                            {
                                saldo -= quantitatTreure;
                                Console.WriteLine("Has tret " + quantitatTreure + ". El teu nou saldo és " + saldo);
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficient.");
                            }
                        }
                        else if (opcio == 2)
                        {
                            Console.WriteLine("Introdueix la quantitat que vols dipositar: ");
                            double quantitatDiposit = Convert.ToDouble(Console.ReadLine());
                            saldo += quantitatDiposit;
                            Console.WriteLine("Has dipositat " + quantitatDiposit + ". El teu nou saldo és " + saldo);
                        }
                        else if (opcio == 3)
                        {
                            Console.WriteLine("El teu saldo actual és " + saldo);
                        }
                        else if (opcio == 4)
                        {
                            continuar = false;
                            Console.WriteLine("Gràcies per utilitzar el caixer automàtic.");
                        }
                        else
                        {
                            Console.WriteLine("Opció no vàlida. Si us plau, selecciona una opció vàlida.");
                        }
                    }
                    break;
            }
        }
    }
}