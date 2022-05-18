namespace Carwarsh
{
    public class Voiture
    {
        public string Plaque { get; private set; }

        public Voiture(string Plaque)
        {
            this.Plaque = Plaque;
        }
    }
}