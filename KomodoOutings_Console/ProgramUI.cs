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
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;

            }

    }
}