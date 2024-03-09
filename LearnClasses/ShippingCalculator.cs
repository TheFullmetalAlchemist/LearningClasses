namespace LearnClasses
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if(order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            else
            {
                return 0;
            }
        }
    }
}
