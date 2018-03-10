package ecommerce;



public class Usuario {

	private String nome;
	private String telefone;
	private String enderešo;
	private String senha;
	private String email;
	private Carrinho carrinho;
	
	public Carrinho getCarrinho() {
		return carrinho;
	}
	public void setCarrinho(Carrinho carrinho) {
		this.carrinho = carrinho;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getTelefone() {
		return telefone;
	}
	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}
	public String getEnderešo() {
		return enderešo;
	}
	public void setEnderešo(String enderešo) {
		this.enderešo = enderešo;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getSenha() {
		return senha;
	}
	public void setSenha(String senha) {
		this.senha = senha;
	}
	
	public Usuario(String nome, String telefone, String enderešo, String email, String senha) {
		this.nome = nome;
		this.telefone = telefone;
		this.enderešo = enderešo;
		this.email = email;
		this.senha = senha;
		carrinho = new Carrinho();
	}
	public void removerDoCarrinho(Integer chave) {
		 carrinho.removerDoCarrinho(chave);
		
	}
	public void addNoCarrinho(Produto produto) {
		 carrinho.addNoCarrinho(produto);
		
	}
	public void mostrarCarrinho(){
		carrinho.mostrarCarrinho();
	}

}
