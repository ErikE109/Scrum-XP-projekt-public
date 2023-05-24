using Models;

namespace DAL.Repositories
{
    public class BeställningRepository : IRepository<Beställning>
    {
        private readonly DataHämtare _context;
        public BeställningRepository()
        {
            _context = new DataHämtare();
        }
        public void Add(Beställning entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(Beställning entity)
        {
            _context.Remove(entity);
            Save();
        }

        public IEnumerable<Beställning> GetAll()
        {
            return _context.Beställningar.ToList();
        }

        public Beställning GetItem(int id)
        {
            return _context.Beställningar.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Beställning entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
