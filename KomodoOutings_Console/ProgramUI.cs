
using System.ComponentModel.Design;


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
                    DisplayOuting();
             
                    break;
                case "3":
                    //Looking at outing list, except with the TYPE of outing.
                    DisplayOutingList();
                    break;
                case "4":
                    //Update an outing.
                    //UpdateExistingOuting();
                    break;
                case "5":
                    //Deleting an outing.
                    RemoveOutingsFromList();
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

 

    //Create new outing...

    private void CreateNewOuting()
    {
        System.Console.Clear();
        Console.WriteLine("Please enter an Outing ID Number:");
        System.Console.ReadLine();
    }
    
    //Get outing from list...
    public void GetOutingFromList()
    {
        System.Console.Clear();
        Console.WriteLine("Please enter an outing to view by Outing ID or Outing Type.");
        System.Console.ReadLine();
    }
    //Display an outing...
        
    
    public void DisplayOuting()
    {
        System.Console.Clear();
        System.Console.WriteLine("Please enter the Outing ID that you would like to see: ");
        System.Console.ReadLine();

    }

    //Update existing outing...
    public void UpdateExistingOutings()
    {
        System.Console.Clear();
        System.Console.WriteLine("Please enter the Outing ID of the outing you want to update: ");
        System.Console.ReadLine();
    }

    // Delete an outing...
    public void RemoveOutingsFromList()
    {
        System.Console.Clear();
        System.Console.WriteLine("Please enter the outing number of the outing you want to delete: ");
        System.Console.ReadLine();
    }
  
}