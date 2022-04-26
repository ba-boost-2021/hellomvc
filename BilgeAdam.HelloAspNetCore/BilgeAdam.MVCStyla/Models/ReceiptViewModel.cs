namespace BilgeAdam.MVCStyla.Models
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageCode { get; set; }
        public string Tariff { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
