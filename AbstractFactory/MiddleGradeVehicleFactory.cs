namespace AbstractFactory
{
    public class MiddleGradeVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike() => new MiddleGradeBike();
        public ICar CreateCar() => new MiddleGradeCar();
    }

}
