namespace Models
{

    public class Material
    {
        public Material()
        {

        }

        public int Id { get; set; }
        public string Typ { get; set; }
        public double MeterPris { get; set; }

        public HattMaterial HattMaterial { get; set; }
    }
}
