package condo;

import java.util.ArrayList;

public class Condominio {
	private String nome;
	private String cidade;
	private String bairro;
	private int identificador;
	private ArrayList<Predio> predios = new ArrayList<Predio>();
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getCidade() {
		return cidade;
	}
	public void setCidade(String cidade) {
		this.cidade = cidade;
	}
	public String getBairro() {
		return bairro;
	}
	public void setBairro(String bairro) {
		this.bairro = bairro;
	}
	public int getIden() {
		return identificador;
	}
	public void setIden(int identificador) {
		this.identificador = identificador;
	}
	public Condominio(String nome, String cidade, String bairro, int identificador) {
		this.nome = nome;
		this.cidade = cidade;
		this.bairro = bairro;
		this.identificador = identificador;
	}
	
	public double rendaMedia(){
		double media = 0;
		for (Predio predioDaVez : predios){
			media += predioDaVez.rendaMedia();
		}
		if ( media != 0){
			return media/predios.size();
		}else{
			return 0.0;
		}
		
	}
	
	public boolean addPredio(Predio predio){
		if (( predios.size() >= 100 ) || (predios == null)){
			return false;
		}else{
			predios.add(predio);
			return true;
		}
		
	}
	
	public ArrayList<Predio> listaPredios(){
		if (!predios.isEmpty()){
			return predios;
		}else{
			return null;
		}
		
	}
	
	public int nDeApartamentos(){
		int total = 0;
		for (Predio predioDaVez : predios){
			total += predioDaVez.nApartamentos();
		}
		return total;
	}
	
	public int nDeApartamentosVazios(){
		int total = 0;
		for (Predio predioDaVez : predios){
			total += predioDaVez.nApartamentosVazios();
		}
		return total;
	}

	
	
}
