public class Endereco{
    public Endereco(string r, string n, string c, string cep, string cid, string uf){
        this.rua = r;
        this.numero = n;
        this.complemento = c;
        this.CEP = cep;
        this.cidade = cid;
        this.UF = uf;
    }

    public string rua{get;set;}
    public string numero{get;set;}
    public string complemento{get;set;}
    public string CEP{get;set;}
    public string cidade{get;set;}
    public string UF{get;set;}
}