using System;
using Covid19_Tracking;
using Covid19_Tracking.Persistence;
using Covid19_Tracking.Persistence.Repositories;

namespace DAB_HANDIN_2
{
    public class CreateView
    {
        public CreateView()
        {

        }

        public void OpenCreateMenu()
        {
            bool finish = false;
            do
            {
                Console.Clear();
                Console.WriteLine("***** Tilføj data menu ***** \n");
                Console.WriteLine("Vælg en af følgende muligheder: \n - Tilføj en ny borger \n - Tilføj et nyt testcenter med ledelse" +
                                  "\n - Tilføj nyt testresultat \n - Tilføj ny lokation ");
                Console.WriteLine("\n Indtast et af de følgende bogstaver for at åbne en mulighed: \n T = Tilbage " +
                                  "\n B = Tilføj borger \n C = Tilføj testcenter \n R = Tilføj testresultat \n L = Tilføj lokation ");


                //*Create new Citizen
                //Create new TestCenter and TestCenterManagement
                //Create new Tests case
                //Create new Location

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                switch (input[0])
                {
                    case 'T':
                        finish = true; // exit
                        break;

                    case 'B':
                        // tilføj ny borger
                        
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            
                        }

                        break;

                    case 'C':
                        //tilføj testcenter og testmanagment
                        break;

                    case 'R':
                        //tilføj testresultat
                        break;

                    case 'L':
                        // tilføj lokation
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }
    }
}