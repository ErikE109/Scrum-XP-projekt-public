using Models;

namespace DAL.Repositories
{
    public class PersonalRepository : IRepository<Personal>
    {
        private DataHämtare _context;
        public PersonalRepository()
        {
            _context = new DataHämtare();
        }

        public void Add(Personal entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(Personal entity)
        {
            _context.Remove(entity);
            Save();
        }


        public IEnumerable<Personal> GetAll()
        {
            return _context.Personal.ToList();
        }

        public Personal GetItem(int id)
        {
            return _context.Personal.Find(id);

        }

        public Personal GetItemByUserName(string username)
        {
            return _context.Personal.FirstOrDefault(a => a.Name == username);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Personal entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
