using ASP_Blog.Data;
using ASP_Blog.Models.Domain;
using ASP_Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Blog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogDbContext blogDbContext;
        public AdminTagsController(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        [HttpGet]
        public IActionResult Add()                          //returns view from Add.cshtml
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)             //capture model here
        {

            //creating new tag table entry with form entry
            var tag = new Tag
            {
                Name = addTagRequest.name,
                DisplayName = addTagRequest.displayName
            };

            blogDbContext.Tags.Add(tag);                    //add entry to tag
            blogDbContext.SaveChanges();                    //save changes
            return View("Add");
        }
    }
}
