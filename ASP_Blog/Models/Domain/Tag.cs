namespace ASP_Blog.Models.Domain
{
    //initializing DB columns for tags
    public class Tag
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        //define relation Tags and BlogPost (M:N)
        public ICollection<BlogPost> BlogPost { get; set; }
    }
}
