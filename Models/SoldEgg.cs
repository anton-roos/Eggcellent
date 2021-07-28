using Eggcellent.Models.Enums;

namespace Eggcellent.Models
{
    public class SoldEgg : BaseModel
    {
        public int Quantity { get; set; }
        public EggSize EggSize { get; set; }
        public double PricePerEgg { get; set; }
        public double TotalPrice { get; set; }
    }
}