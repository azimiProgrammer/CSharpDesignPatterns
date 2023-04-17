using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ICar { }
    public interface IBike { }
    public class LowGradeCar : ICar { }
    public class LowGradeBike : IBike { }
    public class HighGradeCar : ICar { }
    public class HighGradeBike : IBike { }
}
