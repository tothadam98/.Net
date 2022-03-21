using AlgorithmicsAPI.Data;
using AlgorithmicsAPI.Data.Models;
using AlgorithmicsAPI.Data.Response;

namespace AlgorithmicsAPI.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {
        private readonly AppDbContext _context;
        public AlgorithmResponse AddNewAlgorithm(Algorithm algorithm)
        {
            _context.Algorithms.Add(algorithm);
            var entries = _context.SaveChanges();
            var response = new AlgorithmResponse()
            {
                Algorithm = _context.Algorithms.Find(algorithm)
            };
            if(entries != null)
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
