package e_commerce;

import java.util.Date;

public class Produto {
	private String nome;
	private double valor;
	private Date data_inclusão;
	private String descrição;
	private int avaliaçãoDoUsuario;
	private int numeroDeVotantes;
	private int valorTotalDaNota;
	private Categoria categoria;
	
	
	public Categoria getCategoria() {
		return categoria;
	}
	public void setCategoria(Categoria categoria) {
		this.categoria = categoria;
	}
	public int getValorTotalDaNota() {
		return valorTotalDaNota;
	}
	public void setValorTotalDaNota(int valorTotalDaNota) {
		this.valorTotalDaNota = valorTotalDaNota;
	}
	public int getAvaliaçãoDoUsuario() {
		return avaliaçãoDoUsuario;
	}
	public void setAvaliaçãoDoUsuario(int avaliaçãoDoUsuario) {
		this.avaliaçãoDoUsuario = avaliaçãoDoUsuario;
	}
	public int getNumeroDeVotantes() {
		return numeroDeVotantes;
	}
	public void setNumeroDeVotantes(int numeroDeVotantes) {
		this.numeroDeVotantes = numeroDeVotantes;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public double getValor() {
		return valor;
	}
	public void setValor(double valor) {
		this.valor = valor;
	}
	public Date getData_inclusão() {
		return data_inclusão;
	}
	public void setData_inclusão(Date data_inclusão) {
		this.data_inclusão = data_inclusão;
	}
	public String getDescrição() {
		return descrição;
	}
	public void setDescrição(String descrição) {
		this.descrição = descrição;
	}
	
	public Produto(String nome, double valor, Date data_inclusão,
			String descrição, Categoria categoria) {
		super();
		this.nome = nome;
		this.valor = valor;
		this.data_inclusão = data_inclusão;
		this.descrição = descrição;
		this.categoria = categoria;
	}
	
	public int avaliaçãoDoUsuario(){
		return valorTotalDaNota / numeroDeVotantes;
		
	}
	public void avaliarProduto(int nota){
		numeroDeVotantes++;
		valorTotalDaNota += nota;
	}
	
	

	
}
