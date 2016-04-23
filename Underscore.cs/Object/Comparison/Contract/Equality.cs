using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Object.Comparison
{
    public interface IEqualityComponent
    {
        bool AreEquatable(object a, object b);
        bool AreEquatable(object a, object b, bool typeSensitive);
        bool AreEquatable<T>(T a, T b);
    }
}
