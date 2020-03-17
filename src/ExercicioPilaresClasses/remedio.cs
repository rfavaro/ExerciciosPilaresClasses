namespace ExercicioPilaresClasses
{
    public abstract class remedio
    {
        public string nome {get; set;}
        public double preco {get; set;}

        public abstract double DescontoPraticado();
    }
}