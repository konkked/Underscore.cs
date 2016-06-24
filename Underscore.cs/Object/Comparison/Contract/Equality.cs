namespace Underscore.Object.Comparison
{
    public interface IEqualityComponent
    {
        bool AreEquatable(object a, object b);
        bool AreEquatable(object a, object b, bool typeSensitive);
        bool AreEquatable<T>(T a, T b);
    }
}
