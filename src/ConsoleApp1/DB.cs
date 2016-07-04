using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [DbConfigurationType(typeof(CodeConfig))]
    public class DB : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DB(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
    }
    
    public class CodeConfig : DbConfiguration
    {
        public CodeConfig()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
            SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
}
