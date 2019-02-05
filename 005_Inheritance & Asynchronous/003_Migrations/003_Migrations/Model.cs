using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace _003_Migrations
{
    class BlogContext : DbContext
    {
        public BlogContext(): base("DbContext")
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        //Нужно добавить строки расположение ниже. Возникнет исключение.!
        public string Url { get; set; }
        public int Rating { get; set; }
        //public virtual List<Post> Posts { get; set; }
    }

    //public class Post
    //{
    //    public int PostId { get; set; }

    //    [MaxLength(200)]
    //    public string Title { get; set; }
    //    public string Content { get; set; }
    //    public int BlogId { get; set; }
    //    public Blog Blog { get; set; }
    //}
}
