using Models;

namespace DAL.Repositories
{
    public class HattDekorationRepository : IRepository<HattDekoration>
    {
        DataHämtare _context;
        public HattDekorationRepository()
        {
            _context = new DataHämtare();
        }


        public void AddList(IEnumerable<HattDekoration> entityList)
        {
            _context.AddRange(entityList);
            Save();
        }
        public void Add(HattDekoration entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(HattDekoration entity)
        {
            _context.Remove(entity);
            Save();
        }

        public IEnumerable<HattDekoration> GetAll()
        {
            return _context.HattDekorationer.ToList();
        }

        public HattDekoration GetItem(int id)
        {
            return _context.HattDekorationer.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(HattDekoration entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
