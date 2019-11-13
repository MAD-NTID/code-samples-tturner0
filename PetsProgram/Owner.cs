public class Owner
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public Owner(string firstName, string lastName, string phone)
    {        
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Phone = phone;
    }
    public Owner()
    {
        this.FirstName = "Unknown";
        this.LastName = "Unknown";
        this.Phone = "N/A";
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}