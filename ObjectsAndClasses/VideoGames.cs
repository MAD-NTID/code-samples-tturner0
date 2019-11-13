class VideoGame
{
    private string title;
    private string publisher;
    private int price;
    private int releasedYear;

    public VideoGame()
    {
        SetTitle("NBA 2K");
        SetPublisher("EA Sports");
        SetPrice(60);
        SetReleasedYear(2008);
    }

    public VideoGame(string title, string publisher, int price, int releasedYear)
    {
        SetTitle(title);
        SetPublisher(publisher);
        SetPrice(price);
        SetReleasedYear(releasedYear);
    }

    public void SetTitle(string _title)
    {
        if(_title == "NBA 2K" || _title == "Boardlands 3")
            title = _title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetPublisher(string publisher)
    {
        this.publisher = publisher;
    }

    public string GetPublisher()
    {
        return this.publisher;
    }

    public void SetPrice(int price)
    {
        this.price = price;
    }

    public int GetPrice()
    {
        return this.price;
    }

    public void SetReleasedYear(int releasedYear)
    {
        this.releasedYear = releasedYear;
    }

    public int GetReleasedYear()
    {
        return this.releasedYear;
    }
}