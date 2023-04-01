using Microsoft.EntityFrameworkCore;

namespace ToDoList.Web.Data;

public class TDLContext : DbContext
{
    public TDLContext(DbContextOptions options) : base(options)
    {
    }

}

