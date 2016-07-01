using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Object
{
    public interface IDynamicComponent
    {
        /// <summary>
        /// Creates a dynamic object
        /// </summary>
        /// <param name="target">the object used to create the dynamic object</param>
        /// <returns>a dynamic object with all of the properties of the passed target object</returns>
        dynamic ToDynamic(object target);
    }
}
