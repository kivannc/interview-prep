namespace InterviewPrep.HackerRank;

internal partial class Questions
{
  public static string IsValid(string s)
  {
    if (s.Length < 4) return "YES";

    var dictionary = new Dictionary<char, int>();
    foreach (var c in s)
    {
      if (dictionary.ContainsKey(c))
      {
        dictionary[c] += 1;
      }
      else
      {
        dictionary.Add(c, 1);
      }
    }

    if (dictionary.Count == 1)
    {
      return "YES";
    }


    var values = dictionary.Values.ToList();
    var firstValue = values[0];
    var secondValue = values[1];
    var difference = Math.Abs(firstValue - secondValue);

    if (dictionary.Count == 2)
    {
      if (difference > 1)
      {
        return "NO";
      }

      return "YES";
    }

    var thirdValue = values[2];


    var compareValue = 0;
    if (difference == 0)
    {
      compareValue = firstValue;
    }
    else
    {
      if (thirdValue == firstValue)
      {
        compareValue = firstValue;
      }

      if (thirdValue == secondValue)
      {
        compareValue = secondValue;
      }
    }

    if (difference > 1)
    {
      return "NO";
    }


    if (compareValue == 0) return "NO";

    for (int i = 2; i < values.Count; i++)
    {
      if (compareValue == values[i])
      {
        continue;
      }

      if (difference == 1)
      {
        return "NO";
      }

      difference++;
    }

    return "YES";
  }

}