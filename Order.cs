namespace SedapMakanChefModule
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Order #{OrderId} - {CustomerName} - {Status}";
        }
    }
}
