Loja l1 = new Loja("Loja ficticia 01");

Produto p1 = new Produto("Produto 01", 10, "00001");
Produto p2 = new Produto("Produto 02", 20, "00002");

Vendedor v1 = new Vendedor("Vendedor ficticio 01", "000.000.000-01", 1200);
Vendedor v2 = new Vendedor("Vendedor ficticio 02", "000.000.000-2", 1300);

Gerente g1 = new Gerente("Gerente ficticio 01", "000.000.001-01", 2300);

Cliente c1 = new Cliente("Cliente ficticio 01", "000.000.002-01");
Cliente c2 = new Cliente("Cleinte ficticio 02", "000.000.002-02");

c1.comprar(p1);
c1.comprar(p2);
c2.comprar(p1);
c2.comprar(p2);

Pedido pedido01 = new Pedido(c1, v1);
Pedido pedido02 = new Pedido(c2, v1);
Pedido pedido03 = new Pedido(c1, v2);

pedido01.vender();
pedido02.vender();
pedido03.vender();

l1.adicionarFuncionario(v1);
l1.adicionarFuncionario(v2);
l1.adicionarFuncionario(g1);

l1.adicionarPedidos(pedido01);
l1.adicionarPedidos(pedido02);
l1.adicionarPedidos(pedido03);

l1.adicionarCliente(c1);
l1.adicionarCliente(c2);

l1.exibirinformacoes();