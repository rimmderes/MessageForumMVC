using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MessageForumTeam.Models;

namespace MessageForumTeam.Data
{
    public class MessageForumTeamContext : DbContext
    {
        public MessageForumTeamContext (DbContextOptions<MessageForumTeamContext> options)
            : base(options)
        {
        }

        public DbSet<MessageForumTeam.Models.Post> Post { get; set; } = default!;
    }
}
