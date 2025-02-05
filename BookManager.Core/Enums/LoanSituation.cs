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
                LoanSituation.Current => "O emprestimo está em dia",
                LoanSituation.Delayed => "O emprestimo está com a devolução atrasada",
                _ => "Unknown"
            };
        }
    }
}