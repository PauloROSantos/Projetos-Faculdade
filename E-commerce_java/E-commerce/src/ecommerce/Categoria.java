package ecommerce;

public class Categoria {
	private String nome;
	private String descri��o;
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getDescri��o() {
		return descri��o;
	}
	public void setDescri��o(String descri��o) {
		this.descri��o = descri��o;
	}
	public Categoria(String nome, String descri��o) {
		super();
		this.nome = nome;
		this.descri��o = descri��o;
	}

}
