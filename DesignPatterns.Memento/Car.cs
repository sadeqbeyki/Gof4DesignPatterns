namespace DesignPatterns.Memento;

//step 2
public class Car
{
    private int _fuel;
    private int _speed;

    public Car()
    {
    }

    public Car(CarState carState)
    {
        _fuel = carState.Fuel;
        _speed = carState.Speed;
    }

    public void AddFuel(int value)
    {
        _fuel += value;
    }

    public void IncreaseSpeed()
    {
        _speed++;
    }

    public void DecreaseSpeed()
    {
        _speed--;
    }

    public void Kilometer()
    {
        _fuel -=6;
    }

    public CarState GetState()
    {
        return new CarState
        {
            Fuel = _fuel,
            Speed = _speed
        };
    }
}
