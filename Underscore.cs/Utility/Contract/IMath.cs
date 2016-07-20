namespace Underscore.Utility
{
	public interface IMathComponent
	{
		/// <summary>
		/// Generates a unique id
		/// </summary>
		/// <param name="prefix">String prefix</param>
		/// <returns>A random string with the passed string prefixed</returns>
		string UniqueId(string prefix);

		/// <summary>
		/// Generates a unique id
		/// </summary>
		/// <returns></returns>
		string UniqueId();

		/// <summary>
		/// Generates a random number
		/// </summary>
		/// <returns>a random number</returns>
		int Random();

		/// <summary>
		/// Generates a random number
		/// </summary>
		/// <param name="max">Max possible</param>
		/// <returns>a random number</returns>
		int Random(int max);

		/// <summary>
		/// Generates a random number
		/// </summary>
		/// <param name="min">Min possible value</param>
		/// <param name="max">Max possible value</param>
		/// <returns>A random number between <paramref name="min"/> and <paramref name="max"/></returns>
		int Random(int min, int max);

		/// <summary>
		/// Performantly calculates absolute value of an int
		/// </summary>
		/// <param name="i"></param>
		/// <returns>Absolute value of i</returns>
		int Abs(int i);

		/// <summary>
		/// Performantly calculates minimum of the passed ints
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>The smallest of the two ints passed</returns>
		int Min(int x, int y);

		/// <summary>
		/// Performantly calculates maximum of the passed ints
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>The largest of the two ints passed</returns>
		int Max(int x, int y);
	}
}
