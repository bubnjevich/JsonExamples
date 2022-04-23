
namespace klase2
{
    public class Automobile
    {
        private string Model;
        private string Mark;
        private string Color;
        private int Year;
        private Engine Engine;
        private Fuel Fuel;

        public string model => Model;
        public string mark => Mark;
        public string color => Color;
        public int year => Year;
        public Engine engine => Engine;
        public Fuel fuel => Fuel;

        public Automobile(string model, string mark, string color, int year, Engine engine, Fuel fuel)
        {
            Color = color;
            Model = model;
            Mark = mark;
            Year = year;
            Engine = engine;
            Fuel = fuel;
        }
        
        public override string ToString()
        {
            return 
                   $"Model: {Model}\n" +
                   $"Mark: {Mark},\n" +
                   $"Color: {Color},\n" +
                   $"Year: {Year},\n" +
                   $"Engine: {Engine},\n" +
                   $"Fuel: {Fuel}\n";
        }
    }
    }
