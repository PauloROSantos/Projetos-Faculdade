package condo;

import java.util.ArrayList;

public class Predio {

	private int numero;
	private int andares;
	private String pintura;
	private ArrayList<Apartamento> apartamentos = new ArrayList<Apartamento>();
	
	public int getNumero() {
		return numero;
	}
	public void setNumero(int numero) {
		this.numero = numero;
	}
	public int getAndares() {
		return andares;
	}
	public void setAndares(int andares) {
		this.andares = andares;
	}
	public String getPintura() {
		return pintura;
	}
	public void setPintura(String pintura) {
		this.pintura = pintura;
	}
	
	public Predio(int numero, int andares, String pintura) {
		this.numero = numero;
		this.andares = andares;
		this.pintura = pintura;
	}
	
	public double rendaMedia(){
		double media = 0;
		for (Apartamento apartamentoDaVez : apartamentos){
			media += ( apartamentoDaVez.isVazio()) ? 0: apartamentoDaVez.rendaMedia();
		}
		return media/apartamentos.size();
	}
	
	
	public boolean addApartamento (Apartamento apartamento){
		if ((apartamentos == null ) || ( apartamentos.size() > 100)){
			return false;
		}else{
			apartamentos.add(apartamento);
			return true;
		}
	}
	
	public ArrayList<Apartamento> listaApartamentos(){
		if (!apartamentos.isEmpty()){
			return apartamentos;
		}else{
			return null;
		}
	}
	
	public int nApartamentos(){
		int total = 0;
		for ( Apartamento apartamentoDaVez : apartamentos){
			total++;
		}
		return total;
	}
	
	public int nApartamentosVazios(){
		int total = 0;
		for ( Apartamento apartamentoDaVez : apartamentos){
			total += (apartamentoDaVez.isVazio()) ? 1:0;
		}
		return total;
	}
	

}
