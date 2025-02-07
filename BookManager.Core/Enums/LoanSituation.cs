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
                LoanSituation.Current => "the loan is not late",
                LoanSituation.Delayed => "The loan is late",
                _ => "Unknown"
            };
        }
    }
}