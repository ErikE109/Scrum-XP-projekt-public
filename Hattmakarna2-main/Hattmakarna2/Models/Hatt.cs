using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Hatt
    {
        public Hatt()
        {

        }

        public int Id { get; set; }

        public string Storlek { get; set; }

        public IEnumerable<HattMaterial> Material { get; set; }

        public IEnumerable<HattDekoration> Dekorationer { get; set; }

        public double Pris { get; set; }

        public double Materialkostnad { get; set; }

        public double TidsÅtgång { get; set; }

        public string Typ { get; set; }

        public int? BeställningsID { get; set; }

        [ForeignKey(nameof(BeställningsID))]
        public Beställning? Beställning { get; set; }

    }
}
