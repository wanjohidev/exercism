class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;

    private int batteryCharge = 100;
    private int distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if ((batteryCharge - _batteryDrain) < 0)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += _speed;
            batteryCharge -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
       return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _trackDistance;

    public RaceTrack(int trackDistance)
    {
        _trackDistance = trackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= _trackDistance;
    }
}
