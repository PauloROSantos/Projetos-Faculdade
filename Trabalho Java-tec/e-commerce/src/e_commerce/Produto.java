package e_commerce;

import java.util.Date;

public class Produto {
	private String nome;
	private double valor;
	private Date data_inclus�o;
	private String descri��o;
	private int avalia��oDoUsuario;
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
	public int getAvalia��oDoUsuario() {
		return avalia��oDoUsuario;
	}
	public void setAvalia��oDoUsuario(int avalia��oDoUsuario) {
		this.avalia��oDoUsuario = avalia��oDoUsuario;
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
	public Date getData_inclus�o() {
		return data_inclus�o;
	}
	public void setData_inclus�o(Date data_inclus�o) {
		this.data_inclus�o = data_inclus�o;
	}
	public String getDescri��o() {
		return descri��o;
	}
	public void setDescri��o(String descri��o) {
		this.descri��o = descri��o;
	}
	
	public Produto(String nome, double valor, Date data_inclus�o,
			String descri��o, Categoria categoria) {
		super();
		this.nome = nome;
		this.valor = valor;
		this.data_inclus�o = data_inclus�o;
		this.descri��o = descri��o;
		this.categoria = categoria;
	}
	
	public int avalia��oDoUsuario(){
		return valorTotalDaNota / numeroDeVotantes;
		
	}
	public void avaliarProduto(int nota){
		numeroDeVotantes++;
		valorTotalDaNota += nota;
	}
	
	

	
}