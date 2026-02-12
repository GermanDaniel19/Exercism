class RemoteControlCar
{
    private int _battery = 100;
    private int _meters;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        if (_battery == 0){
            return "Battery empty";
        }else{
            return $"Battery at {_battery}%";
        }
    }

    public void Drive()
    {
        if(_battery > 0){
           
            _battery -= 1;
            _meters += 20;
        
        }
    }
}
