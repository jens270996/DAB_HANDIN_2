using System;
using Covid19_Tracking;
using Covid19_Tracking.Persistence;

namespace DAB_HANDIN_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanser af objekter her
            StatisticsView statView = new StatisticsView();
            CreateView createView = new CreateView();

            bool finish = false;

            do
            {
                Console.Clear();
                string input;
                Console.WriteLine("***** Velkommen til Covid19 tracking app ***** \n" +
                                  "\n Følgende muligheder er tilgængelige: \n - Exit \n - Vis antal aktive Covid19 patienter per kommune" +
                                  "\n - Se deataljeret statistik over smittede baseret op aldersgruppe og køn \n - Udregn mulige smittede ved nyeste smittetilfælde" +
                                  "\n - Tilføj nyt smittetilfælde, testcenter, testsag ellerny lokation" +
                                  "\n ");
                Console.WriteLine(" Indtast et af de følgende bogstaver for at åbne en mulighed: \n E = exit " +
                                  "\n A = Aktive pr. kommune \n S = Åben statistik \n U = Mulige nye smittede \n N = Tilføj data ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                switch (input[0])
                {
                    case 'E':
                        finish = true; // exit
                        break;

                    case 'A':
                        //Calculate the number of active Covid19 cases - a person is infected 14 days after a positive
                        //test. Results should be shown per Municipality.
                        
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            unitOfWork.Citizens.GetInfectedCitizens();
                        }
                       

                        break;

                    case 'S':
                        // åben stat menu
                        statView.OpenStatMenu();
                        break;

                    case 'U':
                        //Given a new infected citizen, “calculate” which other citizen may be infected .
                        break;

                    case 'N':
                        //åben create menu
                        createView.OpenCreateMenu();
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }
    }
}
