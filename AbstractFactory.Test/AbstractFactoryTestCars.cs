namespace AbstractFactory.Test
{
    public class AbstractFactoryTestCars : AbstractFactoryBaseTestData
    {
        public AbstractFactoryTestCars()
        {
            AddTestData<LowGradeVehicleFactory, LowGradeCar>();
            AddTestData<HighGradeVehicleFactory, HighGradeCar>();
        }
    }


}
