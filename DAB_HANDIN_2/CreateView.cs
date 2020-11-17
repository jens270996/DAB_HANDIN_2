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
                                  "\n B = Tilføj borger \n C = Tilføj testcenter \n O = Tilføj testledelse \n R = Tilføj testresultat \n L = Tilføj lokation ");


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
                        Console.WriteLine("Indtast Navn på borgers kommune:");
                        var muni = Console.ReadLine();
                        var mun = new UnitOfWork(new CovidContext()).Municipalities.Find(c => c.Name == muni).First();
                        if(mun.Name==muni)
                        {
                            Console.WriteLine("Indtast Navn, ssn, alder, køn: \"Fornavn efternavn ssn alder køn\"");
                            var tokens = Console.ReadLine().Split(" ");
                            int val;
                            if (tokens.Length == 5 && int.TryParse(tokens[3], out val))
                            {
                                using (var unitOfWork = new UnitOfWork(new CovidContext()))
                                {
                                    var cit = new Citizen(mun.ID, tokens[0], tokens[1], tokens[2], val, tokens[4]);

                                    unitOfWork.Citizens.Add(cit);
                                    unitOfWork.Complete();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ugyldig data.");
                            }

                            // tilføj ny borger
                            
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt kommune-navn.");
                        }

                        break;

                    case 'C':
                        string[] hoursarr;
                        int open;
                        int close;
                        do
                        {

                            Console.WriteLine("Enter Test center hours: \"open close\"");
                            string hours = Console.ReadLine();
                            hoursarr = hours.Split(" ");
                        }
                        while (hoursarr.Length != 2 || !int.TryParse(hoursarr[0], out open) || !int.TryParse(hoursarr[1], out close));
                        //tilføj testcenter og testmanagment
                        Console.WriteLine("Enter Test center name: \"name\"");
                        string name=Console.ReadLine();
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            var testCenter = new TestCenter(open,close,name);

                            unitOfWork.TestCenters.Add(testCenter);
                            unitOfWork.Complete();
                        }
                        break;
                    case 'O':
                        //tilføj Testledelse
                        Console.WriteLine("Skriv navn på testcenter der ledes:");
                        name = Console.ReadLine();
                        Console.WriteLine("Indtast telefon nr. og email: \"tlf email\"");
                        string[] res = Console.ReadLine().Split(" ");
                        using (var unitOfWork = new UnitOfWork(new CovidContext()))
                        {
                            TestCenter center = unitOfWork.TestCenters.GetAll().Where(s => s.CenterName == name).First();
                            TestCenterManagement testCenterManagement = null;
                            if (center != null)
                            {
                                testCenterManagement = new TestCenterManagement(center.TestCenterId, res[0], int.Parse(res[1]));


                                unitOfWork.TestCenterManagements.Add(testCenterManagement);
                                unitOfWork.Complete();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Center name");
                            }
                        }
                        break;

                    case 'R':
                        //tilføj testresultat
                        Console.WriteLine("")
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