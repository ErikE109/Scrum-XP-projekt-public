using Models;

namespace DAL.Repositories
{
    public class KundRepository : IRepository<Kund>
    {
        DataHämtare _context;
        public KundRepository()
        {
            _context = new DataHämtare();
        }
        public void Add(Kund entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(Kund entity)
        {
            _context.Remove(entity);
            Save();
        }

        public IEnumerable<Kund> GetAll()
        {
            return _context.Kunder.ToList();
        }

        public Kund GetItem(int id)
        {
            return _context.Kunder.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Kund entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
