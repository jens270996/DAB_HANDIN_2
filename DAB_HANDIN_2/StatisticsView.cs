using System;
namespace DAB_HANDIN_2

{
    public class StatisticsView
    {
        public StatisticsView()
        {

        }


        public void OpenStatMenu()
        {
            bool finish = false;
            double smittede = 0;
            bool kvinder = false;
            bool mænd = false;
            bool andre = false;
            bool et = false;
            bool elleve = false;
            bool enogtyve = false;
            bool enogtredive = false;
            bool enogfyrre = false;
            bool enoghalvtreds = false;
            bool enogtres = false;
            bool enoghalvfjers = false;
            bool enogfirs = false;

            do
            {
                Console.Clear();
                Console.WriteLine("***** Statestik menu ***** \n");
                Console.WriteLine("Mulige tilvalg: \n Kvinder    [{0}]\n Mænd       [{1}]  \n Andre køn  [{2}] \n År 0-10    [{3}] \n År 11-20   [{4}] \n År 21-30   [{5}] " +
                                  "\n År 31-40   [{6}] \n År 41-50   [{7}] \n År 51-60   [{8}] \n År 61-70   [{9}] \n År 71-80   [{10}] \n År 81+     [{11}]"
                                  , kvinder, mænd, andre, et, elleve, enogtyve, enogtredive, enogfyrre, enoghalvtreds, enogtres, enoghalvfjers, enogfirs);
                Console.WriteLine("\n Antal smittede: {0}", smittede);
                Console.WriteLine("\n Brug de følgende muligheder for at slå en mulighed til eller fra:" +
                                  "\n K = Kvinder " +
                                  "\n M = Mænd" +
                                  "\n O = Andre køn" +
                                  "\n A = 0-10" +
                                  "\n B = 11-20" +
                                  "\n C = 21-30" +
                                  "\n D = 31-40" +
                                  "\n E = 41-50" +
                                  "\n F = 51-60" +
                                  "\n G = 61-70" +
                                  "\n H = 71-80" +
                                  "\n I = 81+" +
                                  "\n T = Tilbage til hovedmenu");
                
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                switch (input[0])
                {
                    case 'T':
                        finish = true; // exit
                        break;

                    case 'K':
                        kvinder = !kvinder;  //inverts bool
                        if (kvinder)
                            smittede += 5;
                        else
                            smittede -= 5;
                        break;

                    case 'M':
                        mænd = !mænd;
                        if (mænd)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'O':
                        andre = !andre;
                        if (andre)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'A':
                        et = !et;  
                        if (et)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'B':
                        elleve = !elleve;
                        if (elleve)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'C':
                        enogtyve = !enogtyve;
                        if (enogtyve)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'D':
                        enogtredive = !enogtredive;
                        if (enogtredive)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'E':
                        enogfyrre = !enogfyrre;
                        if (enogfyrre)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'F':
                        enoghalvtreds = !enoghalvtreds;
                        if (enoghalvtreds)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'G':
                        enogtres = !enogtres;
                        if (enogtres)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'H':
                        enoghalvfjers = !enoghalvfjers;
                        if (enoghalvfjers)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    case 'I':
                        enogfirs = !enogfirs;
                        if (enogfirs)
                            smittede += 9;
                        else
                            smittede -= 9;
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }

    }
}