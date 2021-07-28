using Eggcellent.Models.Enums;
{

}

namespace Eggcellent.Models
{
    public class RejectedEgg : BaseModel
    {
        public int Quantity { get; set; }
        public RejectionReason RejectionReason { get; set; }
    }
}