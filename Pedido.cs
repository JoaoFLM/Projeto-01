public class Pedido{
    public Pedido(Cliente c, Vendedor v){
        this.cliente = c;
        this.vendedor = v;
    }

    public Cliente cliente{get;set;}
    public Vendedor vendedor{get;set;}

    public void vender(){
        vendedor.vendas++;
    }
}