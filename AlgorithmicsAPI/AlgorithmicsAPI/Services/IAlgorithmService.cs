using AlgorithmicsAPI.Data.Request;
using AlgorithmicsAPI.Data.Response;

namespace AlgorithmicsAPI.Services
{
    public interface IAlgorithmService
    {
        public AlgorithmResponse AddNewAlgorithm(AlgorithmRequest algorithmRequest);
    }
}
