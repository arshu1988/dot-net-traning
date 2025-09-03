namespace Banking;
public class Account
{
 public decimal Balance { get; set; }
 public decimal minimunBalance { get; } = 1000;
    public event AccountOPerations triggerUnderBalance;
 public void Deposit(decimal amount)
 {
  Balance += amount;
 }

 public void Withdraw(decimal amount)
 {
    if(amount > Balance){
        Console.WriteLine("Insufficient funds"+Balance+"-->"+amount);
    }
  Balance -= amount;
  if(Balance<minimunBalance){
    Console.WriteLine("Warning: Balance below minimum required balance");
    triggerUnderBalance();
  }
 }
}
