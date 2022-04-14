namespace ProjetoBanco.Models
{
    public class BankAccount
    {
        public double Balance { get; set; }
        public Holder Holder { get; set; }
        public int Agency { get; set; }
        public string NumberAccount {get;set;}
        public void SetBalance(double balance)
        {
            Balance = balance;
        }
        public double SetBalance()
        {
            return Balance;
        }
        public void SetHolder(Holder holder)
        {
            Holder = holder;
        }
        public Holder GetHolder()
        {
            return Holder;
        }
        public void SetAgency(int agency)
        {
            Agency = agency;
        }
        public void SetNumAccount(string numberAccount){
            NumberAccount = numberAccount;
        }
        public string GetNumAccount(){
            return NumberAccount;
        }
        public void TakeOut(double value){
            Balance = Balance - value;
        }
        public void Deposit(double value){
            Balance = Balance - value;
            
        }

    }
}