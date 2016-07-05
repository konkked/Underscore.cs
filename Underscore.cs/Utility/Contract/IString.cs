using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Utility
{
	public interface IStringComponent
	{
		string ToCamelCase(string s);

		bool IsCamelCase(string s);

		string ToPascalCase(string s);

		bool IsPascalCase(string s);

		string Capitalize(string s);

		bool IsCapitalized(string s);

		string ToSnakeCase(string s);

		bool IsSnakeCase(string s);

		string ToKebabCase(string s);

		bool IsKebabCase(string s);

		string ToStartCase(string s);

		bool IsStartCase(string s);

		IEnumerable<string> Words(string s);
	}
}
