namespace Alisher.StringExtensions;

public static class StringExtensions
{
    // Matn ichidagi ortiqcha bo'shliqlarni (probellarni) tozalab beruvchi extension metod
    public static string CleanSpaces(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        // So'zlar orasida bittadan ortiq probel bo'lsa, ularni bitta qilib beradi
        return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    }
}