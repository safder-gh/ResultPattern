using ResultPattern.Common;

namespace ResultPattern.Accounts
    {
    public class AccountService : IAccountService
        {
        public Result<decimal> Withdraw(decimal balance, decimal amount)
            {
            if (amount <= 0)
                {
                return Result<decimal>.Failure(new Error("Invalid Amount", "Amount must be a positive value."));
                }
            if (amount > balance)
                {
                return Result<decimal>.Failure(new Error("INSUFFICIENT_FUNDS", "Insufficient funds."));
                }

            return Result<decimal>.Success(balance - amount);
            }
        }
    }
