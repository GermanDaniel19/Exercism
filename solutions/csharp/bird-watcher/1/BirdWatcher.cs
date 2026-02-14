class BirdCount
{
    private int[] birdsPerDay;

    
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length -1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length -1] +=1;
    }

    public bool HasDayWithoutBirds()
    {
        int count = 0;
        foreach( int bird in birdsPerDay )
        {
            if (bird == 0)
            {
                count += 1;
            }
        }
        if (count > 0)
        {
            return true;
        }else
        {
            return false;
        }
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int countBirds = 0;
        
        for(int i = 0 ; i < numberOfDays ; i++)
        {
            countBirds += birdsPerDay[i];
                
        }
        return countBirds;
    }

    public int BusyDays()
    {
        int countBirdsBusy = 0;
        foreach(int bird in birdsPerDay)
        {
            if(bird >= 5)
            {
                countBirdsBusy ++;
            }
        }
        return countBirdsBusy;
    }
}
