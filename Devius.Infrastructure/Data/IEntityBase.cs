using System;
using System.Collections.Generic;
using System.Text;

namespace Devius.Infrastructure.Data
{
    public interface IEntityBase
    {
        Guid Id { get; }
    }
}
