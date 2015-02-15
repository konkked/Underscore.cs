using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Object.Reflection
{
    public interface IConstructorComponent
    {
        bool HasParameterless(object target);
        bool HasParameterless(object target, BindingFlags flags);

        bool HasParameterless(Type target);
        bool HasParameterless(Type target, BindingFlags flags);



        ConstructorInfo Parameterless(object target);
        ConstructorInfo Parameterless(object target, BindingFlags flags);

        ConstructorInfo Parameterless(Type target);
        ConstructorInfo Parameterless(Type target, BindingFlags flags);

        ConstructorInfo Find(Type target, object query);
        

        ConstructorInfo Find(Type target, object query, BindingFlags flags);


        ConstructorInfo Find(object target, object query);

        ConstructorInfo Find(object target, object query, BindingFlags flags);


        IEnumerable<ConstructorInfo> Query(Type target, object query);

        IEnumerable<ConstructorInfo> Query(Type target, object query, BindingFlags flags);


        IEnumerable<ConstructorInfo> Query(object target, object query);

        IEnumerable<ConstructorInfo> Query(object target, object query, BindingFlags flags);




        IEnumerable<ConstructorInfo> All(Type target);
        IEnumerable<ConstructorInfo> All(Type target, BindingFlags flags);


        IEnumerable<ConstructorInfo> All(object target);
        IEnumerable<ConstructorInfo> All(object target, BindingFlags flags);

    }
}
