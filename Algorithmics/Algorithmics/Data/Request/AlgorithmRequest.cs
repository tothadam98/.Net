using static Algorithmics.Data.Models.Enums;

namespace Algorithmics.Data.Request
{
    public class AlgorithmRequest
    {
        public string Name { get; set; }
         
        public string Description { get; set; }
        public string Icon { get; set; }

        public AlgorithmType AlgorithmType { get; set; }
    }
}
