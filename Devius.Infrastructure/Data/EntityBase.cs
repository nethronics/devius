using System;
using System.Collections.Generic;
using System.Text;

namespace Devius.Infrastructure.Data
{
    public abstract class EntityBase : ValidatableObject, IEntityBase
    {
        public virtual Guid Id { get; protected set; }
    }
}
