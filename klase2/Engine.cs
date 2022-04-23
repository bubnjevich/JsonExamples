namespace klase2
{
    public class Engine
    {
        private string Name;
        private double CubicCapacity;
        private double Power;

        public Engine(string name, double cubicCapacity, double power)
        {
 
            Name = name;
            CubicCapacity = cubicCapacity;
            Power = power;
        }
        
        public override string ToString()
        {
            return $"Name  {Name}" +
                   $"Power {Power}" +
                   $"CubicCapacity {CubicCapacity}";
        }
    }
}