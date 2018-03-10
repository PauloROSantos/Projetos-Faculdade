package condo;

import java.util.ArrayList;

public class Apartamento {
	
	private int andar;
	private int numero;
	private double aluguel;
	private ArrayList<Morador> moradores = new ArrayList<Morador>();

	
	public int getAndar() {
		return andar;
	}
	public void setAndar(int andar) {
		this.andar = andar;
	}
	public int getNumero() {
		return numero;
	}
	public void setNumero(int numero) {
		this.numero = numero;
	}
	public double getAluguel() {
		return aluguel;
	}
	public void setAluguel(double aluguel) {
		this.aluguel = aluguel;
	}

	
	public Apartamento(int andar, int numero, double aluguel) {
		this.andar = andar;
		this.numero = numero;
		this.aluguel = aluguel;
	}
	
	public double rendaMedia(){
		double media = 0;
		for (Morador moradorDaVez : moradores){
			media += moradorDaVez.getRenda();
		}
		return media/moradores.size();
	}
	
	public boolean addMorador(Morador morador){
		if ((morador == null ) || ( moradores.size() > 100)){
			return false;
		}else{
			moradores.add(morador);
			return true;
		}
	}
	
	
	public ArrayList<Morador> listaMoradores(){
		if (!isVazio()){
			return moradores;
		}else{
			return null;
		}
	}
	
	public boolean isVazio(){
		if ( moradores.isEmpty()){
			return true;
		}else{
			return false;
		}
	}
	
}
