using System;
using System.Collections.Generic;
using System.Linq;
using Covid19_Tracking;
using Covid19_Tracking.Domain;
using Covid19_Tracking.Persistence;
using Covid19_Tracking.Persistence.Repositories;

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
                                  "\n - Se deataljeret statistik over smittede baseret på aldersgruppe og køn \n - Udregn mulige smittede ved nyeste smittetilfælde" +
                                  "\n - Tilføj nyt smittetilfælde, testcenter, testsag eller ny lokation" +
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
                            var totalInfected = unitOfWork.Citizens.GetInfectedCitizens();
                            Console.WriteLine("Total antal smittede: {0}", totalInfected);
                            // udskriv per municipality
                            var infectedPerMunicipality = unitOfWork.Municipalities.GetInfectedByMunicipality();
                            List<MunicipalityPair> pairs = infectedPerMunicipality.ToList();
                            Console.WriteLine("Kommune:             Antal smittede:");
                            for (int i = 0; i < pairs.Count; i++)
                            {
                                Console.WriteLine(pairs[i].municipality+ "          " + pairs[i].infected);
                            }
                        }
                       

                        break;

                    case 'S':
                        // åben stat menu
                        statView.OpenStatMenu();
                        break;

                    case 'U':
                        //Given a new infected citizen, “calculate” which other citizen may be infected .
                        Console.WriteLine("Indtast id på smittet person.");
                        string id=Console.ReadLine();

                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            var cit = unitOfWork.Citizens.Get(int.Parse(id));
                            var possibleInfected = unitOfWork.Citizens.GetPossibleInfectedCitizens(cit);
                            List<Citizen> possibleInfectedList = possibleInfected.ToList();
                            Console.WriteLine("\n Muligt smittede borgere: {0}", possibleInfectedList);
                            for (int i = 0; i < possibleInfectedList.Count(); i++)
                            { 
                                Console.WriteLine("\n" + possibleInfectedList[i]);
                            }
                        }
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
