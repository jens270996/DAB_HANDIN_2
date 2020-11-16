using Covid19_Tracking;
using Covid19_Tracking.Domain;
using Covid19_Tracking.Persistence;
using System;
using System.Linq;
using System.Linq.Expressions;
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

                        break;

                    case 'C':
                        //tilføj testcenter og testmanagment
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            var testCenter = new TestCenter(17);

                            unitOfWork.TestCenters.Add(testCenter);
                            unitOfWork.Complete();
                            if(unitOfWork.TestCenters.GetAll().Where(t=>t.TestCenterId==1).Any())
                            unitOfWork.TestCenterManagements.Add(new TestCenterManagement(1,"jens@maiL", 2709));
                            unitOfWork.Complete();
                        }
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