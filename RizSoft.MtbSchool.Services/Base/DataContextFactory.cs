using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizSoft.MtbSchool.Services
{
    public class DataContextFactory : IDbContextFactory<MtbSchoolContext>
    {
        private string _connectionString { get; set; }
        public DataContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MtbSchoolContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MtbSchoolContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            return new MtbSchoolContext(optionsBuilder.Options);
        }
    }
}
