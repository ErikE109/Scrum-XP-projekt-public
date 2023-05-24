using Models;

namespace DAL.Repositories
{
    public class HattRepository : IRepository<Hatt>
    {
        DataHämtare _context;
        public HattRepository()
        {
            _context = new DataHämtare();
        }
        public void Add(Hatt entity)
        {
            _context.Add(entity);
            Save();
        }
        public void Update(Hatt entity)
        {
            _context.Update(entity);
            Save();
        }

        public void Delete(Hatt entity)
        {
            _context.Remove(entity);
            Save();
        }

        public IEnumerable<Hatt> GetAll()
        {
            return _context.Hattar.ToList();
        }

        public Hatt GetItem(int id)
        {
            return _context.Hattar.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
