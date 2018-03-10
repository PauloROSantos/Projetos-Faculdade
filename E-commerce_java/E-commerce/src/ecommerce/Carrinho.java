package ecommerce;


import java.util.HashMap;


public class Carrinho {
	HashMap<Integer, Produto> produtos;
	Integer totalitens = 0;
	
	
	public HashMap<Integer, Produto> getProdutos() {
		return produtos;
	}


	public void setProdutos(HashMap<Integer, Produto> produtos) {
		this.produtos = produtos;
	}


	public Carrinho(){
		produtos = new HashMap<Integer, Produto>();
	}


	public void removerDoCarrinho(Integer chave) {
		if(produtos.containsKey(chave)){
			produtos.containsValue(chave);
			produtos.remove(chave);
			totalitens--;
		}else{
			
		}
		
	}


	public void addNoCarrinho(Produto produto) {
		if ( produto.getQtdEstoque() > 0){
			produto.setQtdEstoque(produto.getQtdEstoque()-1);
			produtos.put(totalitens, produto);
			totalitens++;
		}else{
			
		}
		
		
	}


	public void mostrarCarrinho() {
		int i = 0;
		for(Produto produtoDaVez : produtos.values()){
			System.out.println("Op��o "+i);
			System.out.println(produtoDaVez);
			System.out.println();
			i++;
		}
	
		
	}
	

}
