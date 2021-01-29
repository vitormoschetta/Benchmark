namespace src.Models
{
    public struct CarroStruct
    {
        public CarroStruct(string name, int value)
        {
            Name = name;
            this.value = value;
        }

        public string Name { get; set; }
        public int value { get; set; }
    }
}