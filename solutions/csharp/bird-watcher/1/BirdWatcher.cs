class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        var todayIndex = birdsPerDay.Length - 1;
        return birdsPerDay[todayIndex];
    }

    public void IncrementTodaysCount()
    {
        var todayIndex = birdsPerDay.Length - 1;
        birdsPerDay[todayIndex]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        };
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var totalBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalBirds += birdsPerDay[i];
        };
        return totalBirds;
    }

    public int BusyDays()
    {
        var busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
