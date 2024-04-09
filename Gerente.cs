public class Gerente : Funcionario{
    public Gerente(string n, string cpf, double s) : base(n, cpf, s){
    }
    public double recerberBonificacao(double bonificacao){
        double bonificacaoPadrao = base.receberBonificacao();
        return bonificacaoPadrao+bonificacao;
    }
}