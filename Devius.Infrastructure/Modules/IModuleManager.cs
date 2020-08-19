using System;
using System.Collections.Generic;
using System.Text;

namespace Devius.Infrastructure.Modules
{
    public interface IModuleManager
    {
        IEnumerable<IModule> GetModules();
    }
}
