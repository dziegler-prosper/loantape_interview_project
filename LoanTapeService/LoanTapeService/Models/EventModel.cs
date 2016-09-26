namespace LoanTapeService.Models
{
    /// <summary>
    /// catalog of events. ex. sign documents, loan originated, etc.
    /// </summary>
    public class EventModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  description { get; set; }
    }
}