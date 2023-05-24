using DAL.Repositories;
using Models;

namespace BLL;

public class MaterialController
{
    MaterialRepository repository;
    HattMaterialRepository hattMaterialRepository;
    HattDekorationRepository hattDekorationRepository;

    public MaterialController()
    {
        repository = new MaterialRepository();
        hattMaterialRepository = new HattMaterialRepository();
        hattDekorationRepository = new HattDekorationRepository();
    }

    public IEnumerable<Material> hämtaMaterialer()
    {
        if (repository.GetAll() == null)
        {
        }

        return repository.GetAll();
    }

    public String[] FormateraGridDataMaterial(Material material)
    {
        string id = material.Id.ToString();
        string typ = material.Typ;
        string meterpris = material.MeterPris.ToString();



        string[] GridDataMaterial = new string[] { id, typ, meterpris };

        return GridDataMaterial;
    }
    public void SparaMaterialTillHatt(int hattid, List<double> mängder, IEnumerable<Material> material)
    {
        int i = 0;
        foreach (var item in material)
        {
            HattMaterial hattMaterial = new HattMaterial();
            hattMaterial.HattId = hattid;
            hattMaterial.MaterialId = item.Id;
            hattMaterial.Mängd = mängder[i];
            hattMaterialRepository.Add(hattMaterial);
            i++;
        }
    }

    public void UppdateraMaterialTillHatt(int hattid, List<double> mängder, IEnumerable<Material> material)
    {
        int i = 0;
        foreach (var item in material)
        {

            HattMaterial hattMaterial = hattMaterialRepository.GetAll().Where(m => m.MaterialId.Equals(item.Id) && m.HattId == hattid).FirstOrDefault();

            if (hattMaterial == null)
            {
                hattMaterial = new HattMaterial();
                hattMaterial.HattId = hattid;
                hattMaterial.MaterialId = item.Id;
                hattMaterial.Mängd = mängder[i];
                hattMaterialRepository.Add(hattMaterial);
            }
            else
            {
                hattMaterial.MaterialId = item.Id;
                hattMaterial.Mängd = mängder[i];
                hattMaterialRepository.Update(hattMaterial);
            }

            i++;
        }
    }


    public double MaterialPriser(List<double> mängder, IEnumerable<Material> material)
    {
        double summa = 0;
        int i = 0;

        foreach (var item in material)
        {
            summa += (item.MeterPris * mängder[i] * 1.5);
            i++;

        }
        return summa;
    }

    public double MaterialKostnader(List<double> mängder, IEnumerable<Material> material)
    {
        double summa = 0;
        int i = 0;

        foreach (var item in material)
        {
            summa += (item.MeterPris * mängder[i]);
            i++;
        }
        return summa;
    }

    public IEnumerable<HattMaterial> HämtaHattMaterial()
    {
        return hattMaterialRepository.GetAll();
    }

    public void Delete(int id)
    {
        List<HattMaterial> hattMaterial = HämtaHattMaterial().Where(m => m.HattId == id).ToList();
        foreach (var material in hattMaterial)
        {
            hattMaterialRepository.Delete(material);
        }
    }
}