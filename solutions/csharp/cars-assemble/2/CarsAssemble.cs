static class AssemblyLine
{    
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        if (1 <= speed && speed <= 4)
            return 1;
        if (5 <= speed && speed <= 8)
            return 0.9;
        if (speed == 9)
            return 0.8;
        return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * SuccessRate(speed) * speed;

    public static int WorkingItemsPerMinute(int speed)
    {
        double value = ((221.0 * speed)/60) * SuccessRate(speed); 
        return (int)value;
    }
}
