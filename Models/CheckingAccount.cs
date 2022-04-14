namespace ProjetoBanco.Models
{
    public class CheckingAccount : BankAccount
    {
        public double CreditLimit { get; set; }
        
        public void SetCreditLimit(double creditLimit)
        {
            CreditLimit = creditLimit;
        }
        public double GetCreditLimit(){
            return CreditLimit;
        }
    }

}