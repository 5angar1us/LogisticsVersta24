namespace LogisticsVersta24.Models
{
    public class Order
    {
        public Order(Guid id)
        {
            Id = id;
        }

        public Order(string fromCity, string fromAddress, string toCity, string toAddress, int weightInGrams, DateTime receivedDate)
        {
            FromCity = fromCity;
            FromAddress = fromAddress;
            ToCity = toCity;
            ToAddress = toAddress;
            WeightInGrams = weightInGrams;
            ReceivedDate = receivedDate;
        }

        public Order(Guid id, string fromCity, string fromAddress, string toCity, string toAddress, int weightInGrams, DateTime receivedDate)
        {
            Id = id;
            FromCity = fromCity;
            FromAddress = fromAddress;
            ToCity = toCity;
            ToAddress = toAddress;
            WeightInGrams = weightInGrams;
            ReceivedDate = receivedDate;
        }

        public Order()
        {

        }

        public Guid Id { get; set; }
        public string FromCity { get; set; }
        public string FromAddress { get; set; }
        public string ToCity { get; set; }
        public string ToAddress { get; set; }
        public int WeightInGrams { get; set; }
        public DateTime ReceivedDate { get; set; }

    }
}
