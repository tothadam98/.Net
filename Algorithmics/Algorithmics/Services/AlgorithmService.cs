using Algorithmics.Data.Models;
using Algorithmics.Data.Request;
using Algorithmics.Data.Response;
using Algorithmics.Repositories;


namespace Algorithmics.Services
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
            Algorithm algorithm = new Algorithm() {
            Name=algorithmRequest.Name,
            Description = algorithmRequest.Description,
            Icon = algorithmRequest.Icon,
            Type = algorithmRequest.AlgorithmType,
            IsPublished = true,
            CreationDate = DateTime.Now,
            Url = "kecsske"
            };

            return _algorithmRepository.AddNewAlgorithm(algorithm);
        }
    }

}
