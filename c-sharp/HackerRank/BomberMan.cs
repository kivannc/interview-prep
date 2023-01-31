using System.Text;

namespace InterviewPrep.HackerRank;

internal partial class Questions
{
  public static List<string> BomberMan(int n, List<string> grid)
  {

    if (n == 1) return grid;

    var allBombsGrid = new List<string>();
    foreach (var row in grid)
    {
      var newRow = new StringBuilder();
      foreach (var cell in row)
      {
        newRow.Append('O');
      }
      allBombsGrid.Add(newRow.ToString());
    }

    if (n % 2 == 0) return allBombsGrid;


    var firstDetonate = DetonateBombs(grid);
    var secondDetonate = DetonateBombs(firstDetonate);

    var state = (n - 3) % 4;

    if (n % 4 == 3)
    {
      return firstDetonate;
    }

    if (n % 4 == 1)
    {
      return secondDetonate;
    }

    return null;
  }

  private static List<string> DetonateBombs(List<string> grid)
  {
    var result = new List<string>();

    for (int i = 0; i < grid.Count; i++)
    {
      var row = "";
      for (int j = 0; j < grid[i].Length; j++)
      {

        if (grid[i][j] == 'O')
        {
          row += ".";
        }
        else if (HasNeighbourBomb(grid, i, j))
        {
          row += ".";
        }
        else
        {
          row += "X";
        }
      }
      result.Add(row);

    }
    var newResult = new List<string>();
    foreach (var row in result)
    {
      newResult.Add(row.Replace('X', 'O'));
    }
    return newResult;
  }

  private static bool HasNeighbourBomb(List<string> grid, int k, int l)
  {

    if (k - 1 >= 0)
    {
      if (grid[k - 1][l] == 'O')
      {
        return true;
      }
    }

    if (k + 1 < grid.Count)
    {
      if (grid[k + 1][l] == 'O')
      {
        return true;
      }
    }

    if (l - 1 >= 0)
    {
      if (grid[k][l - 1] == 'O')
      {
        return true;
      }
    }


    if (l + 1 < grid[0].Length)
    {
      if (grid[k][l + 1] == 'O')
      {
        return true;
      }
    }


    return false;

  }

  public static void PrintGrid(List<string> grid)
  {
    Console.WriteLine("------>Grid");
    foreach (var row in grid)
    {
      Console.WriteLine(row);
    }
    Console.WriteLine("------");
  }

  public static void RunCode()
  {
    var grid = BomberMan(5, new List<string> { ".......", "...O.O.", "....O..", "..O....", "OO...OO", "OO.O..." });
    PrintGrid(grid);
  }
}

