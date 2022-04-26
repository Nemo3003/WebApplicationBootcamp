namespace Classes;

public class BankAccount
{
    public string? Number { get; }
    public string? Owner { get; set; }
    public decimal Balance { get; }

    public static void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public static void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}