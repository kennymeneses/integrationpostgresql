using DataAccess;

namespace BussinessLogic
{
    public class MatchesManager  : IMatchesManager 
    {
        private IRepository<TEntity> _repository;
        public MatchesManager(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task GetAllMatches()
        {
            
        }
    }
}
