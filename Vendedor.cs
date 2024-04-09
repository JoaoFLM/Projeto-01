public class Vendedor : Funcionario{
    public Vendedor(string n, string cpf, double s) : base(n, cpf, s){
        this.vendas = 0;    
    } 
    public int vendas{get;set;}

    public double comissao(){
        return 2*vendas;
    }
}