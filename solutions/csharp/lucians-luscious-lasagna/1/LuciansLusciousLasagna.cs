class Lasagna
{
    public int ExpectedMinutesInOven() {
        return 40;
    }

    public int RemainingMinutesInOven(int time) {
        return 40 - time;
    }

    public int PreparationTimeInMinutes(int layers) {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int time_passed) {
        return 2 * layers + time_passed;
    }
}
