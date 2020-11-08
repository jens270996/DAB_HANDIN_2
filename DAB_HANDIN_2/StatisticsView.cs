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
            //Create statistic view, where you can get Covid19 case based on Sex, Age groups(0 - 10, 11 - 20, …).

            bool finish = false;
          
            do
            {
                Console.Clear();
                bool kvinder = false;
                bool mænd = false;
                bool et = false;
                bool elleve = false;
                bool enogtyve = false;
                bool enogtredive = false;
                bool enogfyrre = false;
                bool enoghalvtreds = false;
                bool enogtres = false;
                bool enoghalvfjers = false;
                bool enogfirs = false;
                float smittede = 0;

                string input;
                Console.WriteLine("Mulige tilvalg: \n Kvinder    [{0}]\n Mænd       [{1}] \n År 0-10    [{2}] \n År 11-20   [{3}] \n År 21-30   [{4}] " +
                                  "\n År 31-40   [{5}] \n År 41-50   [{6}] \n År 51-60   [{7}] \n År 61-70   [{8}] \n År 71-80   [{9}] \n År 81+     [{10}]"
                                  , kvinder, mænd, et, elleve, enogtyve, enogtredive, enogfyrre, enoghalvtreds, enogtres, enoghalvfjers, enogfirs);
                Console.WriteLine("\n Antal smittede: {0}", smittede);
                Console.WriteLine("\n Brug de følgende muligheder for at slå en mulighed til eller fra:" +
                                  "\n K = Kvinder " +
                                  "\n M = Mænd" +
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
                
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                switch (input[0])
                {
                    case 'T':
                        finish = true; // exit
                        break;

                    case 'A':
                        if (!et)
                        {
                            et = true;
                        }
                        else
                        {
                            et = false;
                        }

                        break;

                    case 'B':
                        
                        break;

                    case 'C':
                        
                        break;

                    case 'D':

                        break;

                    case 'E':

                        break;

                    case 'F':

                        break;

                    case 'G':

                        break;

                    case 'H':

                        break;

                    case 'I':

                        break;

                    default:
                        break;
                }

            } while (!finish);
        }

    }
}