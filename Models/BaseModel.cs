using System;

namespace Eggcellent.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public void SetTimestamps(bool created)
        {
            var now = DateTime.UtcNow;

            if (created)
            {
                Date = now;
            }
        }
    }
}
