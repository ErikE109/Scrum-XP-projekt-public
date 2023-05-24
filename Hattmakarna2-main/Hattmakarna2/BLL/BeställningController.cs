using DAL.Repositories;
using Models;

namespace BLL
{

    public class BeställningController
    {
        private IRepository<Beställning> repository;
        private HattController hattController;

        private Beställning beställning;
        private KundController kundController;
        private IEnumerable<Beställning> beställingarMellanDatum;


        public BeställningController()
        {
            repository = new BeställningRepository();

            hattController = new HattController();

            kundController = new KundController();

        }

        public Beställning GetCurrentBeställning()
        {
            return beställning;
        }


        public bool SkapaBeställning(int kundID, string leveransadress, int skapareID, string beskrivning, string storlek, string postnummer, string ort, string land, List<Hatt> hattlista)
        {
            beställning = new Beställning();

            beställning.KundID = kundID;
            beställning.LeveransAdress = leveransadress;
            beställning.Postnummer = postnummer;
            beställning.Ort = ort;
            beställning.Land = land;

            beställning.PersonalId = skapareID;
            beställning.Beskrivning = beskrivning;
            beställning.TotalPris = 0;
            beställning.TotalUtgift = 0;
            beställning.SkapadDatum = DateTime.Now;


            foreach (var item in hattlista)
            {
                beställning.TotalPris += item.Pris;
            }

            foreach (var item in hattlista)
            {
                beställning.TotalUtgift += item.Materialkostnad;
            }


            repository.Add(beställning);

            hattController.SparaHattarIBeställning(hattlista, beställning.Id);


            return true;

        }


        public bool UppdateraBeställning(int kundID, string leveransadress, int skapareID, string beskrivning, string postnummer, string ort, string land, List<Hatt> hattlista, Beställning beställning, String orderstatus)
        {



            beställning.KundID = kundID;
            beställning.LeveransAdress = leveransadress;
            beställning.Postnummer = postnummer;
            beställning.Ort = ort;
            beställning.Land = land;

            beställning.PersonalId = skapareID;
            beställning.Beskrivning = beskrivning;
            beställning.TotalPris = 0;

            beställning.Status = orderstatus;
            beställning.TotalUtgift = 0;

            if (orderstatus.Equals("Bekräftad"))
            {
                beställning.IsBekräftad = true;
            }
            if (orderstatus.Equals("Betald"))
            {
                beställning.IsBetald = true;
            }
            double totalPris = 0;
            double totalUtgift = 0;

            foreach (var item in hattlista)
            {
                totalPris += item.Pris;
            }

            foreach (var item in hattlista)
            {
                totalUtgift += item.Materialkostnad;
            }


            beställning.TotalUtgift = totalUtgift;
            beställning.TotalPris = totalPris;

            repository.Update(beställning);

            hattController.SparaHattarIBeställning(hattlista);

            return true;

        }

        public String[] FormateraGridDataBeställning(Beställning beställning)
        {
            string ordernummer = beställning.Id.ToString();
            string kund = kundController.hämtaEnKund(beställning.KundID).Name;

            string datum = beställning.SkapadDatum.ToString();
            string adress = beställning.LeveransAdress;
            string status = beställning.Status;


            string[] GridDataBeställning = new string[] { ordernummer, kund, datum, adress, status };

            return GridDataBeställning;
        }


        public Beställning GranskaBeställning(int id)
        {
            return repository.GetItem(id);
        }

        public IEnumerable<Beställning> SökBeställning(string sökord)
        {
            return repository.GetAll().Where(b => b.LeveransAdress.Contains(sökord) || kundController.hämtaEnKund(b.KundID).Name.Contains(sökord));
        }

        public IEnumerable<Beställning> BeställningEfterOrderstatus(string status)
        {
            return repository.GetAll().Where(b => b.Status.Equals(status));
        }

        public IEnumerable<Beställning> GetAll()
        {
            BeställningRepository beställningRepository = new BeställningRepository();
            return beställningRepository.GetAll();
        }


        public void HittaBeställningarFrånDatum(DateTime frånDatum, DateTime tillDatum)
        {

            beställingarMellanDatum = repository.GetAll().Where(b => b.SkapadDatum >= frånDatum && b.SkapadDatum <= tillDatum).ToList();

        }


        public void SparaStatistik()
        {


            StatistikController<Beställning>.SkrivUtStatistik(beställingarMellanDatum.ToList(), "Försäljningstatistik");
        }


        public void Delete(int id)
        {
            hattController.Delete(id);

            Beställning beställning = repository.GetItem(id);
            repository.Delete(beställning);
        }

    }
}
