package ecommerce;


import java.util.HashMap;
import java.util.Scanner;



public class Venda {
	private Carrinho carrinho;
	private Usuario usuario;
	private double total;
	private Scanner sc;
	


	public Venda(Usuario usuario){
		this.usuario = usuario;
		carrinho = usuario.getCarrinho();
	}

	public Carrinho getCarrinho() {
		return carrinho;
	}

	public void setCarrinho(Carrinho carrinho) {
		this.carrinho = carrinho;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public double getTotal() {
		return total;
	}

	public void setTotal(double total) {
		this.total = total;
	}
	
	public void calcularTotal(){
		HashMap<Integer, Produto> produtos = carrinho.getProdutos();
		for(Produto produtoDaVez : produtos.values()){
			total += produtoDaVez.getPreco();
			
		}
	}

	public void finalizarVenda() {
		sc = new Scanner(System.in);
		calcularTotal();
		double valor = total;
		
		boolean aux = true;
		
		System.out.println("-----------------------------------");
		while(aux){
			System.out.printf("Total da compra: R$ %.0f,00",total);
			System.out.println();
			System.out.println("Escolha sua forma de pagamento: ");
			System.out.println("1 - Paypal - 5% de desconto");
			System.out.println("2 - Credito");
			System.out.println("3 - Boleto - 10% de desconto");
			System.out.println("-----------------------------------");
		
			String opcao = sc.nextLine();
			
			if(opcao.contains("1")){
				valor *= 0.95;
				System.out.println("-----------------------------------");
				System.out.println("Você escolheu o modo Paypal e teve 5% de desconto");
				aux = false;
				
			}else if(opcao.contains("2")){
				System.out.println("-----------------------------------");
				System.out.println("Você escolheu o modo credito");
				aux = false;
				
			}else if(opcao.contains("3")){
				valor *= 0.90;
				System.out.println("-----------------------------------");
				System.out.println("Você escolheu o modo boleto e teve 10% de desconto");
				aux = false;
				
			}else{
				System.out.println("Digite uma opção valida.");
			}
		
		}
		System.out.println("-----------------------------------");
		System.out.printf("O total da compra foi de: R$ %.0f,00", valor);
		System.out.println();
		System.out.println("Obrigado por comprar na PokeGym!");
		System.out.println("Volte sempre.");
		System.out.println("-----------------------------------");
		
	}
	

}
