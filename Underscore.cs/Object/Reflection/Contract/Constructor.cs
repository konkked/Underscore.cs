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

        bool HasParameterless<T>();
        bool HasParamterless<T>(BindingFlags flags);

        bool HasParameterless(Type target);
        bool HasParameterless(Type target, BindingFlags flags);



        IEnumerable<ConstructorInfo> Parameterless(object target);
        IEnumerable<ConstructorInfo> Parameterless(object target, BindingFlags flags);


        IEnumerable<ConstructorInfo> Parameterless<T>();
        IEnumerable<ConstructorInfo> Parameterless<T>(BindingFlags flags);


        IEnumerable<ConstructorInfo> Parameterless(Type target);
        IEnumerable<ConstructorInfo> Parameterless(Type target, BindingFlags flags);

        IEnumerable<ConstructorInfo> Find(Type target, object query);
        IEnumerable<ConstructorInfo> Find(Type target, object query, QueryFlags flags);
        

        IEnumerable<ConstructorInfo> Find(Type target, object query, BindingFlags flags);
        IEnumerable<ConstructorInfo> Find(Type target, object query, BindingFlags flags, QueryFlags queryFlags);


        IEnumerable<ConstructorInfo> Find(object target, object query);
        IEnumerable<ConstructorInfo> Find(object target, object query, QueryFlags flags);

        IEnumerable<ConstructorInfo> Find(object target, object query, BindingFlags flags);
        IEnumerable<ConstructorInfo> Find(object target, object query, BindingFlags bindingFlags, QueryFlags queryFlags);

        IEnumerable<ConstructorInfo> Find<T>(object query);
        IEnumerable<ConstructorInfo> Find<T>(object query, QueryFlags flags);

        IEnumerable<ConstructorInfo> Find<T>(object query, BindingFlags flags);
        IEnumerable<ConstructorInfo> Find<T>(object query, BindingFlags bindingFlags, QueryFlags queryFlags);


        IEnumerable<ConstructorInfo> All<T>();
        IEnumerable<ConstructorInfo> All<T>(BindingFlags flags);


        IEnumerable<ConstructorInfo> All(Type target);
        IEnumerable<ConstructorInfo> All(Type target, BindingFlags flags);


        IEnumerable<ConstructorInfo> All(object target);
        IEnumerable<ConstructorInfo> All(object target, BindingFlags flags);

    }
}
