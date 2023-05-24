using Models;

namespace DAL.Repositories
{
    public class HattMaterialRepository : IRepository<HattMaterial>
    {
        DataHämtare _context;
        public HattMaterialRepository()
        {
            _context = new DataHämtare();
        }


        public void AddList(IEnumerable<HattMaterial> entityList)
        {
            _context.AddRange(entityList);
            Save();
        }
        public void Add(HattMaterial entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(HattMaterial entity)
        {
            _context.Remove(entity);
            Save();
        }

        public IEnumerable<HattMaterial> GetAll()
        {
            return _context.HattMaterial.ToList();
        }

        public HattMaterial GetItem(int id)
        {
            return _context.HattMaterial.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(HattMaterial entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
