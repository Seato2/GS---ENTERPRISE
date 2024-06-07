namespace MarinePollutionApi.Models
{
    public class PollutionRecords
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Quantity { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
