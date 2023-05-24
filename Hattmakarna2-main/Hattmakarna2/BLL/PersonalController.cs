using DAL.Repositories;
using Models;

namespace BLL
{
    public class PersonalController
    {
        IRepository<Personal> repository;
        Personal currentUser;

        public PersonalController()
        {
            repository = new PersonalRepository();
        }

        public Personal GetCurrentUser()
        {
            return currentUser;
        }

        public IEnumerable<Personal> GetAll()
        {
            return repository.GetAll();
        }

        public bool Login(string användarnamn, string pw)
        {
            currentUser = repository.GetAll().FirstOrDefault(a => a.Name == användarnamn);

            if (String.IsNullOrEmpty(användarnamn) || String.IsNullOrEmpty(pw) || currentUser == null)
            {
                return false;
            }
            if (currentUser.Lösenord == pw)
            {
                return true;
            }
            return false;
        }

        public bool SkapaPersonal(string namn, string lösen)
        {
            if (!String.IsNullOrEmpty(namn) || !String.IsNullOrEmpty(lösen))
            {
                Personal personal = new Personal();
                personal.Name = namn;
                personal.Lösenord = lösen;
                repository.Add(personal);
                return true;
            }

            return false;
        }

        public bool bytLösenord(Personal personal, string nyttLosenord)
        {
            personal.Lösenord = nyttLosenord;
            repository.Update(personal);
            return true;
        }

    }
}