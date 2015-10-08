using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Object
{
    public interface IDynamicComponent
    {
        dynamic ToDynamic( object target );

    }
}
