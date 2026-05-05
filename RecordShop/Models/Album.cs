namespace RecordShop.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string[] Genre { get; set; }
        public string ReleaseDate { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Album (int id, string title, string artist, string[] genre, string releaseDate, int rating, decimal price, string description)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Genre = genre;
            ReleaseDate = releaseDate;
            Rating = rating;
            Price = price;
            Description = description;
        }
    }

}
