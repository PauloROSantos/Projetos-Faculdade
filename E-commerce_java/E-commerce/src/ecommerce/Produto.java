package ecommerce;

public class Produto extends Pokemon{
	private double preco;
	private int qtdEstoque;
	
	public double getPreco() {
		return preco;
	}
	public void setPreco(double preco) {
		this.preco = preco;
	}
	public int getQtdEstoque() {
		return qtdEstoque;
	}
	public void setQtdEstoque(int qtdEstoque) {
		this.qtdEstoque = qtdEstoque;
	}
	public Produto(String nome, String descricao, double preco, int qtdEstoque, Categoria categoria) {
		super(nome,descricao, categoria);
		this.preco = preco;
		this.qtdEstoque = qtdEstoque;
	
	}

	@Override
	public String toString(){
		 return "nome: "+ getNome() + "\n"+
				 "preço: R$"+getPreco()+"\n"+
				 "categoria: "+getCategoria()+"\n"+
				 "descricao: "+getDescricao();
	}
}
