namespace Models
{

    public class Dekoration
    {
        public Dekoration()
        {

        }

        public int Id { get; set; }
        public string Typ { get; set; }
        public double Pris { get; set; }

        public HattDekoration HattDekoration { get; set; }



    }
}
