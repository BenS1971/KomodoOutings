

namespace KomodoOutings.console;
public class ProgramUI
{
    //The method that run and/or starts the app...
    public void Run()
    {
        Menu();
    }
    //The Menu, Monsieur.
    private void Menu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
        //Display the options 2 the user...
        System.Console.WriteLine("Welcome to the Komodo Outings Application. Please select a menu option:\n" + 
            "1. Create a new outing\n" +
            "2. View Existing outings\n" +
            "3. View outing by outing TYPE\n" +
            "4. Update an outing\n"+ 
            "5. Delete an existing outing\n" +
            "6. Exit this app.");

            //Getting the user's input here...

            string input = Console.ReadLine();

            //Evaluating user input and do the output accordingly...
            switch (input)
            {
                case "1":
                    //Creating an outing
                    CreateNewOuting();
                    break;
                case "2":
                    //Looking at existing outing...
             
                    break;
                case "3":
                    //Looking at outing list, except with the TYPE of outing.
                  
                    break;
                case "4":
                    //Update an outing.
                   
                    break;
                case "5":
                    //Deleting an outing.
                    
                    break;
                case "6":
                    System.Console.WriteLine("Goodbye.");
                    keepRunning = false;
                    break;
                default:
                    System.Console.WriteLine("Please enter a valid number.");
                    break;
                    }

                    System.Console.WriteLine("Please press any key to continue...");
                    System.Console.ReadKey();
                    System.Console.Clear();
        }
    }
    private void CreateNewOuting();
    {
        System.Console.Clear;
        Outings newOuting = new Outings();
    }
  
}