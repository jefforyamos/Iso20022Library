
namespace System;

public static class GlobalExtensionMethods
{
	/// <summary>
	/// For putting descriptions inside quoted values when declaring attributs with string content.
	/// Causes the quotes to be doubled-up.  For inclusion in @"" block.
	/// </summary>
	/// <param name="unfixedString"></param>
	/// <returns></returns>
	public static string FixStringForEnclusionInQuotedAttribute(this string unfixedString)
	{
		return unfixedString.Replace("\"", "\"\"");
	}
}

