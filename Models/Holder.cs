namespace ProjetoBanco.Models
{
    public class Holder
    {
        private string Name {get;set;}
        public string Cpf {get; set;}

        public string GetName(){
        return Name;          
        }
        public void SetName(string name){
            Name = name;
        }
        public void SetCpf(string cpf){
            Cpf = cpf;
        }
        public string GetCpf(){
            return Cpf;
        }
    }
}