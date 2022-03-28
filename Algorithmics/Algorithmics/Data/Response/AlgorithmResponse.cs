using Algorithmics.Data.Models;

namespace Algorithmics.Data.Response
{
    public class AlgorithmResponse
    {
        public Algorithm Algorithm { set; get; }
        public string Message { set; get; }
        public int ErrorCode { set; get; }
    }
}
