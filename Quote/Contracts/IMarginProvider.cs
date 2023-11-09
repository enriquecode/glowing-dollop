namespace Quote.Contracts
{
    public interface IMarginProvider
    {
        decimal GetDefaultMargin();
        decimal GetMargin(string code);
    }
}
