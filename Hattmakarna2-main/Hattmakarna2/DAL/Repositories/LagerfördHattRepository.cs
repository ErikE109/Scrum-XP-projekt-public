using Models;

namespace DAL.Repositories
{
    public class LagerfördHattRepository : IRepository<LagerfördHatt>
    {
        DataHämtare _context;
        public LagerfördHattRepository()
        {
            _context = new DataHämtare();
        }
        public void Add(LagerfördHatt entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(LagerfördHatt entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<LagerfördHatt> GetAll()
        {
            return _context.LagerfördHatt.ToList();
        }

        public LagerfördHatt GetItem(int id)
        {
            return _context.LagerfördHatt.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(LagerfördHatt entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
