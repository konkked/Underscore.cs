using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
    public class ConstructorComponent: MethodsBaseComponent<ConstructorInfo>, IConstructorComponent
    {
        public ConstructorComponent(ICacheComponent cacher, IPropertyComponent properties)
            : base(cacher, properties, new Members<ConstructorInfo>(cacher, null, BindingFlags.Instance | BindingFlags.Public))
        {
        }

        protected override bool IsSpecialCase(string name)
        {
            //currently no special cases for constructor
            return false;
        }

        protected override IEnumerable<ConstructorInfo> FilterSpecialCase(string name, object value, IEnumerable<ConstructorInfo> current)
        {
            //no special cases
            //so this should never invoke
            throw new NotImplementedException("No special cases have been created for the constructor component but was validated as a special case");
        }

        public override IEnumerable<ConstructorInfo> All(object target)
        {
            return All(target.GetType());
        }

        public override IEnumerable<ConstructorInfo> All(Type target)
        {
            return _collection.All(target);
        }

        public override IEnumerable<ConstructorInfo> All(object target, BindingFlags flags)
        {
            return All(target.GetType(), flags);
        }

        public override IEnumerable<ConstructorInfo> All(Type target, BindingFlags flags)
        {
            return _collection.All(target, flags);
        }

        public bool HasParameterless(object target)
        {
            return Parameterless(target)  != null;
        }

        public bool HasParameterless(object target, BindingFlags flags)
        {
            return Parameterless(target,flags) != null;
        }

        public bool HasParameterless(Type target)
        {
            return Parameterless(target)  != null;
        }

        public bool HasParameterless(Type target, BindingFlags flags)
        {
            return Parameterless(target,flags) != null;
        }

        public ConstructorInfo Parameterless(object target)
        {
            return All(target).FirstOrDefault(a => !a.GetParameters().Any());
        }

        public ConstructorInfo Parameterless(object target, BindingFlags flags)
        {
            return All(target,flags).FirstOrDefault(a => !a.GetParameters().Any());
        }

        public ConstructorInfo Parameterless(Type target)
        {
            return All(target).FirstOrDefault(a => !a.GetParameters().Any());
        }

        public ConstructorInfo Parameterless(Type target, BindingFlags flags)
        {
            return All(target, flags).FirstOrDefault(a => !a.GetParameters().Any());
        }

        public ConstructorInfo Find(Type target, object query)
        {
            return Query(target, query).FirstOrDefault();
        }

        public ConstructorInfo Find(Type target, object query, BindingFlags flags)
        {
            return Query(target, query, flags).FirstOrDefault();
        }


        public ConstructorInfo Find(object target, object query)
        {
            return Query(target, query).FirstOrDefault();
        }

        public ConstructorInfo Find(object target, object query, BindingFlags flags)
        {
            return Query(target, query, flags).FirstOrDefault();
        }
    }
}
