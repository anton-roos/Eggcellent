using Eggcellent.Models;
using Eggcellent.Models.Enums;
using System;
using System.Linq;

namespace Eggcellent.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EggcellentDbContext context)
        {
            if (context.UngradedEggs.Any())
            {
                return;
            }
            var random = new Random();
            var ungradedEggs = new UngradedEgg[]
            {
                new UngradedEgg{Quantity = random.Next(30)},
                new UngradedEgg{Quantity = random.Next(30)},
                new UngradedEgg{Quantity = random.Next(30)},
                new UngradedEgg{Quantity = random.Next(30)},
            };

            context.UngradedEggs.AddRange(ungradedEggs);
            context.SaveChanges();

            var rejectedEggs = new RejectedEgg[]
            {
                new RejectedEgg{Quantity = random.Next(30),
                    RejectionReason = RejectionReason.Cracked
                },
                new RejectedEgg{Quantity = random.Next(30),
                    RejectionReason = RejectionReason.Deformed
                },
                new RejectedEgg{Quantity = random.Next(30),
                    RejectionReason = RejectionReason.Deformed
                },
                new RejectedEgg{Quantity = random.Next(30),
                    RejectionReason = RejectionReason.Cracked
                },
            };

            context.RejectedEggs.AddRange(rejectedEggs);
            context.SaveChanges();

            var gradedEggs = new GradedEgg[]
            {
                new GradedEgg{Quantity = random.Next(30), EggSize = EggSize.Jumbo},
                new GradedEgg{Quantity = random.Next(30), EggSize = EggSize.Medium},
                new GradedEgg{Quantity = random.Next(30), EggSize = EggSize.Large},
                new GradedEgg{Quantity = random.Next(30), EggSize = EggSize.Small},
                new GradedEgg{Quantity = random.Next(30), EggSize = EggSize.ExtraLarge},
            };

            context.GradedEggs.AddRange(gradedEggs);
            context.SaveChanges();

            var soldEggs = new SoldEgg[]
            {
                new SoldEgg
                {
                    Quantity = random.Next(30),
                    EggSize = EggSize.Jumbo,
                    PricePerEgg = random.Next(5),
                    TotalPrice = random.Next(100)
                },
                new SoldEgg
                {
                    Quantity = random.Next(30),
                    EggSize = EggSize.Jumbo,
                    PricePerEgg = random.Next(5),
                    TotalPrice = random.Next(100)
                },
                new SoldEgg
                {
                    Quantity = random.Next(30),
                    EggSize = EggSize.Jumbo,
                    PricePerEgg = random.Next(5),
                    TotalPrice = random.Next(100)
                },
            };

            context.SoldEggs.AddRange(soldEggs);
            context.SaveChanges();
        }
    }
}