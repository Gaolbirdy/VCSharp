using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace BegVCSharp_21_Exercise4_GhostStories
{
    public class Story
    {
        [Key]
        public int StoryID { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Rating { get; set; }
    }

    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
    }
 
    public class StoryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Story> Stories { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StoryContext())
            {
                Author author1 = new Author
                {
                    Name = "Henry James",
                    Nationality = "American"
                };
                Story story1 = new Story
                {
                    Title = "The Turn of the Screw",
                    Author = author1,
                    Rating = "a bit dull"
                };
                db.Stories.Add(story1);

                
                db.SaveChanges();

                var query = from story in db.Stories
                            orderby story.Title
                            select story;

                WriteLine("Ghost Stories:");
                WriteLine();
                foreach (var story in query)
                {
                    WriteLine(story.Title);
                    WriteLine();
                }

                WriteLine("Press a key to exit...");
                ReadKey();
            }
        }
    }
}
