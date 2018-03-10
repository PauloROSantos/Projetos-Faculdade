package trabalho_mercado;

import java.util.Random;
import java.util.Stack;

//INTEGRANTES
//PAULO ROBERTO RA: 1600356
//LUIS GUSTAVO RA: 1600140
//BRUNO RA: 1600244
//RICARDO ROSSETI RA: 1600432

public class Cliente {
	private int quantidadeDeProduto;
	Random gerador = new Random();
	private int tempoDeEspera = 0;
	Stack<Produto> carrinho = new Stack<Produto>();
	
	public Stack<Produto> getCarrinho() {
		return carrinho;
	}

	public void setCarrinho(Stack<Produto> carrinho) {
		this.carrinho = carrinho;
	}

	public int getTempoDeEspera() {
		return tempoDeEspera;
	}

	public void setTempoDeEspera(int tempoDeEspera) {
		this.tempoDeEspera = tempoDeEspera;
	}

	public int getQuantidadeDeProduto() {
		return quantidadeDeProduto;
	}

	public void setQuantidadeDeProduto(int quantidadeDeProduto) {
		this.quantidadeDeProduto = quantidadeDeProduto;
	}

	
	//criando o cliente e gerando aleatoriamente sua quantidade de itens no carrinho
	public Cliente(){
		this.quantidadeDeProduto = gerador.nextInt(36)+5;
		gerarProdutos(quantidadeDeProduto);
	}

	private void gerarProdutos(int quantidadeDeProduto2) {
		for(int i = 0; i < quantidadeDeProduto2 ; i++){
			carrinho.push(new Produto());
		}
		
	}

	public void adicionaTempoDeEspera() {
		tempoDeEspera++;
		
	}
}
