using MessageForumTeam.Controllers;
using MessageForumTeam.Data;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace MessageForumTeam.Models
{
    public static class SeedData
    {
        // The Seed method takes the database context object as an input parameter, and the code in the method uses that object to add new entities to the database.
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new MessageForumTeamContext(serviceProvider.GetRequiredService<DbContextOptions<MessageForumTeamContext>>()))
            {
                // Look for any posts.
                if(context.Post.Any())
                {
                    return; // DB has already been seeded 
                }
                context.Post.AddRange(
                    new Post
                    {
                        Author = "John Smith",
                        Title = "How to get rich fast",
                        Description = "Top 10 ways on how to make a lot of money fastt",
                        DatePosted = DateTime.Now,
                        Comments = "This was great",
                        //Comments = new List<string> { "Great post!", "Thanks for sharing.", "I found this really helpful." },
                        //Likes = new List<string> { "beastboy64", "aceventura123", "techman53" },
                        Likes = "techman",
                        Tags = "Finance"

                    },
                    new Post
                    {
                        Author = "John Smith",
                        Title = "How to get rich fast",
                        Description = "Top 10 ways on how to make a lot of money fastt",
                        DatePosted = DateTime.Now,
                        Comments = "This was great",
                        //Comments = new List<string> { "Great post!", "Thanks for sharing.", "I found this really helpful." },
                        //Likes = new List<string> { "beastboy64", "aceventura123", "techman53" },
                        Likes = "techman",
                        Tags = "Finance"

                    },
                    new Post
                    {
                        Author = "John Smith",
                        Title = "How to get rich fast",
                        Description = "Top 10 ways on how to make a lot of money fastt",
                        DatePosted = DateTime.Now,
                        Comments = "This was great",
                        //Comments = new List<string> { "Great post!", "Thanks for sharing.", "I found this really helpful." },
                        //Likes = new List<string> { "beastboy64", "aceventura123", "techman53" },
                        Likes = "techman",
                        Tags = "Finance"

                    }




                    ) ;
                context.SaveChanges();
            }

        }

    }
}
