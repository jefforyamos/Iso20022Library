
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
		return unfixedString
			.RemoveOrReplaceFunkyCharacters()
			.Replace("\"", "\"\"");
	}

    public static string FixStringForEnclusionInQuotedAttribute(this string[] unfixedStringArray)
    {
        var fixedLines = unfixedStringArray.Select( unfixed => unfixed.FixStringForEnclusionInQuotedAttribute()).ToArray();
		return string.Join(" ", fixedLines);
    }

	public static string RemoveOrReplaceFunkyCharacters(this string unfixedString)
	{
		return unfixedString
			.Replace("&#xA;", "|")
			.Replace("\r\n", "|")
			.Replace('\n', '|')
			.Replace('\r', '|');
	}

    public static IEnumerable<string> RemoveOrReplaceFunkyCharacters(this IEnumerable<string> unfixedStrings)
    {
		return unfixedStrings.Select(s => s.RemoveOrReplaceFunkyCharacters());
    }

    public static string[] SplitIntoSeparateLines(this string unfixed)
	{
		return unfixed.Split("\r\n");
	}
}

