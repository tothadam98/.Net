using AlgorithmicsAPI.Data.Models;

namespace AlgorithmicsAPI.Data.Response
{
    public class AlgorithmResponse
    {
        public Algorithm Algorithm { set; get; }
        public string Message { set; get; }
        public int ErrorCode { set; get; }
    }
}
