class RemoteControlCar
{
    public int Distance = 0;
    public int BatteryPercentage = 100;

    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        if (BatteryPercentage > 0)
            return $"Battery at {BatteryPercentage}%";
        else
            return $"Battery empty";
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
            Distance += 20;
            BatteryPercentage -= 1;
        
        
    }
}
