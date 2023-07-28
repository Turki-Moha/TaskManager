using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TaskDBContext: DbContext
    {

        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }


    }
}
