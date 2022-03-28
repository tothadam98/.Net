using Algorithmics.Data.Models;
using Algorithmics.Data.Response;

namespace Algorithmics.Repositories
{
    public interface IAlgorithmRepository
    {
        public AlgorithmResponse AddNewAlgorithm(Algorithm algorithm);
    }
}
