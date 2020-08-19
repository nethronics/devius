using System;
using System.Collections.Generic;
using System.Text;

namespace Devius.Infrastructure.Modules
{
    public class Module : IModule
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public Version Version { get; protected set; }
    }
}
