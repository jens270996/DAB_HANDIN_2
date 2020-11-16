using System;

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

                    case 'A':
                        

                        break;

                    case 'S':
                        
                        break;

                    case 'U':
                        
                        break;

                    case 'N':
                        
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }
    }
}