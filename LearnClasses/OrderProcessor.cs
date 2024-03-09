using System;
namespace LearnClasses
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already shipped");
            }
            else
            {
                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculateShipping(order),
                    ShippingDate = DateTime.Now.AddDays(1)
                };
            }
        }

    }
}