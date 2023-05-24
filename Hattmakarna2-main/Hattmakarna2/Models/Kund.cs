namespace Models
{
    public class Kund
    {
        public Kund()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string? Ort { get; set; }

        public string? Postnummer { get; set; }

        public string? Land { get; set; } = "SE";

        public string TelefonNummer { get; set; }

        public string Email { get; set; }

        public IEnumerable<Beställning> Beställningar { get; set; }
    }
}
