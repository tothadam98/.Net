using AlgorithmicsAPI.Data.Models;
using AlgorithmicsAPI.Data.Request;
using AlgorithmicsAPI.Data.Response;
using AlgorithmicsAPI.Repositories;

namespace AlgorithmicsAPI.Services
{
    public class AlgorithmService : IAlgorithmService
    {
        private readonly IAlgorithmRepository _algorithmRepository;

        public AlgorithmService(IAlgorithmRepository algorithmRepository)
        {
            _algorithmRepository = algorithmRepository;
        }

        public AlgorithmResponse AddNewAlgorithm(AlgorithmRequest algorithmRequest)
        {
            Algorithm algorithm = new Algorithm() { };

            return _algorithmRepository.AddNewAlgorithm(algorithm);
        }
    }

}
