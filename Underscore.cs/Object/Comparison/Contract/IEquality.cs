namespace Underscore.Object.Comparison
{
	public interface IEqualityComponent
	{
		bool AreEquivalent(object a, object b);
		bool AreEquivalent(object a, object b, bool typeSensitive);
		bool AreEquivalent<T>(T a, T b);
	}
}
