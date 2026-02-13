class RemoteControlCar
{
    private int _Speed;
    private int _Battery = 100;
    private int _BatteryDrain;
    private int _DistanceDriven = 0;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._Speed = speed;
        this._BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained() 
    {
        if (this._Battery >= this._BatteryDrain)
            return false;
        return true;
    }

    public int DistanceDriven() => this._DistanceDriven;

    public void Drive()
    {
        if (this._Battery >= this._BatteryDrain)
        {
            this._DistanceDriven += this._Speed;
            this._Battery -= this._BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _Distance;

    public RaceTrack(int distance)
    {
        this._Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while( car.DistanceDriven() < this._Distance)
        {
            car.Drive();
            if (car.BatteryDrained() && car.DistanceDriven() < this._Distance )
                return false;
        }
        return true;
    }
}
