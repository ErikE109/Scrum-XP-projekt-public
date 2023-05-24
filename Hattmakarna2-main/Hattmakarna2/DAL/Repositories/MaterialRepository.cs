using Models;

namespace DAL.Repositories
{
    public class MaterialRepository : IRepository<Material>
    {
        DataHämtare _context;
        public MaterialRepository()
        {
            _context = new DataHämtare();
        }
        public void Add(Material entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(Material entity)
        {
            _context.Remove(entity);
            Save();

        }

        public IEnumerable<Material> GetAll()
        {
            return _context.Material.ToList();
        }

        public Material GetItem(int id)
        {
            return _context.Material.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Material entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
