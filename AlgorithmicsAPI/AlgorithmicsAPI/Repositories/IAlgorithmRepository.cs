using AlgorithmicsAPI.Data.Models;
using AlgorithmicsAPI.Data.Request;
using AlgorithmicsAPI.Data.Response;

namespace AlgorithmicsAPI.Repositories
{
    public interface IAlgorithmRepository
    {
        public AlgorithmResponse AddNewAlgorithm(Algorithm algorithm);
    }
}
