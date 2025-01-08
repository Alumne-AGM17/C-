using System;

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
                      // Exercici 1: Sumar tots els números enters des de 13 fins al número introduït per l'usuari.
                    Console.WriteLine("Introdueix un número: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int suma = 0;

                    for (int i = 13; i <= num; i++)
                    {
                        suma += i;
                    }

                    Console.WriteLine($"La suma dels números enters des de 13 fins a {num} és: {suma}");
                    break;

                case 2:
                     // Exercici 2: Comptar números parells, imparells, i sumar-los.
                    Console.WriteLine("Introdueix un número: ");
                    int limite = Convert.ToInt32(Console.ReadLine());

                    int countPares = 0;
                    int countImpares = 0;
                    int sumaPares = 0;
                    int sumaImpares = 0;
                    int countMultiplesDe13 = 0;

                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0) // Número parell
                        {
                            countPares++;
                            sumaPares += i;
                        }
                        else // Número imparell
                        {
                            countImpares++;
                            sumaImpares += i;
                        }

                        if (i % 13 == 0) // Múltiple de 13
                        {
                            countMultiplesDe13++;
                        }
                    }

                    Console.WriteLine($"Números parells: {countPares}");
                    Console.WriteLine($"Suma dels números parells: {sumaPares}");
                    Console.WriteLine($"Números imparells: {countImpares}");
                    Console.WriteLine($"Suma dels números imparells: {sumaImpares}");
                    Console.WriteLine($"Múltiples de 13: {countMultiplesDe13}");
                    break;

                case 3:
                     // Exercici 3: Pedra/Paper/Tisora
                    Random random = new Random();
                    int jugador1 = random.Next(0, 3); // Jugador 1
                    int jugador2 = random.Next(0, 3); // Jugador 2

                    string[] jugades = { "Pedra", "Paper", "Tisora" };

                    Console.WriteLine($"Jugador 1: {jugades[jugador1]}");
                    Console.WriteLine($"Jugador 2: {jugades[jugador2]}");

                    if (jugador1 == jugador2)
                    {
                        Console.WriteLine("Empat! No hi ha guanyador.");
                    }
                    else if ((jugador1 == 0 && jugador2 == 2) || (jugador1 == 1 && jugador2 == 0) || (jugador1 == 2 && jugador2 == 1))
                    {
                        Console.WriteLine("Jugador 1 guanya!");
                    }
                    else
                    {
                        Console.WriteLine("Jugador 2 guanya!");
                    }
                    break;

                case 4:  // Exercici 4: Simulador de Caixer Automàtic
                    decimal saldo = 1000.00m;
                    bool continuar = true;

                    while (continuar)
                    {
                        Console.WriteLine("\nOpcions:");
                        Console.WriteLine("1. Treure efectiu");
                        Console.WriteLine("2. Dipòsit");
                        Console.WriteLine("3. Consultar saldo");
                        Console.WriteLine("4. Sortir");
                        Console.Write("Introdueix la teva opció: ");
                        int opcio = Convert.ToInt32(Console.ReadLine());

                        switch (opcio)
                        {
                                Console.Write("Introdueix l'import a retirar: "); // Treure efectiu
                                decimal retirar = Convert.ToDecimal(Console.ReadLine());
                                if (retirar > saldo)
                                {
                                    Console.WriteLine("No pots retirar més del que tens en saldo.");
                                }
                                else
                                {
                                    saldo -= retirar;
                                    Console.WriteLine($"Has retirat: {retirar}€. Saldo restant: {saldo}€");
                                }
                                break;

                                Console.Write("Introdueix l'import a dipositar: "); // Dipòsit
                                decimal diposit = Convert.ToDecimal(Console.ReadLine());
                                saldo += diposit;
                                Console.WriteLine($"Has dipositat: {diposit}€. Nou saldo: {saldo}€");
                                break;

                                Console.WriteLine($"El teu saldo actual és: {saldo}€"); // Consultar saldo
                                break;

                                continuar = false;
                                Console.WriteLine("Gràcies per utilitzar el nostre caixer."); // Sortir
                                break;

                            default:
                                Console.WriteLine("Opció no vàlida.");
                                break;
                        }
                    }
                    break;

                case 5: // Exercici 5: Gestor lloguer d'apartaments
                    Console.WriteLine("Benvingut al gestor de lloguer d'apartaments!");

                    Console.Write("Introdueix l'edat del client: ");
                    int edat = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introdueix els ingressos mensuals del client en euros: ");
                    decimal ingressos = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("El client té una referència de lloguer anterior positiva (Sí/No): ");
                    string referencia = Console.ReadLine().ToLower();

                    Console.Write("Introdueix el nombre d'infraccions de trànsit greus registrades en els últims 5 anys: ");
                    int infraccions = Convert.ToInt32(Console.ReadLine());

                    bool potLlogar = true;
                    Console.WriteLine("\nResultats de l'avaluació:");

                    if (edat <= 21 || edat >= 65)
                    {
                        Console.WriteLine("L'edat ha de ser major de 21 anys i menor de 65 anys.");
                        potLlogar = false;
                    }
                    else
                    {
                        Console.WriteLine("Edat correcta.");
                    }

                    if (ingressos < 2500)
                    {
                        Console.WriteLine("Els ingressos mensuals han de ser iguals o superiors a 2500 euros.");
                        potLlogar = false;
                    }
                    else
                    {
                        Console.WriteLine("Ingressos suficients.");
                    }

                    if (referencia != "sí" && referencia != "si")
                    {
                        Console.WriteLine("Es requereix una referència de lloguer anterior positiva.");
                        potLlogar = false;
                    }
                    else
                    {
                        Console.WriteLine("Referència positiva verificada.");
                    }

                    if (infraccions > 1)
                    {
                        Console.WriteLine("Massa infraccions de trànsit greus.");
                        potLlogar = false;
                    }
                    else
                    {
                        Console.WriteLine("Historial d'infraccions acceptable.");
                    }

                    Console.WriteLine("\nConclusió final:");
                    if (potLlogar)
                    {
                        Console.WriteLine("El client compleix tots els requisits i pot llogar un apartament.");
                    }
                    else
                    {
                        Console.WriteLine("El client no compleix tots els requisits necessaris per llogar un apartament.");
                    }
                    break;

                default:
                    Console.WriteLine("Opció no vàlida.");
                    break;
            }
        }
    }
}