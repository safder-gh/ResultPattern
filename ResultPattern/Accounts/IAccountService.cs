using ResultPattern.Common;

namespace ResultPattern.Accounts
    {
    public interface IAccountService
        {
        Result<decimal> Withdraw(decimal balance, decimal amount);
        }
    }