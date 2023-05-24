using DAL.Repositories;
using Models;

namespace BLL;

public class KundController
{
    KundRepository repository;
    BeställningController beställningController;

    public KundController()
    {
        repository = new KundRepository();

    }

    public IEnumerable<Kund> hämtaKunder()
    {
        if (repository.GetAll() == null)
        {
        }

        return repository.GetAll();
    }

    public Kund hämtaEnKund(int id)
    {
        return repository.GetItem(id);
    }

    public bool SkapaKund(string namn, string address, string postnummer, string ort, string land, string telefonnummer, string email)
    {
        if (String.IsNullOrEmpty(namn) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(telefonnummer) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(postnummer) || String.IsNullOrEmpty(ort) || String.IsNullOrEmpty(land))
        {
            return false;
        }

        Kund kund = new Kund();
        kund.Name = namn;
        kund.Adress = address;
        kund.Postnummer = postnummer;
        kund.Ort = ort;
        kund.Land = land;
        kund.TelefonNummer = telefonnummer;
        kund.Email = email;
        repository.Add(kund);
        return true;


    }

    public bool UppdateraKund(Kund kund, string namn, string adress, string postnummer, string ort, string land, string telefonnummer, string email)
    {
        if (String.IsNullOrEmpty(namn) || String.IsNullOrEmpty(adress) || String.IsNullOrEmpty(telefonnummer) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(postnummer) || String.IsNullOrEmpty(ort) || String.IsNullOrEmpty(land))
        {
            return false;
        }
        kund.Name = namn;
        kund.Adress = adress;
        kund.Postnummer = postnummer;
        kund.Ort = ort;
        kund.Land = land;
        kund.TelefonNummer = telefonnummer;
        kund.Email = email;

        repository.Update(kund);

        return true;
    }

    public int HämtaAntalBeställningarKund(Kund kund)
    {
        beställningController = new BeställningController();
        return beställningController.GetAll().Where(b => b.KundID.Equals(kund.Id)).Count();

    }



    public String[] FormateraGridDataKund(Kund kund)
    {
        string kundid = kund.Id.ToString();
        string namn = kund.Name;
        string adress = kund.Adress + ", " + kund.Postnummer + " " + kund.Ort;
        string telefon = kund.TelefonNummer;
        string epost = kund.Email;


        string[] GridDataKund = new string[] { kundid, namn, adress, telefon, epost };

        return GridDataKund;
    }

    public IEnumerable<Kund> SökEfterKund(string sokstrang)
    {
        return repository.GetAll().Where(b => b.Name.Contains(sokstrang) || b.Adress.Contains(sokstrang) || b.TelefonNummer.Contains(sokstrang) || b.Email.Contains(sokstrang));
    }



}