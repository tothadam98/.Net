using Algorithmics.Data.Request;
using Algorithmics.Data.Response;

namespace Algorithmics.Services
{
    public interface IAlgorithmService
    {
        public AlgorithmResponse AddNewAlgorithm(AlgorithmRequest algorithmRequest);
    }
}
