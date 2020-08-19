using System;
using System.Collections.Generic;
using System.Text;

namespace Devius.Infrastructure.Modules
{
    public interface IModule
    {
        Guid Id { get; }

        string Name { get; }

        Version Version { get; }


    }
}
