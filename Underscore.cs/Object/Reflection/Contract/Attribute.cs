using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Object.Reflection
{
    public interface IAttributeComponent
    {
        bool Has<TAttribute>( object value ) where TAttribute : System.Attribute;
        TAttribute Find<TAttribute>( object value ) where TAttribute : System.Attribute;
        IEnumerable<TAttribute> All<TAttribute>( object value ) where TAttribute : System.Attribute; 
    }
}
