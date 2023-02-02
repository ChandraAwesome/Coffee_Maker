using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTtestDemo_Coffeemakerdemo
{
    public interface IMakeACoffee
    {
        bool CheckIngredientAvailability();
        string CoffeeMaking(int sugerPerSpoon, int CoffeePack);
    }
}
