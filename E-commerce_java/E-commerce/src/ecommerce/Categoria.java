package ecommerce;

public class Categoria {
	private String nome;
	private String descrição;
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getDescrição() {
		return descrição;
	}
	public void setDescrição(String descrição) {
		this.descrição = descrição;
	}
	public Categoria(String nome, String descrição) {
		super();
		this.nome = nome;
		this.descrição = descrição;
	}

}
