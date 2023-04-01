using Microsoft.EntityFrameworkCore;
using ToDoList.Web.Models;

namespace ToDoList.Web.Data;

public class TDLContext : DbContext
{
    public TDLContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<MyTask> MyTasks { get; set; }

}

