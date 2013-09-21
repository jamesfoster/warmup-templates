namespace __NS__Common.Extensions
{
	using System.Globalization;
	using System.Linq;

	public static class StringExtensions
	{
		public static string ToTitleCase(this string value, CultureInfo cultureInfo)
		{
			var textInfo = cultureInfo.TextInfo;

			return textInfo.ToTitleCase(textInfo.ToLower(value));
		}

		public static bool HasLowerCase(this string str)
		{
			return !string.IsNullOrEmpty(str) && str.Any(x => char.IsLetter(x) && char.IsLower(x));
		}
	}
}
