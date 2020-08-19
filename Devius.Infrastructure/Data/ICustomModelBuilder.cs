using Microsoft.EntityFrameworkCore;


namespace Devius.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
