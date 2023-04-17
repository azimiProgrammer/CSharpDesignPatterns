namespace AbstractFactory
{
    public class LowGradeVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike() => new LowGradeBike();
        public ICar CreateCar() => new LowGradeCar();
    }
}
