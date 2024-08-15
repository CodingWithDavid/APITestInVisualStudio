namespace SamplesWithHTTPFiles.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; } // Foreign key to the Customer
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; } // Nullable if not yet shipped
        public string ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
