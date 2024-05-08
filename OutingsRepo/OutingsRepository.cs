namespace OutingsRepo.repository;

public class OutingsRepository
{
    
    private List<Outings> _listOfOutings = new List<Outings>();
    
    //Create outings...
    public void  AddContentToList(Outings outings)
    {
        _listOfOutings.Add(outings);
    }
    //Read outings...
     public List<Outings> GetOutingList()
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
        Outings content = GetOutingFromList();
        if (content == null)
        {
            return false;
        }

        int initial = _listOfOutings.Count;
        _listOfOutings.Remove(content);

        if (initialCount > _listOfOutings.Count)
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
            if (content.outings == outings)
            {
                return content;
            }
        }
        return null;
    }
    
}