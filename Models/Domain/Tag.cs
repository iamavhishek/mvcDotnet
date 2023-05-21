namespace MVC_Project.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? ShortDescription { get; set; }

        public ICollection<BlogPost> BlogPost { get; set; }

    }
}