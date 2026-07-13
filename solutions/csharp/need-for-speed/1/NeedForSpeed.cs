class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int Speed {get; private set;}
    public int BatteryDrain {get; private set;}
    private int _batteryLevel = 100;
    private int _distanceDriven = 0;

    public RemoteControlCar(int speed, int batteryDrain){
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return this._batteryLevel >= this.BatteryDrain ? false : true;
    }

    public int DistanceDriven()
    {
        return this._distanceDriven;
    }

    public void Drive()
    {
        if(this._batteryLevel >= this.BatteryDrain){
            this._batteryLevel -= this.BatteryDrain;
            this._distanceDriven += this.Speed;
        } 
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    int _trackDistance;

    public RaceTrack(int trackDistance){
        this._trackDistance = trackDistance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        double requiredTime = this._trackDistance / (double)car.Speed;
        double neededBattery = requiredTime * car.BatteryDrain;
        return (int)neededBattery <= 100 ? true : false;
    }
}
