using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Beställning
    {
        public Beställning()
        {

        }

        public int Id { get; set; }

        public int KundID { get; set; }

        public int PersonalId { get; set; }
        [XmlIgnore]
        public string LeveransAdress { get; set; }
        [XmlIgnore]
        public string? Ort { get; set; }
        [XmlIgnore]
        public string? Postnummer { get; set; }
        [XmlIgnore]
        public string? Land { get; set; }

        public double TotalUtgift { get; set; }

        public double TotalPris { get; set; }
        [XmlIgnore]
        public string Beskrivning { get; set; }

        public DateTime SkapadDatum { get; set; }

        [XmlIgnore]
        public IEnumerable<Hatt> Hattar { get; set; }

        [ForeignKey(nameof(PersonalId))]
        public Personal Personal { get; set; }

        public bool IsBetald { get; set; } = false;
        [XmlIgnore]
        public bool IsBekräftad { get; set; } = false;
        [XmlIgnore]
        public string? Status { get; set; } = "Ny beställning";


    }
}