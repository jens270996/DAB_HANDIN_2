using System;

namespace DAB_HANDIN_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanser af objekter her
            StatisticsView statView = new StatisticsView();

            bool finish = false;
            Console.WriteLine("***** Velkommen til Covid19 tracking app ***** \n" +
                              "\n Følgende muligheder er tilgængelige: \n - Exit \n - Vis antal aktive Covid19 patienter per kommune" +
                              "\n - Se deataljeret statistik over smittede baseret op aldersgruppe og køn \n - Indtast nyt smittetilfælde" +
                              "\n ");

            do
            {
                string input;
                Console.WriteLine(" Indtast et af de følgende bogstaver for at åbne en mulighed: \n E = exit " +
                                  "\n A = Aktive pr. kommune \n S = Åben statistik \n N = Nyt tilfælde ");
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

                        break;

                    case 'S':
                        statView.OpenStatMenu();
                        break;

                    case 'N':
                        //Given a new infected citizen, “calculate” which other citizen may be infected .
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }
    }
}
