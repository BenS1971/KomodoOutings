namespace OutingsRepo.repository;

public class OutingsRepository
{
    private List<Outings> _outings = new List<Outings>();
    
    //Create outings...
    public void  AddContentToList(Outings outings)
    {
        _outings.Add(outings);
    }
    //Read outings...
    public List<Outings> GetOutingsList();
    {
        return new List<Outings>(_ListOfOutings);
    }

    // Update outings...

    // Delete them outings (Bye bye.)...
    public bool RemoveOutingsFromList()
    {

    }
    //Helper Methods (NOT tuna or hamburger!!)
    private Outings GetOutingsFromList(string outings)
    {
        foreach (Outings content in _listOfOutings)
        {
            if (content.Outings == outings)
            {
                return content;
            }
        }
    }
}