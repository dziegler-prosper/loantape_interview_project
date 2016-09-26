namespace LoanTapeService.Models
{
    /// <summary>
    /// catalog of types of auditor: automated or manual
    /// </summary>
    public class AuditorModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}