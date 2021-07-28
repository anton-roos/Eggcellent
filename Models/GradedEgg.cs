using Eggcellent.Models.Enums;

namespace Eggcellent.Models
{
    public class GradedEgg : BaseModel
    {
        public int Quantity { get; set; }
        public EggSize EggSize { get; set; }
    }
}