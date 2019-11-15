class VideoGame
{
    //private string title;

    public string Title { get; set; }

    public string Publisher { get; set; }
    public int Price { get; set; }
    
    public int ReleasedYear { get; set; }


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