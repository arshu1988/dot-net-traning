using Banking;
using Banking.Operations;

Account account = new Account();
account.triggerUnderBalance += AccountOperationListner.blockAccount;
account.triggerUnderBalance += AccountOperationListner.sendEmail;

decimal initialBalance = 100000.00M;
account.Balance = initialBalance;
Console.WriteLine("Initial Balance is :  "+initialBalance);
Console.WriteLine("Do you want to deposit money? yes/no");
string input = Console.ReadLine();
bool deposit =  AccountOperationListner.acceptedInput.Contains(input) ? true : false;
string action = deposit ? "deposit" : "withdraw";
Console.WriteLine("Enter the amount you want to "+action+" : ");
decimal amount = Convert.ToDecimal(Console.ReadLine());
if(deposit){
    account.Deposit(amount);
    Console.WriteLine("Amount "+amount+" deposited successfully");
 }
 else{
    account.Withdraw(amount);
 }