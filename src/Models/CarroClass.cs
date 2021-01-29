namespace src.Models
{
    public class CarroClass
    {
        public CarroClass(string name, int value)
        {
            Name = name;
            this.value = value;
        }

        public string Name { get; set; }
        public int value { get; set; }
    }
}