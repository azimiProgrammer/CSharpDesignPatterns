namespace AbstractFactory.Test
{
    public class AbstractFactoryTestBikes : AbstractFactoryBaseTestData
    {
        public AbstractFactoryTestBikes()
        {
            AddTestData<LowGradeVehicleFactory, LowGradeBike>();
            AddTestData<HighGradeVehicleFactory, HighGradeBike>();
            AddTestData<MiddleGradeVehicleFactory, MiddleGradeBike>();
        }
    }


}
