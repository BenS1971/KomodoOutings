namespace OutingsRepo.repository;

public enum OutingType
{
    AmusementPark = 1,
    Golfing,
    BaseballGame,
    Bowling,
    SmashingMailboxes,
    Concert,
    BeachTrip,
    MiscOuting,
}

//This is the repository for the Komodo outings with the POCOs...
 public class Outings
{
    public  int OutingID { get; set;  }
    public DateTime OutingDate { get; set;}

    public int NumberOfPeople { get; set; }

    public double CostPerPerson { get; set;}

    public double TotalCostOfOuting { get; set;}

    public OutingType TypeOfOuting { get; set; }

    public Outings() {}
    
    public Outings(string outingDate, string numberOfPeople, double costPerPerson, double totalCostPerPerson, string typeOfOuting)
    { 
        OutingDate = OutingDate;
        NumberOfPeople = NumberOfPeople;
        CostPerPerson = CostPerPerson;
        TotalCostOfOuting = TotalCostOfOuting;
        TypeOfOuting = TypeOfOuting;
    }

 
}