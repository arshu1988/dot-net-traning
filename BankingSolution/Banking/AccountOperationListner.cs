namespace Banking.Operations;

public static class AccountOperationListner
{
 public static void blockAccount()
 {
  Console.WriteLine("Account is blocked");
 }
 public static void sendEmail()
 {
  Console.WriteLine("Email sent to the account holder");
 }

 public static bool showWarning()
 {
    Console.WriteLine("Warning: Balance below minimum required balance, Do you want to Proceed?");
    string[] acceptedInput = ["yes","Y","y","YES"];
    bool isAccepted = acceptedInput.Contains(Console.ReadLine());
    return isAccepted;    
    //acceptedInput.find(Console.ReadLine()) ? return true : return false;
 }

 public static string[] acceptedInput =["yes","Y","y","YES"];
}