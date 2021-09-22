using System;
using System.Threading;
using System.Globalization;

namespace ParkingMeter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string warning = "THIS MACHINE DOESN'T GIVE BACK CHANGE.";
            bool inMenu = false;
            double price = 0;
            int parkingLength;
            string printTicket = "PRINTING TICKET.";
            string printSuccessful = "SUCCESSFUL";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select your parking option by pressing a key from |1| to |4|:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|1| - Up to 1 hour ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("£2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|2| - Up to 2 hours ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("£3.50.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("|3| - Up to 4 hours ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("£5.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("|4| - More than 4 hours ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("£9.5.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n \n \n Press \"ESCAPE\" at any time to exit the application.");
            Console.ForegroundColor = ConsoleColor.White;
            if (int.TryParse(Console.ReadLine(), out parkingLength))
            {
                inMenu = true;
                if (parkingLength == 1)
                {
                    price = 2000;
                }

                else if (parkingLength == 2)
                {
                    price = 3500;
                }
                else if (parkingLength == 3)
                {
                    price = 5000;
                }
                else if (parkingLength == 4)
                {
                    price = 9500;
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            Console.Clear();
            while (inMenu)
            {

                if (price > 0)
                {
                    double onePoundCoins, fiftyPenceCoins, tenPenceCoins, fivePenceCoins, twoPenceCoins, onePenceCoins;
                    int onePoundDisplay, fiftyPenceDisplay, tenPenceDisplay, fivePenceDisplay, twoPenceDisplay, onePenceDisplay;

                    onePoundCoins = price / 1000;
                    fiftyPenceCoins = price / 500;
                    tenPenceCoins = price / 100;
                    fivePenceCoins = price / 50;
                    twoPenceCoins = price / 20;
                    onePenceCoins = price / 10;

                    onePoundDisplay = (int)onePoundCoins;
                    fiftyPenceDisplay = (int)fiftyPenceCoins;
                    tenPenceDisplay = (int)tenPenceCoins;
                    fivePenceDisplay = (int)fivePenceCoins;
                    twoPenceDisplay = (int)twoPenceCoins;
                    onePenceDisplay = (int)onePenceCoins;

                    Console.Write("Left to pay: £");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(price / 1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (price >= 10)
                    {
                        if (price >= 50)
                        {
                            if (price >= 100)
                            {
                                if (price >= 500)
                                {
                                    if (price >= 1000)
                                    {
                                        Console.Write("Press ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("\"1\"");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(" to pay £1.00 | ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(" Number of coins you can insert: ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(onePoundDisplay);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.Write("Press ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\"2\"");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" to pay £0.50 | ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(" Number of coins you can insert: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(fiftyPenceDisplay);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.Write("Press ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\"3\"");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(" to pay £0.10 | ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Number of coins you can insert: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(tenPenceDisplay);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write("Press ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\"4\"");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" to pay £0.05 | ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Number of coins you can insert: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(fivePenceDisplay);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write("Press ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\"5\"");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" to pay £0.02 | ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Number of coins you can insert: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(twoPenceDisplay);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\"6\"");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" to pay £0.01 | ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Number of coins you can insert: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(onePenceDisplay);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress \"ESCAPE\" at any time to exit the application.\n \n \n \n \n \n");
                }
                else if (price == 0 && inMenu == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Payment successful. Printing ticket.");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    DateTime localDate = DateTime.Now;
                    DateTime utcDate = DateTime.UtcNow;
                    String[] cultureNames = { "en-GB" };

                    foreach (var cultureName in cultureNames)
                    {
                        var culture = new CultureInfo(cultureName);
                        //Console.WriteLine("{0}:", culture.NativeName);
                        Console.WriteLine("   Ticket bought at: {0}",
                            localDate.ToString(culture), localDate.Kind);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(1000);
                    Console.SetCursorPosition((Console.WindowWidth - printTicket.Length) / 2, Console.CursorTop);
                    Console.WriteLine(printTicket);
                    Thread.Sleep(1000);
                    Console.SetCursorPosition((Console.WindowWidth - printTicket.Length) / 2, Console.CursorTop);
                    Console.WriteLine($"{printTicket}.");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition((Console.WindowWidth - printTicket.Length) / 2, Console.CursorTop);
                    Console.WriteLine($"{printTicket}..");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("\n \n \n");
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", printSuccessful));
                    Console.WriteLine("\n \n \n");
                    Console.Beep(); Console.Beep(); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                }


                Console.SetCursorPosition((Console.WindowWidth - warning.Length) / 2, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(warning);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    inMenu = false;
                }
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        if (price >= 1000)
                        {
                            price -= 1000;
                            Console.Beep();
                        }
                        break;
                    case ConsoleKey.D2:
                        if (price >= 500)
                        {
                            price -= 500;
                            Console.Beep();
                        }
                        break;
                    case ConsoleKey.D3:
                        if (price >= 100)
                        {
                            price -= 100;
                            Console.Beep();
                        }

                        break;
                    case ConsoleKey.D4:
                        if (price >= 50)
                        {
                            price -= 50;
                            Console.Beep();
                        }

                        break;
                    case ConsoleKey.D5:
                        if (price >= 20)
                        {
                            price -= 20;
                            Console.Beep();
                        }

                        break;
                    case ConsoleKey.D6:
                        if (price >= 10)
                        {
                            price -= 10;
                            Console.Beep();
                        }

                        break;
                    default:
                        Console.WriteLine("INVALID OPTION");
                        break;
                }

                Console.Clear();
            }

        }
    }
}
