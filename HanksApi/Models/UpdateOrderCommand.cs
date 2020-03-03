using System;

namespace HanksApi.Models
{
    public class UpdateOrderCommand
    {
        public Guid OrderId { get; set; }
        public string DriverComment { get; set; }
        public double? Weight { get; set; }
    }
}
