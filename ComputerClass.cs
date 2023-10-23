namespace Lesson7
{
    internal class ComputerClass
    {
        double Price { get; set; }
        string Model { get; set; }

        RAM ram { get; set; }
        HDD hdd { get; set; }

        internal ComputerClass(double price, string model) 
        {
            Price = price;
            Model = model;
            ram = new RAM();
            hdd = new HDD();
        }

        internal ComputerClass(double price, string model, RAM ram, HDD hdd) : this(price, model)
        {
            this.ram=ram;
            this.hdd=hdd;
        }

        internal void PrintInfo()
        {
            Console.WriteLine($"Price of this model {Model} is {Price}\nRAM: {ram}\nHDD:{hdd}");
        }
     }

    internal class RAM
    {
        string Name { get; set; }
        int Volume { get; set; }
        internal RAM() { }

        internal RAM(string name, int volume) 
        {
            Name = name;
            Volume = volume;
        }
    }

    internal class HDD
    {
        string Name { get; set; }
        int Volume { get; set; }
        string Type { get; set; }
        internal HDD() { }

        internal HDD(string name, int volume, string type)
        {
            Name=name;
            Volume=volume;
            Type=type;
        }
    }
}
