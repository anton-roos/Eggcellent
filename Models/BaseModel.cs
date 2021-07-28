using System;

namespace Eggcellent.Models
{
    public class BaseModel
    {
        public BaseModel() {
            Id = new Guid();
            Date = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime Date { get; set; }

    }
}
