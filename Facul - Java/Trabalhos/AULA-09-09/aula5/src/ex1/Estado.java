package ex1;

import java.util.ArrayList;

public class Estado {
	private ArrayList<Cidade> cidades = new ArrayList<Cidade>();
	
	public boolean addCidade(Cidade cidade){
		return cidades.add(cidade);
	}
	
	
	
	

	
	private String nome;
	private String sigla;
	
	public Estado(String novoNome, String novaSigla){
		this.nome = novoNome;
		this.sigla = novaSigla;
		
	}
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getSigla() {
		return sigla;
	}
	public void setSigla(String sigla) {
		this.sigla = sigla;
	}
	
}
