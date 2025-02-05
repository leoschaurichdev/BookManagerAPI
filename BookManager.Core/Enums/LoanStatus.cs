namespace BookManager.Core.Enums
{
    public enum LoanStatus
    {
        Active = 0,
        Inactive = 1
    }

    public static class LoanStatusExtensions
    {
        public static string ToDisplayString(this LoanStatus situation)
        {
            return situation switch
            {
                LoanStatus.Active => "The loan is in progress",
                LoanStatus.Inactive => "The book was delivered",
                _ => "Unknown"
            };
        }
    }

}
