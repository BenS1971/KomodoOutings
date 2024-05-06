namespace OutingsRepo.repository;

public class OutingsRepository
{
    private List<Outings> _listOfOutings = new List<Outings>();
    
    //Create outings...
    public void  AddContentToList(Outings outings)
    {
        _outings.Add(outings);
    }
    //Read outings...
    public List<Outings> GetOutingList(Outings);
    {
        return new List<Outings>(_listOfOutings);
    }

    // Update outings...
    public bool UpdateExistingOutings(string outings, Outings newOutings)
    {
        //Find that outings content...
        Outings oldContent = GetOutingList(outings);

        //...And then UPDATE that outing content. Okay? Okay.
        if (oldContent != null)
        {
            oldContent.TypeOfOuting = newOutings.TypeOfOuting;
            oldContent.OutingDate = newOutings.OutingDate;
            oldContent.CostPerPerson = newOutings.CostPerPerson;
            oldContent.TotalCostOfOuting = newOutings.TotalCostOfOuting;

            return true;
        }
        else
        {
            return false;
        }
        
    }
    

    // Delete them outings (Bye bye.)...
    public bool RemoveOutingsFromList(string outings)
    {
        Outings content = GetOutingList();
        if (content == null)
        {
            return false;
        }

        int initial = listOfOutings.Count;
        _listOfContent.Remove(content);

        if (initialCount > listOfOutings.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //Helper Methods (NOT tuna or hamburger!!)
    private Outings? GetOutingsFromList(string outings)
    {
        foreach (Outings content in _listOfOutings)
        {
            if (content.Outings == outings)
            {
                return content;
            }
        }
        return null;
    }
}