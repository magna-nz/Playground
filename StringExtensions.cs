using System.Text;

namespace ConsoleApp1;

public static class StringExtensions
{
/*
  Changes:
   * Make it an extension method
   * Spelling corrections in first line
   * Call first class StringExtensions
   * Pass an IList in
   * Change to var
   * Only add the comma if its not the last item
   * Instead of getitng the first item first at the start of the list, append item and then determine if its the last item or not
   * Not sure what Quote is, is it the seperator? Since it's asked comma seperated I don't think I need the quote there
*/
    public static string ToCommaSeparatedList(this IList<string> items)
    {
        var csvList = new StringBuilder();

        if (!items.Any())
        {
            // null doesn't make sense, so returning an empty string. Caller can check if string.isNullorEmpty()
            return string.Empty;
        }

        for (int i = 0; i < items.Count; i++)
        {
            csvList.Append(items[i]);

            // Check if its the last item in the list, if it isn't, then append the comma
            if (i < (items.Count - 1))
            {
                csvList.Append(", ");
            }
        }

        return csvList.ToString();
    }
}