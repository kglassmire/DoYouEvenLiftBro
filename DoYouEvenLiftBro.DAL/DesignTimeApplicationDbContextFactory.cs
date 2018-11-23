using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL
{
    public class DesignTimeApplicationDbContextFactory : IDesignTimeDbContextFactory<DoYouEvenLiftBroContext>
    {
        public DoYouEvenLiftBroContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DoYouEvenLiftBroContext>();

            builder.UseNpgsql("Server=localhost; Database=doyouevenliftbro; UserId=postgres; Password=development");

            return new DoYouEvenLiftBroContext(builder.Options);
        }
    }
}
