using System.ComponentModel.DataAnnotations;

namespace MessageForumTeam.Models
{
    public class User

    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9]*$")]
        [Required]
        public string? username { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public Guid Id { get; set; }

        public User(string username, string password, string email)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public void AddComment(Post post, string comment)
        {
            post.Comments.Concat(" " + comment);
        }

    }
}
