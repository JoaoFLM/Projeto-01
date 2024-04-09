public class Funcionario{
    public Funcionario(string n, string cpf, double s){
        this.nome = n;
        this.CPF = cpf;
        this.salario = s;
    }
    public string nome{get;set;}
    protected string CPF{get;set;}
    public double salario{get;set;}

    public double receberBonificacao(){
        return salario*0.5;
    }
}