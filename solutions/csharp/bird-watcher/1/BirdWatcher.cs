class BirdCount
{
    private int[] birdsPerDay;
    private static int[] _lastWeek = {0, 2, 5, 3, 7, 8, 4};

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => _lastWeek;

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++)
            counter += birdsPerDay[i];
        return counter;
    }

    public int BusyDays()
    {
        int counter = 0;
        for (int i = 0; i < birdsPerDay.Length; i++) 
            if (birdsPerDay[i] >= 5)
                counter++;
        return counter;
    }
}
