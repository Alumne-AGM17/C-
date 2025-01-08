using System; 
using System.Collections.Generic; 

namespace CasinoVirtual 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Saldo del jugador
            decimal saldo = 0; // Variable per emmagatzemar el saldo del jugador.
            bool jugant = true; // Variable que indica si el jugador està jugant.

            Console.WriteLine("Benvingut al Casino Virtual!"); // Missatge de benvinguda.

            // Inicialitzem el saldo del jugador
            while (saldo <= 0) // Bucle que s'executa mentre el saldo sigui menor o igual a zero.
            {
                Console.Write("Si us plau, introdueix el teu saldo inicial: "); // Sol·licita el saldo inicial.
                saldo = Convert.ToDecimal(Console.ReadLine()); // Llegeix el saldo introduït i el converteix a decimal.

                if (saldo <= 0) // Verifica si el saldo introduït és menor o igual a zero.
                {
                    Console.WriteLine("El saldo ha de ser superior a zero."); // Missatge d'error.
                }
            }

            // Menú principal
            while (jugant) // Bucle que s'executa mentre el jugador estigui jugant.
            {
                Console.WriteLine("El teu saldo actual és: " + saldo); // Mostra el saldo actual.
                Console.WriteLine("Selecciona un joc:"); // Sol·licita al jugador que seleccioni un joc.
                Console.WriteLine("1. Ruleta"); // Opció per jugar a la ruleta.
                Console.WriteLine("2. Blackjack"); // Opció per jugar al blackjack.
                Console.WriteLine("3. Tragaperras"); // Opció per jugar a les tragaperras.
                Console.WriteLine("4. Sortir"); // Opció per sortir del joc.
                Console.Write("Opció: "); // Sol·licita al jugador que introdueixi la seva opció.

                string ? opcio = Console.ReadLine(); // Llegeix l'opció seleccionada pel jugador.

                switch (opcio) // Estructura de control que avalua l'opció seleccionada.
                {
                    case "1": // Si l'opció és 1, es juga a la ruleta.
                        saldo = JugarRuleta(saldo); // Crida al mètode JugarRuleta i actualitza el saldo.
                        break; // Sortida del switch.
                    case "2": // Si l'opció és 2, es juga al blackjack.
                        saldo = JugarBlackjack(saldo); // Crida al mètode JugarBlackjack i actualitza el saldo.
                        break; // Sortida del switch.
                    case "3": // Si l'opció és 3, es juga a les tragaperras.
                        saldo = JugarTragaperras(saldo); // Crida al mètode JugarTragaperras i actualitza el saldo.
                        break; // Sortida del switch.
                    case "4": // Si l'opció és 4, el jugador vol sortir.
                        jugant = false; // Canvia la variable jugant a false per sortir del bucle.
                        Console.WriteLine("Gràcies per jugar. El teu saldo final és: " + saldo); // Missatge de comiat.
                        break; // Sortida del switch.
                    default: // Si l'opció no és vàlida.
                        Console.WriteLine("Opció no vàlida. Intenta-ho de nou."); // Missatge d'error.
                        break; // Sortida del switch.
                }

                // Sortida si el saldo és zero o menor
                if (saldo <= 0) // Verifica si el saldo és menor o igual a zero.
                {
                    Console.WriteLine("T'has quedat sense saldo. Sortint del casino."); // Missatge d'error.
                    jugant = false; // Canvia la variable jugant a false per sortir del bucle.
                }
            }
        }

        static decimal JugarRuleta(decimal saldo) // Mètode que simula el joc de la ruleta.
        {
            Console.WriteLine("--- Jugant a la Ruleta ---"); // Missatge indicant que s'està jugant a la ruleta.
            Console.Write("Introdueix la teva aposta: "); // Sol·licita al jugador que introdueixi la seva aposta.
            decimal aposta = Convert.ToDecimal(Console.ReadLine()); // Llegeix l'aposta i la converteix a decimal.

            if (aposta > saldo) // Verifica si l'aposta és superior al saldo.
            {
                Console.WriteLine("No tens suficient saldo per fer aquesta aposta."); // Missatge d'error.
                return saldo; // Retorna el saldo sense canvis.
            }

            Random rand = new Random(); // Crea una instància de la classe Random per generar números aleatoris.
            int numeroGuanyador = rand.Next(0, 37); // Genera un número aleatori entre 0 i 36 (números de la ruleta).
            Console.WriteLine("El número guanyador és: " + numeroGuanyador); // Mostra el número guanyador.

            Console.Write("A quin número apostes (0-36): "); // Sol·licita al jugador que introdueixi la seva aposta.
            int numeroApostat = Convert.ToInt32(Console.ReadLine()); // Llegeix el número apostat i el converteix a enter.

            if (numeroApostat == numeroGuanyador) // Verifica si el número apostat és igual al número guanyador.
            {
                Console.WriteLine("¡Felicitats! Has guanyat."); // Missatge de victòria.
                saldo += aposta * 35; // Actualitza el saldo sumant la guanyança.
            }
            else
            {
                Console.WriteLine("Ho sento, has perdut."); // Missatge de derrota.
                saldo -= aposta; // Actualitza el saldo restant l'aposta.
            }

            return saldo; // Retorna el saldo actualitzat.
        }

        static decimal JugarBlackjack(decimal saldo) // Mètode que simula el joc de blackjack.
        {
            Console.WriteLine("--- Jugant a Blackjack ---"); // Missatge indicant que s'està jugant al blackjack.
            Console.Write("Introdueix la teva aposta: "); // Sol·licita al jugador que introdueixi la seva aposta.
            decimal aposta = Convert.ToDecimal(Console.ReadLine()); // Llegeix l'aposta i la converteix a decimal.

            if (aposta > saldo) // Verifica si l'aposta és superior al saldo.
            {
                Console.WriteLine("No tens suficient saldo per fer aquesta aposta."); // Missatge d'error.
                return saldo; // Retorna el saldo sense canvis.
            }

            // Simulació simple del Blackjack
            Random rand = new Random(); // Crea una instància de la classe Random per generar números aleatoris.
            int jugador = rand.Next(1, 22); // Genera una puntuació aleatòria per al jugador entre 1 i 21.
            int dealer = rand.Next(1, 22); // Genera una puntuació aleatòria per al dealer entre 1 i 21.

            Console.WriteLine($"La teva puntuació: {jugador}, Puntuació del dealer: {dealer}"); // Mostra les puntuacions.

            if (jugador > 21) // Verifica si el jugador supera 21.
            {
                Console.WriteLine("T'has passat de 21. Has perdut."); // Missatge de derrota.
                saldo -= aposta; // Actualitza el saldo restant l'aposta.
            }
            else if (dealer > 21 || jugador > dealer) // Verifica si el dealer supera 21 o si el jugador té una puntuació superior.
            {
                Console.WriteLine("¡Felicitats! Has guanyat."); // Missatge de victòria.
                saldo += aposta; // Actualitza el saldo sumant l'aposta.
            }
            else
            {
                Console.WriteLine("Ho sento, has perdut."); // Missatge de derrota.
                saldo -= aposta; // Actualitza el saldo restant l'aposta.
            }

            return saldo; // Retorna el saldo actualitzat.
        }

        static decimal JugarTragaperras(decimal saldo) // Mètode que simula el joc de tragaperras.
        {
            Console.WriteLine("--- Jugant a Tragaperras ---"); // Missatge indicant que s'està jugant a les tragaperras.
            Console.Write("Introdueix la teva aposta: "); // Sol·licita al jugador que introdueixi la seva aposta.
            decimal aposta = Convert.ToDecimal(Console.ReadLine()); // Llegeix l'aposta i la converteix a decimal.

            if (aposta > saldo) // Verifica si l'aposta és superior al saldo.
            {
                Console.WriteLine("No tens suficient saldo per fer aquesta aposta."); // Missatge d'error.
                return saldo; // Retorna el saldo sense canvis.
            }

            Random rand = new Random(); // Crea una instància de la classe Random per generar números aleatoris.
            int[] resultats = new int[3]; // emmatgazema els resultats dels tres carrets.

            for (int i = 0; i < resultats.Length; i++) // Bucle per generar els resultats dels tres carrets.
            {
                resultats[i] = rand.Next(1, 4); // Genera un símbol aleatori per a cada carrete.
            }

            Console.WriteLine($"Resultats: {resultats[0]} | {resultats[1]} | {resultats[2]}"); // Mostra els resultats dels carrets.

            if (resultats[0] == resultats[1] && resultats[1] == resultats[2]) // Verifica si els tres símbols són iguals.
            {
                Console.WriteLine("¡Felicitats! Has guanyat."); // Missatge de victòria.
                saldo += aposta * 10; // Actualitza el saldo sumant la guanyança.
            }
            else
            {
                Console.WriteLine("Ho sento, has perdut."); // Missatge de derrota.
                saldo -= aposta; // Actualitza el saldo restant l'aposta.
            }

            return saldo; // Retorna el saldo actualitzat.
        }
    }
}