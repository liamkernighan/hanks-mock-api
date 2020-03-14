using System;

namespace HanksApi.Models
{
    public class OrderView
    {
        public static OrderView[] GenerateMock()
        {
            return new[]
            {
                new OrderView
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    Weight = 80,
                    DriverComment = "Driver comment here",
                    DispatcherComment = "До 18-00",
                    JobType = "Перевозка груза",
                    PaymentType = "Безналичный расчет",
                    Price = 500,
                    DriverName = "Алынбек",
                },
                new OrderView
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Today.AddDays(-1),
                    Weight = 160,
                    DriverComment = "Заявка 2",
                    DispatcherComment = "",
                    Price = 40,
                    JobType = "Перевозка груза",
                    PaymentType = "Наличный расчет",
                    DriverName = "Алынбек",
                },
            };
        }

        public DateTime Date { get; set; }
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public string DriverComment { get; set; }
        public string DispatcherComment { get; set; }
        public decimal Price { get; set; }
        public string JobType { get; set; }
        public string PaymentType { get; set; }
        public string DriverName { get; set; }
    }
}
