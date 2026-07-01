class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int day in birdsPerDay){
            if(day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int numOfBirds = 0;
        for(int day = 0; day < numberOfDays; day++){
            numOfBirds += birdsPerDay[day];
        }
        return numOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach(int day in birdsPerDay){
            busyDays += day >= 5 ? 1 : 0;
        }
        return busyDays;
    }
}
