namespace AuotMapper.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public bool? IsFree { get; set; }
    }
}