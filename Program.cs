using System;

namespace Fodboldklubben_TEC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            double tæller = 0, totalpris, antalbarn, antalvoksen, barnpris, voksenpris, rabatpris, rabattotalpris, rabatusdtotalpris, usd, rabatusd;
            string tast, tast2;

            // Velkomst Tekst
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.CursorVisible = false;
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Velkommen til Fodboldklubben TEC!");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("TEC Ballerup Stadion spilles der amatør kampe hver søndag kl 10");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("Tryk på en tast for at bestille billetter!");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Dato
            Console.SetCursorPosition(95, 1);
            Console.WriteLine("{0:D}", DateTime.Now);

            // Gentagelser. Man kan ikke købe 0 børne billetter og 0 voksne billetter
            do
            {
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);

                // Gentagelser & Bestil Børne Billetter
                do
                {
                    // Overskrift
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("               TEC Fodboldklub               ");
                    Console.ResetColor();

                    // Børne Billet
                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("En børne billet koster 30DKK");
                    Console.SetCursorPosition(40, 14);
                    Console.WriteLine("Hvor mange børne billetter vil du bestille? ");
                    Console.SetCursorPosition(40, 15);
                    Console.Write(":");
                    antalbarn = int.Parse(Console.ReadLine().ToLower());
                    Console.Clear();

                    // Dato
                    Console.SetCursorPosition(95, 1);
                    Console.WriteLine("{0:D}", DateTime.Now);

                    // Indtastet mindre end 0 eller større end 10
                    if (antalbarn > 10 || antalbarn < 0)
                    {
                        // Overskrift
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(40, 10);
                        Console.WriteLine("               TEC Fodboldklub               ");
                        Console.ResetColor();

                        // Indtastet mindre end 0 eller større end 10
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("Fejl. Du har indtastet et antal mindre end 0 eller større end 10");
                        Console.SetCursorPosition(40, 13);
                        Console.WriteLine("Du kan højst bestille 10 biletter.");
                        Console.SetCursorPosition(40, 15);
                        Console.WriteLine("Tast X og Enter for at afslutte bestillingen");
                        Console.SetCursorPosition(40, 16);
                        Console.WriteLine("Tryk på en anden tast for at gå tilbage. ");
                        Console.SetCursorPosition(40, 17);
                        Console.Write(":");
                        tast2 = Console.ReadLine().ToLower();
                        Console.Clear();

                        // Dato
                        Console.SetCursorPosition(95, 1);
                        Console.WriteLine("{0:D}", DateTime.Now);

                        // Program slukkes
                        if (tast2 == "x")
                        {
                            // Overskrift
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(40, 10);
                            Console.WriteLine("               TEC Fodboldklub               ");
                            Console.ResetColor();

                            // Program slukkes
                            Console.SetCursorPosition(95, 1);
                            Console.WriteLine("{0:D}", DateTime.Now);
                            Console.SetCursorPosition(40, 12);
                            Console.WriteLine("Du har valgt at afslutte bestillingen.");
                            Console.SetCursorPosition(40, 13);
                            Console.Write("Programmet vil slukkes automatisk om 3 sekunder.");
                            System.Threading.Thread.Sleep(3000);
                            return;
                        }
                    }

                } while (antalbarn > 10 || antalbarn < 0);

                // Dato
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);

                // Gentagelser & Bestilling af voksen billet
                do
                {
                    // Dato
                    Console.SetCursorPosition(95, 1);
                    Console.WriteLine("{0:D}", DateTime.Now);

                    // Overskrift
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("               TEC Fodboldklub               ");
                    Console.ResetColor();

                    // Voksen Billet
                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("En voksen billet koster 65DKK");
                    Console.SetCursorPosition(40, 14);
                    Console.WriteLine("Hvor mange voksen billetter vil du bestille? ");
                    Console.SetCursorPosition(40, 15);
                    Console.Write(":");
                    antalvoksen = int.Parse(Console.ReadLine().ToLower());
                    Console.Clear();

                    // Dato
                    Console.SetCursorPosition(95, 1);
                    Console.WriteLine("{0:D}", DateTime.Now);


                    // Indtastet mindre end 0 eller større end 10
                    if (antalvoksen > 10 || antalvoksen < 0)
                    {
                        // Overskrift
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(40, 10);
                        Console.WriteLine("               TEC Fodboldklub               ");
                        Console.ResetColor();

                        // Indtastet mindre end 0 eller større end 10
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("Fejl. Du har indtastet et antal mindre end 0 eller større end 10");
                        Console.SetCursorPosition(40, 13);
                        Console.WriteLine("Du kan højst bestille 10 biletter.");
                        Console.SetCursorPosition(40, 15);
                        Console.WriteLine("Tast på X og Enter for at afslutte bestillingen");
                        Console.SetCursorPosition(40, 16);
                        Console.WriteLine("Tryk på en anden tast for at gå tilbage. ");
                        Console.SetCursorPosition(40, 17);
                        Console.Write(":");
                        tast2 = Console.ReadLine().ToLower();
                        Console.Clear();

                        // Dato
                        Console.SetCursorPosition(95, 1);
                        Console.WriteLine("{0:D}", DateTime.Now);


                        // Program slukkes
                        if (tast2 == "x")
                        {
                            // Overskrift
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(40, 10);
                            Console.WriteLine("               TEC Fodboldklub               ");
                            Console.ResetColor();

                            // Program slukkes
                            Console.SetCursorPosition(40, 12);
                            Console.WriteLine("Du har valgt at afslutte bestillingen.");
                            Console.SetCursorPosition(40, 13);
                            Console.Write("Programmet vil slukkes automatisk om 3 sekunder.");
                            System.Threading.Thread.Sleep(3000);
                            return;
                        }
                    }

                } while (antalvoksen > 10 || antalvoksen < 0);

            } while (antalbarn + antalvoksen == 0);

            // Regnskab
            barnpris = 30;
            voksenpris = 65;
            totalpris = barnpris * antalbarn + voksenpris * antalvoksen;
            tæller = antalbarn + antalvoksen;
            rabatpris = totalpris * 0.1;
            rabattotalpris = totalpris * 0.9;
            usd = totalpris * 100 / 750;
            rabatusd = rabatpris * 100 / 750;
            rabatusdtotalpris = rabattotalpris * 100 / 750;

            // Gentagelser & Udskrivning
            do
            {
                // Overskrift
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("               TEC Fodboldklub               ");
                Console.ResetColor();

                // Dato
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);

                // Udskrives Prisen er DKK / USD & Medlem af klubbens foreningsgruppe?
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("Prisen for {0} billetter bliver {1}DKK / {2}USD ", tæller, totalpris, Math.Round(usd));
                Console.SetCursorPosition(40, 14);
                Console.Write("Er du medlem af klubbens foreningsgruppe?");
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("Indtast ja eller nej også tryk på enter");
                Console.SetCursorPosition(40, 16);
                Console.Write(":");
                tast = Console.ReadLine().ToLower();

                // Hvis brugeren har tastet forkert
                if (tast != "ja" && tast != "nej")
                {
                    Console.Clear();

                    // Overskrift
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("               TEC Fodboldklub               ");
                    Console.ResetColor();

                    // Hvis brugeren har tastet forkert
                    Console.SetCursorPosition(95, 1);
                    Console.WriteLine("{0:D}", DateTime.Now);
                    Console.SetCursorPosition(40, 12);
                    Console.Write("Indtast ventligst ja eller nej");
                    Console.SetCursorPosition(40, 13);
                    Console.Write("Tryk på en knap for at gå tilbage");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (tast != "ja" && tast != "nej");

            /* Hvis brugeren har tastet JA til klubbens foreningsgruppe
                Udskrives Rabat, Antal billetter, Pris i DKK & USD */
            if (tast == "ja")
            {
                // Dato
                Console.Clear();
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);

                // Overskrift
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("               TEC Fodboldklub               ");
                Console.ResetColor();

                /* Hvis brugeren har tastet JA til klubbens foreningsgruppe
                Udskrives Rabat, Antal billetter, Pris i DKK & USD */
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("Du får 10% rabat på dine billetter! Du sparer {0} DKK / {1} USD", rabatpris, Math.Round(rabatusd));
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("Prisen for dine {0} billetter er nu {1} DKK / {2} USD", tæller, rabattotalpris, Math.Round(rabatusdtotalpris));
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("Tryk på en tast for at bekræfte bestillingen");
                Console.ReadKey();
                Console.Clear();

                // Overskrift
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("               TEC Fodboldklub               ");
                Console.ResetColor();

                // Udskrift Bestilling Gennemført
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("Tillykke! Din bestilling er gennemført!");
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("Vi glæder os til at se jer på søndag.");
            }

            /* Hvis brugeren har tastet NEJ til klubbens foreningsgruppe
                Udskrives Antal billetter, Pris i DKK & USD */
            if (tast == "nej")
            {
                // Dato
                Console.Clear();
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);

                // Overskrift
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("               TEC Fodboldklub               ");
                Console.ResetColor();

                /* Hvis brugeren har tastet NEJ til klubbens foreningsgruppe
                Udskrives Antal billetter, Pris i DKK & USD */
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("Din pris for {0} billetter er stadig {1}DKK / {2}USD", tæller, totalpris, Math.Round(usd));
                Console.SetCursorPosition(40, 14);
                Console.WriteLine("Tryk på en tast for at bekræfte bestillingen");
                Console.ReadKey();
                Console.Clear();

                // Overskrift
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("               TEC Fodboldklub               ");
                Console.ResetColor();

                // Udskrift Bestilling Gennemført
                Console.SetCursorPosition(95, 1);
                Console.WriteLine("{0:D}", DateTime.Now);
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("Tillykke! Din bestilling er gennemført!");
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("Vi glæder os til at se jer på søndag.");
            }
            // Konsollen bliver vist indtil brugeren trykker på en tast
            Console.ReadKey();
        }
    }
}
