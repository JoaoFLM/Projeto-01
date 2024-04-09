using System.Buffers;
using System.Net.WebSockets;

public class Loja{
    public Loja(string n){
        this.nome = n;
        this.aberto = false;
        this.endereco = new Endereco("Rua ficticia", "01", "NULL", "000000-001", "Curitiba", "PR");
    }
    public string nome{get;set;}
    public Endereco endereco{get;set;}
    public Boolean aberto{get;set;}

    public List<Funcionario> funcionarios = new List<Funcionario>();
    public List<Cliente> clientes = new List<Cliente>();
    public List<Pedido> pedidos = new List<Pedido>();

    public void adicionarFuncionario(Funcionario f){
        this.funcionarios.Add(f);
    }
    public void adicionarCliente(Cliente c){
        this.clientes.Add(c);
    }
    public void adicionarPedidos(Pedido p){
        this.pedidos.Add(p);
    }

    public void abrirLoja(){
        if(this.aberto != true) this.aberto = true;
    }
    public void fecharLoja(){
        if(this.aberto != false) this.aberto = false;
    }

    public void exibirinformacoes(){
        Console.WriteLine("*****Loja*****");
        Console.WriteLine("Nome da loja: " + this.nome);
        Console.WriteLine("A loja esta aberta: " + this.aberto);
        Console.WriteLine("*****Endereco*****");
        Console.WriteLine("Rua: " + this.endereco.rua);
        Console.WriteLine("Numero: " + this.endereco.numero);
        Console.WriteLine("Complemento: " + this.endereco.complemento);
        Console.WriteLine("CEP: " + this.endereco.CEP);
        Console.WriteLine("Cidade: " + this.endereco.cidade);
        Console.WriteLine("Unidade Federativa: " + this.endereco.UF);

        foreach(Funcionario f in this.funcionarios){
            Console.WriteLine("*****Funcionario*****");
            Console.WriteLine("Nome: " + f.nome);
            Console.WriteLine("Salario: " + f.salario);
        }   
        foreach(Cliente c in this.clientes){
            Console.WriteLine("*****Cliente*****");
            Console.WriteLine("Nome: " + c.nome);
            foreach(Produto p in c.produtos){
                Console.WriteLine("****Produto****");
                Console.WriteLine("Nome: " + p.nome);
                Console.WriteLine("Preco: " + p.preco);
                Console.WriteLine("ID: " + p.id);
            }
        }  
        foreach(Pedido p in this.pedidos){
            Console.WriteLine("*****Pedido******");
            Console.WriteLine("Nome do Vendedor: " + p.vendedor.nome);
            Console.WriteLine("Nome do Cliente: " + p.cliente.nome);
        }

    }

}