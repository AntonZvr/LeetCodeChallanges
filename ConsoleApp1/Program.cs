using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        // Initialize rows as StringBuilder
        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            rows.Add(new StringBuilder());

        int currentRow = 0;
        bool goingDown = false;

        // Place characters in zigzag pattern
        foreach (char c in s)
        {
            rows[currentRow].Append(c);

            // Change direction at the top or bottom row
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;

            currentRow += goingDown ? 1 : -1;
        }

        // Combine all rows into the final result
        StringBuilder result = new StringBuilder();
        foreach (var row in rows)
            result.Append(row);

        return result.ToString();
    }
}
