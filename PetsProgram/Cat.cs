class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string Owner { get; set; }
    public string Color { get; set; }
    public bool Declawed { get; set; }
    public Cat(string name, string breed, int age, string color, string ownerName, bool declawed)
    {
        this.Name = name;
        this.Breed = breed;
        this.Age = age;
        this.Color = color;
        this.Owner = ownerName;
        this.Declawed = declawed;
    }
    public Cat()
    {
        this.Name = "Unknown";
        this.Breed = "Unknown";
        this.Age = 0;
        this.Color = "Unknown";
        this.Owner = "N/A";
        this.Declawed = false;
    }
}