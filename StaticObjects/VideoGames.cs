class VideoGame
{
    // public static int total;
    //private string title;
    public string Title { get; set; }

    public string Publisher { get; set; }

    //private int price;
    // public int Price { get{ return price;} set{ total += value; } }
    public int Price { get; set; }
    
    public int ReleasedYear { get; set; }


    private string ratings;
    public string Ratings
    {
        get { return ratings; }
        set { ratings = value; }
    }
    


    public VideoGame()
    {
        
        Publisher = "EA Sports";
        Price = 60;
        ReleasedYear = 2008;
    }

    public VideoGame(string title, string publisher, int price, int releasedYear)
    {
        Title = title;
        Publisher = publisher;
        Price = price;
        ReleasedYear = releasedYear;
    }

    public override string ToString()
    {
        return $"Released Year: {ReleasedYear}\nTitle: {Title}\nPublisher: {Publisher}\nPrice: {Price}";
    }
}