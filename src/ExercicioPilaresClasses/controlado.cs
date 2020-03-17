namespace ExercicioPilaresClasses
{
    public class controlado: remedio
    {
        public double precoGoverno {get; set;}
        public bool exigeReceitaBranca {get; set;}

        public override double DescontoPraticado() 
        {
            return precoGoverno - preco;
        }

        
    }
}