using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace MessageForumTeam.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Display(Name = "User")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9]*$")]
        public string? Author { get; set; }
        [Display(Name = "Posted on")]
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }

        [StringLength(200, MinimumLength = 1)]
        public string? Comments { get; set; }
        public string? Likes { get; set; }
        public string? Tags { get; set; }


        //method to cap on screen title length

        public string MaxDescriptionLength()
        {
            int maxLength = 50;
            string newDesc = this.Description.Length > maxLength ? this.Description.Substring(0, maxLength) + "..." : this.Description;
            return newDesc;

        }

        // method to show the 
        public int LikesToInt()
        {
            if (this.Likes == null)
            {
                return 0;
            }
            else
            {
                string[] LikesArr = this.Likes.Split(" ");
                return LikesArr.Length;
            }
        }

        public string[] CommentsToArray()
        {
            string[] commentsArr = Array.Empty<string>();
            if (this.Comments == null)
            {
                return commentsArr;
            }
            else
            {
                commentsArr = (this.Comments.Split(" "));
                return commentsArr;
            }
        }

        public int CommentsToInt()
        {
            return CommentsToArray().Length;
        }



        //Methods to add and remove 'likes'
        public bool CheckLike(User user)
        {

            if (this.Likes != null && this.Likes.Contains(user.username))
            {
                return true;
            }
            return false;
        }

        public void AddLike(User user)
        {
            if (this.Likes != null && !CheckLike(user))
            {
                this.Likes.Concat(user.username + " ");

            }
        }

        public void RemoveLike(User user)
        {

            if (this.Likes != null && CheckLike(user))
            {
                int start = this.Likes.IndexOf(user.username), end = this.Likes.IndexOf(user.username) + user.username.Length;
                this.Likes.Remove(start, end);
            }

        }
    }

}
