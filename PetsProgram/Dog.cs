class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string Owner { get; set; }
    Dog(string name, string breed, int age, string ownerName)
    {
        this.Name = name;
        this.Breed = breed;
        this.Age = age;
        this.Owner = ownerName;
    }
    Dog()
    {
        this.Name = "Unknown";
        this.Breed = "Unknown";
        this.Age = 0;
        this.Owner = "N/A";
    }
}