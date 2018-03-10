package ecommerce;



import java.util.HashMap;
import java.util.HashSet;

import java.util.Scanner;
import java.util.Set;

public class Loja {
	HashMap<Integer, Produto> produtos2 = new HashMap<>();
	Set<Usuario> usuariosReg = new HashSet<Usuario>();
	Usuario usuario1;
	boolean logou = false;
	boolean logado = false;
	Scanner sc = new Scanner(System.in);
	

	
	public Loja(){
		gerarProdutos();
		gerarUserAdmin();
		//boasVindas();
		//opcoes();
		
	}
	private void gerarUserAdmin() {
		usuariosReg.add(new Usuario("Administrador","teste","teste","admin","admin"));
		
	}
	public void abrir(){
		boasVindas();
		opcoes();
	}
	public void loja(){
		boasVindas();
		opcoes();
	}
	


	private void opcoes() {
		String opcao;
		
		System.out.println("-----------------------------------");
		System.out.println();
		System.out.println("Menu de op��es: ");
		System.out.println();
		System.out.println("1 - Mostrar pokemons.");
		System.out.println("2 - Registrar usuario.");
		if(!logado){
			System.out.println("3 - login.");
		}else{
			System.out.println("3 - deslogar.");
			System.out.println("4 - mostrar carrinho.");
		}
		System.out.println();
		System.out.println("-----------------------------------");
		opcao = sc.nextLine();
		
		if(opcao.contains("1")){
			mostrarProdutos();
		}else if(opcao.contains("2")){
			registrar();
		}else if((opcao.contains("3")) && (logado)){
			deslogar();
		}else if((opcao.contains("3")) && (!logado)){
			login();
		}else if((opcao.contains("4")) && (logado)){
			areaUsuario();
		}else{
			System.out.println("Digite uma op��o valida!");
			opcoes();
		}
	}
	private void areaUsuario() {
		System.out.println("-----------------------------------");
		System.out.println("Itens no carrinho");
		System.out.println("-----------------------------------");
		usuario1.mostrarCarrinho();
		System.out.println("-----------------------------------");
		System.out.println("1 - voltar aos produtos e continuar comprando.");
		System.out.println("2 - remover algum item do carrinho.");
		System.out.println("3 - finalizar compra.");
		System.out.println("escolha sua op��o:");
		System.out.println("-----------------------------------");
		int opcao = sc.nextInt();
		if (opcao == 1){
			mostrarProdutos();
		}else if ( opcao == 2){
			removerItemCarrinho();
		}else if ( opcao == 3){
			new Venda(usuario1).finalizarVenda();
			
		}else{
			System.out.println("Digite uma op��o valida");
			areaUsuario();
		}
		
		
	}
	private void removerItemCarrinho() {
		System.out.println("-----------------------------------");
		usuario1.mostrarCarrinho();
		System.out.println("-----------------------------------");
		System.out.println("Escolha o item a ser removido:");
		Integer opcao = sc.nextInt();
		usuario1.removerDoCarrinho(opcao);
		areaUsuario();
	}
	private void opcoes2() {
		System.out.println("Escolha um produto ou :");
		System.out.println("99 voltar ao menu anterior.");
		System.out.println("-----------------------------------");
		int opcao = sc.nextInt();
		if( (opcao >= 0) && (opcao < 10)){
			mostrarProduto(opcao);
		}else if(opcao == 99){
			loja();
		}else{
			System.out.println("Escolha uma op��o valida");
			opcoes2();
		}
	}

	private void mostrarProduto(int opcao) {
		System.out.println("-----------------------------------");
		System.out.println(produtos2.get(opcao));
		System.out.println("-----------------------------------");
		if(logado){
			System.out.println("1 - adicionar ao carrinho.");
		}
		System.out.println("2 - voltar a loja.");
		System.out.println("-----------------------------------");
		String opcao2 = sc.nextLine();
		if(opcao2.contains("1")){
			usuario1.addNoCarrinho(produtos2.get(opcao));
			System.out.println("-----------------------------------");
			System.out.println("Produto adicionado ao carrinho.");
			System.out.println("-----------------------------------");
			System.out.println("1 - voltar aos produtos e continuar comprando.");
			System.out.println("2 - voltar a loja.");
			System.out.println("3 - mostrar carrinho.");
			System.out.println("-----------------------------------");
			opcao2 = sc.nextLine();
			if(opcao2.contains("1")){
				mostrarProdutos();
			}else if(opcao2.contains("2")){
				loja();
			}else if(opcao2.contains("3")){
				areaUsuario();
			}else{
				System.out.println("Op��o invalida.");
				loja();
			}

		}else if(opcao2.contains("2")){
			loja();
		}else{
			System.out.println("Digite uma op��o valida.");
			mostrarProduto(opcao);
		}

	}
	private void deslogar() {
		usuario1 = null;
		logado = false;
		loja();
		
	}

