using Models;

namespace DAL.Repositories
{
    public class DekorationRepository : IRepository<Dekoration>
    {
        DataHämtare _context;
        public DekorationRepository()
        {
            _context = new DataHämtare();
        }

        public void Add(Dekoration entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(Dekoration entity)
        {
            _context.Remove(entity);
            Save();
        }


        public IEnumerable<Dekoration> GetAll()
        {
            return _context.Dekorationer.ToList();

        }

        public Dekoration GetItem(int id)
        {
            return _context.Dekorationer.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Dekoration entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
