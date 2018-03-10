package trabalho_mercado;

import java.util.Random;

//INTEGRANTES
//PAULO ROBERTO RA: 1600356
//LUIS GUSTAVO RA: 1600140
//BRUNO RA: 1600244
//RICARDO ROSSETI RA: 1600432

public class Produto {
	Random gerador = new Random();
	
	private double valor;

	public Produto() {
		this.valor = gerador.nextDouble() * 45 + 5.00;
	}

	public double getValor() {
		return valor;
	}

	public void setValor(double valor) {
		this.valor = valor;
	}
	
	
	
	
}