	private void login() {
		System.out.println("-----------------------------------");
		System.out.println();
		System.out.println("Digite seu login ( seu email ) : ");
		String loginteste = sc.nextLine();
		System.out.println("Digite sua senha: ");
		String senhateste = sc.nextLine();
		System.out.println("-----------------------------------");
		try{
			//if(           (login.contains(loginteste)) && (senha.contains(senhateste))         ){
			for(Usuario usuarioDaVez : usuariosReg){
				if((usuarioDaVez.getEmail().contains(loginteste)) && (usuarioDaVez.getSenha().contains(senhateste)) ) {
					System.out.println("logado com sucesso");
					System.out.println("-----------------------------------");
					usuario1 = usuarioDaVez;
					logou = true;
					logado = true;
					loja();
			
				}else{
					
				}
			}
			if(!logou){
				System.out.println("Senha incorreta.");
				System.out.println("-----------------------------------");
				loja();
			}
			
		}catch(java.lang.NullPointerException e){
			System.out.println("Senha incorreta.");
			System.out.println("-----------------------------------");
		}
		
	}

	private void registrar() {
		System.out.println("Digite seu nome: ");
		String nome = sc.nextLine();
		System.out.println("Digite seu telefone: ");
		String telefone = sc.nextLine();
		System.out.println("Digite seu endere�o ");
		String end = sc.nextLine();
		System.out.println("Digite seu email (este ser� seu login) ");
		String mail = sc.nextLine();
		System.out.println("Digite sua senha: ");
		String senha = sc.nextLine();
		
		usuariosReg.add(new Usuario(nome,telefone,end,mail,senha));
		//usuario1 = new Usuario(nome,telefone,end,mail,senha);
		//this.senha = senha;
		//this.login = mail;
		System.out.println("-----------------------------------");
		System.out.println("Registro efetuado com sucesso! ");
		System.out.println("-----------------------------------");
		loja();
		
	}

	private void mostrarProdutos() {
		int i = 0;
		for(Produto produtoDaVez : produtos2.values()){
			System.out.println("Op��o "+i);
			System.out.println(produtoDaVez);
			System.out.println();
			i++;
		}
		System.out.println("-----------------------------------");
		opcoes2();
	}
	

	public void boasVindas(){
		System.out.println("Bem vindo ao E-commerce PokeGym");
		System.out.println("Aqui voc� encontra os mais fortes pokemons!");
		System.out.println();
		if(logado){
			try{
				System.out.println("Bem vindo: "+usuario1.getNome());
			}catch(java.lang.NullPointerException e){
				System.out.println("Usuario teste.");
			}
		}else{
			System.out.println("Nenhum usuario logado.");
		}
		
	}


	private void gerarProdutos() {
		
		// Adicionar produtos //
		Produto pokemon1 = new Produto("Pikachu","pokemon do tipo raio",1000.00,2, new Categoria("raio","forte contra agua"));

		Produto pokemon2 = new Produto("Charizard","pokemon voador do tipo fogo",50000.00,1, new Categoria("fogo","um dos elementos mais fortes"));

		Produto pokemon3 = new Produto("Blastoise","Puta bicho da hora",50000.00,1, new Categoria("agual","da um pal no charizard e em pedra"));

		Produto pokemon4 = new Produto("Venusaur","pokemon do tipo planta",50000.00,1, new Categoria("grama","forte contra agua e terra"));

		Produto pokemon5 = new Produto("Pidgey","serve pra nada",50.00,35, new Categoria("voador","pruuu pruuu"));

		Produto pokemon6 = new Produto("Oddish","N�o legalizado",4.20,300, new Categoria("mato","forte contra o stress"));

		Produto pokemon7 = new Produto("Psyduck","Pato psiquico",1500.00,5, new Categoria("psiquico","forte contra fantasma"));

		Produto pokemon8 = new Produto("Gengar","Pokemon do tipo fantasma",15000.00,1, new Categoria("fantasma","forte contra fantasma e psiquico"));

		Produto pokemon9 = new Produto("Dragonite","Outro bicho fodao",100000.00,2, new Categoria("drag�o","bom contra a maioria dos pokemons"));

		Produto pokemon10 = new Produto("Magikarp","Pior que uma pomba",5.00,15000, new Categoria("comida","serve pra comer"));
		
		produtos2.put(0,pokemon1);
		produtos2.put(1,pokemon2);
		produtos2.put(2,pokemon3);
		produtos2.put(3,pokemon4);
		produtos2.put(4,pokemon5);
		produtos2.put(5,pokemon6);
		produtos2.put(6,pokemon7);
		produtos2.put(7,pokemon8);
		produtos2.put(8,pokemon9);
		produtos2.put(9,pokemon10);
		
		
		
		
		// ------------------ //
		
	}
}