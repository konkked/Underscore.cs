using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public sealed class Members<T> where T : MemberInfo
    {
        private readonly Func<T, bool> _filter;
        private readonly BindingFlags _flags;

        public Members(Func<T, bool> filter, BindingFlags flags)
        {
            _filter = filter ?? (a => true);
            _flags = flags;
        }

        private IEnumerable<T> Enumerate(Type type, BindingFlags flags)
        {
            return type.GetMembers(flags).OfType<T>().Where(_filter);
        }

        /// <summary>
        /// Finds all members of a specified type
        /// </summary>
        public IEnumerable<T> All(Type target, BindingFlags flags)
        {
            return target.GetMembers(flags).OfType<T>().Where(_filter);
        }

        /// <summary>
        /// Finds all members of type <typeparamref name="T"/> in target
        /// </summary>
        public IEnumerable<T> All(object target, BindingFlags flags)
        {
            return All(target.GetType(), flags);
        }

        /// <summary>
        /// Finds all members of type <typeparamref name="T"/> in target
        /// </summary>
        /// <param name="target">The type to search on</param>
        public IEnumerable<T> All(Type target)
        {
            return All(target, _flags);
        }

        /// <summary>
        /// Finds all members of type <typeparamref name="T"/> in target
        /// </summary>
        /// <param name="target">The type to search on</param>
        public IEnumerable<T> All(object target)
        {
            return All(target, _flags);
        }

    }
}
