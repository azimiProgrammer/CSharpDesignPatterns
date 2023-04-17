namespace AbstractFactory
{
    public class HighGradeVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike() => new HighGradeBike();
        public ICar CreateCar() => new HighGradeCar();
    }

}
