using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Underscore.Object.Reflection;

namespace Underscore.Object.Comparison
{
    public class EqualityComponent : IEqualityComponent
    {
        private readonly IPropertyComponent _property;

        public EqualityComponent(IPropertyComponent property)
        {
            _property = property;
        }

        public bool AreEquatable(object a, object b)
        {
            return AreEquatableTypeInsensitiveImpl(a, b);
        }

        private bool AreEquatableTypeInsensitiveImpl(object a, object b)
        {
            if (Equals(a, b))
                return true;

            //one is null and one isn't
            if (a == null ^ b == null)
                return false;

            //because know both match only check one to know both are null
            if (a == null)
                return true;

            var aProps = _property.Pairs(a).ToDictionary(c => c.Name, c => c.Value);

            var bProps = _property.Pairs(b).ToList();

            if (aProps.Count != bProps.Count)
                return false;

            foreach (var bprop in bProps)
            {
                if (!aProps.ContainsKey(bprop.Name))
                    return false;

                if (!AreEquatableTypeInsensitiveImpl(bprop.Value, aProps[bprop.Name]))
                    return false;
            }

            return true;
        }

        public bool AreEquatableTypeSensitiveImpl(object a, object b, bool mixed)
        {
            if (Equals(a, b))
                return true;
            
            //one is null and one isn't
            if (a == null ^ b == null)
                return false;

            //because know both match only check one to know both are null
            if (a == null)
                return true;

            if (a.GetType() != b.GetType())
                return false;


            var joined = _property.Pairs(a)
                .Join(_property.Pairs(b), l => l.Name, r => r.Name,
                    (leftHandSide, rightHandSide) => new {leftHandSide, rightHandSide});

            return joined.Aggregate(true, (prevResult, nextItem) => prevResult &&
                ((mixed && AreEquatableTypeInsensitiveImpl(nextItem.rightHandSide.Value, nextItem.leftHandSide.Value))
                    || AreEquatableTypeSensitiveImpl(nextItem.rightHandSide.Value, nextItem.leftHandSide.Value, false)));

        }

        public bool AreEquatable(object a, object b, bool typeSensitive)
        {
            if (typeSensitive)
            {
                //in this case we want everything to be case sensitive all the way down
                return AreEquatableTypeSensitiveImpl(a, b,false);
            }

            return AreEquatableTypeInsensitiveImpl(a, b);
        }

        public bool AreEquatable<T>(T a, T b)
        {
            //here we know the first types match, but we don't know if the 
            //caller wants to have this effect cascade all the way down the comparisions
            //
            //because of that and the fact this is implict will have it mimic the same behavior as
            //the object, object counterpart, but take advantage of timesaving of not having to construct a dictionary
            //before making comparisions the first time
            return AreEquatableTypeSensitiveImpl(a, b , true);
        }
    }
}
