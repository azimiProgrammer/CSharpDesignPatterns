namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        IBike CreateBike();
    }
}
