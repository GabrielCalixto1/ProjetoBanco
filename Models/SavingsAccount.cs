namespace ProjetoBanco.Models
{
    public class SavingsAccount : BankAccount
    {
        public double Fees { get; set; }
        
        public void SetFees(double fees)
        {
            Fees = fees;
        }
        public double GetFees(){
            return Fees;
        }
    }

}