using System.ComponentModel.DataAnnotations;

namespace StockStimulationWebApp.Models
{
    public class companyShares
    {
        
        public string companyName { get; set; }
        [Key]
        public string companySymbol { get; set; }
        public string companyImage { get; set; }
    }
}
