using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [PrimaryKey(nameof(HattId), nameof(MaterialId))]

    public class HattMaterial
    {
        public HattMaterial()
        {

        }

        public int HattId { get; set; }
        public int MaterialId { get; set; }

        public double Mängd { get; set; }

        [ForeignKey(nameof(HattId))]
        public Hatt Hatt { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public Material Material { get; set; }
    }
}
