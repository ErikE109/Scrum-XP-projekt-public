using DAL.Repositories;
using Models;

namespace BLL;

public class DekorationController
{
    DekorationRepository repository;
    HattDekorationRepository hattDekorationRepository;

    public DekorationController()
    {
        repository = new DekorationRepository();
        hattDekorationRepository = new HattDekorationRepository();
    }

    public IEnumerable<Dekoration> hämtaAllaDekorationer()
    {
        if (repository.GetAll() == null)
        {
        }

        return repository.GetAll();
    }

    public String[] FormateraGridDataDekoration(Dekoration dekoration)
    {
        string id = dekoration.Id.ToString();
        string typ = dekoration.Typ;
        string pris = dekoration.Pris.ToString();



        string[] GridDataMaterial = new string[] { id, typ, pris };

        return GridDataMaterial;
    }

    public void SparaDekorationerTillHatt(int hattid, List<int> antal, IEnumerable<Dekoration> dekorationer)
    {
        int i = 0;
        foreach (var item in dekorationer)
        {
            HattDekoration hattDekoration = new HattDekoration();
            hattDekoration.HattId = hattid;
            hattDekoration.DekorationId = item.Id;
            hattDekoration.Antal = antal[i];
            hattDekorationRepository.Add(hattDekoration);
            i++;
        }

    }



    public void UppdateraDekorationerTillHatt(int hattid, List<int> antal, IEnumerable<Dekoration> dekorationer)
    {
        int i = 0;
        foreach (var item in dekorationer)
        {
            HattDekoration hattDekoration = hattDekorationRepository.GetAll().Where(m => m.DekorationId.Equals(item.Id) && m.HattId == hattid).FirstOrDefault();

            if (hattDekoration == null)
            {
                hattDekoration = new HattDekoration();
                hattDekoration.HattId = hattid;
                hattDekoration.DekorationId = item.Id;
                hattDekoration.Antal = antal[i];
                hattDekorationRepository.Add(hattDekoration);
            }
            else
            {
                hattDekoration.DekorationId = item.Id;
                hattDekoration.Antal = antal[i];
                hattDekorationRepository.Update(hattDekoration);
            }

            i++;
        }

    }

    public double DekorationsPriser(List<int> antal, IEnumerable<Dekoration> dekorations)
    {
        double summa = 0;
        int i = 0;

        foreach (var item in dekorations)
        {
            summa += (item.Pris * antal[i] * 1.5);
            i++;
        }
        return summa;
    }

    public double DekorationsKostnader(List<int> antal, IEnumerable<Dekoration> dekorations)
    {
        double summa = 0;
        int i = 0;

        foreach (var item in dekorations)
        {
            summa += (item.Pris * antal[i]);
            i++;
        }
        return summa;
    }

    public IEnumerable<HattDekoration> HämtaAllaHattDekorationer()
    {
        return hattDekorationRepository.GetAll();
    }

    public void Delete(int id)
    {
        List<HattDekoration> hattdekorationer = HämtaAllaHattDekorationer().Where(d => d.HattId == id).ToList();

        foreach (var hatt in hattdekorationer)
        {
            hattDekorationRepository.Delete(hatt);
        }
    }
}