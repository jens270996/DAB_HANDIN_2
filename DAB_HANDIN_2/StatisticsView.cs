using System;
using Covid19_Tracking;
using Covid19_Tracking.Persistence;

namespace DAB_HANDIN_2

{
    public class StatisticsView
    {
        public StatisticsView()
        {

        }

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

        public void AllBoolsFalse()
        {
            kvinder = false;
            mænd = false;
            andre = false;
            et = false;
            elleve = false;
            enogtyve = false;
            enogtredive = false;
            enogfyrre = false;
            enoghalvtreds = false;
            enogtres = false;
            enoghalvfjers = false;
            enogfirs = false;
        }

        public void OpenStatMenu()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("***** Statistik menu ***** \n");
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
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(0, 150, "female");
                            var numberOfInfected = 30;
                            kvinder = !kvinder;
                            if (kvinder)
                            {
                                AllBoolsFalse();
                                kvinder = !kvinder; //inverts bool
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'M':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(0, 150, "male");
                            var numberOfInfected = 55;
                            mænd = !mænd;
                            if (mænd)
                            {
                                AllBoolsFalse();
                                mænd = !mænd;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;
                        
                    case 'O':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(0, 10, "either");
                            var numberOfInfected = 97;
                            andre = !andre;
                            if (andre)
                            {
                                AllBoolsFalse();
                                andre = !andre;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'A':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(0, 150, "either");
                            var numberOfInfected = 22;
                            et = !et;
                            if (et)
                            {
                                AllBoolsFalse();
                                et = !et;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'B':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(11, 20, "either");
                            var numberOfInfected = 55;
                            elleve = !elleve;
                            if (elleve)
                            {
                                AllBoolsFalse();
                                elleve = !elleve;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'C':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(21, 30, "either");
                            var numberOfInfected = 876;
                            enogtyve = !enogtyve;
                            if (enogtyve)
                            {
                                AllBoolsFalse();
                                enogtyve = !enogtyve;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'D':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(31, 40, "either");
                            var numberOfInfected = 345;
                            enogtredive = !enogtredive;
                            if (enogtredive)
                            {
                                AllBoolsFalse();
                                enogtredive = !enogtredive;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'E':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(41, 50, "either");
                            var numberOfInfected = 11;
                            enogfyrre = !enogfyrre;
                            if (enogfyrre)
                            {
                                AllBoolsFalse();
                                enogfyrre = !enogfyrre;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'F':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(51, 60, "either");
                            var numberOfInfected = 76544;
                            enoghalvtreds = !enoghalvtreds;
                            if (enoghalvtreds)
                            {
                                AllBoolsFalse();
                                enoghalvtreds = !enoghalvtreds;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'G':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(61, 70, "either");
                            var numberOfInfected = 5555;
                            enogtres = !enogtres;
                            if (enogtres)
                            {
                                AllBoolsFalse();
                                enogtres = !enogtres;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'H':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(71, 80, "either");
                            var numberOfInfected = 666;
                            enoghalvfjers = !enoghalvfjers;
                            if (enoghalvfjers)
                            {
                                AllBoolsFalse();
                                enoghalvfjers = !enoghalvfjers;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    case 'I':
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            //var numberOfInfected = unitOfWork.Citizens.InfectedInterval(81, 150, "either");
                            var numberOfInfected = 666;
                            enogfirs = !enogfirs;
                            if (enogfirs)
                            {
                                AllBoolsFalse();
                                enogfirs = !enogfirs;
                                smittede = numberOfInfected;
                            }
                            else
                            {
                                AllBoolsFalse();
                                smittede = 0;
                            }
                        }
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }

    }
}