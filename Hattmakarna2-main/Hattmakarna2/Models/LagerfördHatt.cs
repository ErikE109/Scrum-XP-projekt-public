using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LagerfördHatt
    {

        public LagerfördHatt()
        {

        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public double Pris { get; set; }
        public double Materialkostnad { get; set; }

    }
}
