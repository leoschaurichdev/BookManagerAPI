namespace BookManager.Core.Enums
{
    public enum LoanSituation
    {
        Current,
        Delayed
    }

    public static class LoanSituationExtensions
    {
        public static string ToDisplayString(this LoanSituation situation)
        {
            return situation switch
            {
                LoanSituation.Current => "The loan is in progress",
                LoanSituation.Delayed => "The loan is late",
                _ => "Unknown"
            };
        }
    }
}