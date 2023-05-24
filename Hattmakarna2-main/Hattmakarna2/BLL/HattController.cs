using DAL.Repositories;
using Models;

namespace BLL;

public class HattController
{
    HattRepository repository;
    DekorationController dekorationController;
    MaterialController materialController;
    LagerfördHattRepository lagerfördHattRepository;

    public HattController()
    {
        repository = new HattRepository();
        dekorationController = new DekorationController();
        materialController = new MaterialController();
        lagerfördHattRepository = new LagerfördHattRepository();
    }

    public Hatt SkapaSpecialhatt(Hatt hatt, double tid, string storlek, List<int> antalDekorationer, List<double> mängdMaterial, IEnumerable<Dekoration> dekorationer, IEnumerable<Material> material)
    {
        hatt.TidsÅtgång = tid;
        hatt.Storlek = storlek;
        hatt.Pris = (tid * 800) + dekorationController.DekorationsPriser(antalDekorationer, dekorationer) + materialController.MaterialPriser(mängdMaterial, material);
        hatt.Materialkostnad = dekorationController.DekorationsKostnader(antalDekorationer, dekorationer) + materialController.MaterialKostnader(mängdMaterial, material);
        hatt.Typ = "Specialhatt";
        repository.Add(hatt);
        dekorationController.SparaDekorationerTillHatt(hatt.Id, antalDekorationer, dekorationer);
        materialController.SparaMaterialTillHatt(hatt.Id, mängdMaterial, material);
        return hatt;
    }


    public Hatt UppdateraSpecialhatt(Hatt hatt, double tid, string storlek, List<int> antalDekorationer, List<double> mängdMaterial, IEnumerable<Dekoration> dekorationer, IEnumerable<Material> material)
    {
        hatt.TidsÅtgång = tid;
        hatt.Storlek = storlek;
        hatt.Pris = (tid * 800) + dekorationController.DekorationsPriser(antalDekorationer, dekorationer) + materialController.MaterialPriser(mängdMaterial, material);
        hatt.Materialkostnad = dekorationController.DekorationsKostnader(antalDekorationer, dekorationer) + materialController.MaterialKostnader(mängdMaterial, material);
        repository.Update(hatt);
        dekorationController.UppdateraDekorationerTillHatt(hatt.Id, antalDekorationer, dekorationer);
        materialController.UppdateraMaterialTillHatt(hatt.Id, mängdMaterial, material);
        return hatt;
    }


    public void SkapaLagerFördHatt(string namn, double pris, double tillverkningskostnad)
    {
        LagerfördHatt hatt = new LagerfördHatt();
        hatt.Namn = namn;
        hatt.Pris = pris;
        hatt.Materialkostnad = tillverkningskostnad;
        lagerfördHattRepository.Add(hatt);
    }

    public void UppdateraLagerFördHatt(LagerfördHatt lagerfördHatt, string namn, double pris, double materialkostnad)
    {
        lagerfördHatt.Namn = namn;
        lagerfördHatt.Pris = pris;
        lagerfördHatt.Materialkostnad = materialkostnad;
        lagerfördHattRepository.Update(lagerfördHatt);
    }

    public List<LagerfördHatt> GetAllaLagerfördaHattar()
    {
        return lagerfördHattRepository.GetAll().ToList();
    }


    public LagerfördHatt GetEnLagerfördHatt(int id)
    {
        return lagerfördHattRepository.GetItem(id);
    }


    public List<Hatt> GetAllaHattar()
    {
        return repository.GetAll().ToList();
    }

    public void SparaHattIBeställning(Hatt hatt, int beställningsID)
    {
        hatt.BeställningsID = beställningsID;
        repository.Update(hatt);

    }

    public void SparaHattarIBeställning(List<Hatt> hattar, int beställningsID)
    {
        foreach (var hatt in hattar)
        {
            hatt.BeställningsID = beställningsID;
            repository.Update(hatt);
        }
    }

    public void SparaHattarIBeställning(List<Hatt> hattar)
    {
        foreach (var hatt in hattar)
        {
            repository.Update(hatt);
        }
    }


    public Hatt SkapaVanligHatt(Hatt hatt, LagerfördHatt lagerfördHatt, string storlek)
    {
        hatt.TidsÅtgång = 0;
        hatt.Storlek = storlek;
        hatt.Pris = lagerfördHatt.Pris;
        hatt.Typ = lagerfördHatt.Namn;
        hatt.Materialkostnad = lagerfördHatt.Materialkostnad;
        repository.Add(hatt);
        return hatt;
    }

    public Hatt UppdateraStandardHatt(Hatt hatt, string storlek)
    {
        hatt.Storlek = storlek;
        return hatt;
    }


    public Hatt GetItem(int id)
    {
        return repository.GetItem(id);
    }



    public List<HattMaterial> HämtaMaterialEnHatt(Hatt hatt)
    {
        List<HattMaterial> materials = new List<HattMaterial>();
        foreach (HattMaterial material in hatt.Material)
        {
            materials.Add(material);
        }
        return materials;
    }


    public void Delete(int id)
    {
        Hatt hatt = repository.GetItem(id);
        repository.Delete(hatt);
    }
    public String[] FormateraGridDataHatt(LagerfördHatt lagerfördHatt)
    {
        string hattid = lagerfördHatt.Id.ToString();
        string namn = lagerfördHatt.Namn;
        string pris = lagerfördHatt.Pris.ToString();


        string[] GridDataKund = new string[] { hattid, namn, pris };

        return GridDataKund;
    }
}