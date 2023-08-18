namespace ASP_Blog.Models.Domain
{

    //Initializing DB attributes for blog posts
    //all attr. not nullable
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string Heading { get; set; }

        public string PageTitle { get; set; }

        public string Content { get; set; }

        public string Desc { get; set; }

        public string FeaturedImgURL { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Author { get; set; }

        public bool Visible { get; set; }

        //define relation BlogPosts and Tags (M:N)
        public ICollection<Tag> Tags { get; set; }
    }
}
