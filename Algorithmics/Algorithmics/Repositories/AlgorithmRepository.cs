using Algorithmics.Data;
using Algorithmics.Data.Models;
using Algorithmics.Data.Response;

namespace Algorithmics.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {
        private readonly AppDbContext _context;

        public AlgorithmRepository(AppDbContext context)
        {
            _context = context;
        }

        public AlgorithmResponse AddNewAlgorithm(Algorithm algorithm)
        {
            var result = _context.Algorithms.Add(algorithm);
            var entries = _context.SaveChanges();
            var response = new AlgorithmResponse()
            {
                Algorithm = result.Entity
            };
            if (entries != null)
            {
                response.Message = "Algorithm added";
                response.ErrorCode = 200;
            }
            else
            {
                response.Message = "Error";
                response.ErrorCode = -1;
            }
            return null;
        }
    }
}
