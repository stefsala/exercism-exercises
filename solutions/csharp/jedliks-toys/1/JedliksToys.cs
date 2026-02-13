class RemoteControlCar
{
    private int _battery = 100;
    private int _distance = 0;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven " + this._distance + " meters";
    }

    public string BatteryDisplay()
    {
        if (this._battery >0)
            return "Battery at " + this._battery + "%";
        else 
            return "Battery empty";
    }

    public void Drive()
    {
        if (this._battery > 0) {
            this._distance += 20;
            this._battery -= 1;
        }
    }
}
