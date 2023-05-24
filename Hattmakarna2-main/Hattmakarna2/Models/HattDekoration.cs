using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    [PrimaryKey(nameof(HattId), nameof(DekorationId))]
    public class HattDekoration
    {

        public HattDekoration()
        {

        }
        public int HattId { get; set; }
        public int DekorationId { get; set; }

        public int Antal { get; set; }

        [ForeignKey(nameof(HattId))]
        public Hatt Hatt { get; set; }

        [ForeignKey(nameof(DekorationId))]
        public Dekoration Dekoration { get; set; }
    }
}
