public class Cliente{
    public Cliente(string n, string cpf){
        this.nome = n;
        this.CPF = cpf;
    }

    public string nome{get;set;}
    private string CPF{get;set;}
    public List<Produto> produtos = new List<Produto>();

    public void comprar(Produto p){
        produtos.Add(p);
    } 
}