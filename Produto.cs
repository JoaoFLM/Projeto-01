public class Produto{
    public Produto(string n, double p, string ID){
        this.nome = n;
        this.preco = p;
        this.id = ID;
    }
    public string nome{get;set;}
    public double preco{get;set;}
    public string id{get;set;}


    public double calcularDesconto(){
        return this.preco*0.8;
    }
}