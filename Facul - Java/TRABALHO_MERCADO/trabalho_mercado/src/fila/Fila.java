package fila;

import trabalho_mercado.Cliente;

public class Fila {
	private int inicio, fim;
	private int cont;
	private final int max = 10000;
	
	private Cliente[] v = new Cliente[max];
	
	
	public Fila(){
		inicio = 0;
		fim = 0;
		cont = 0;
	}
	
	public void inserir(Cliente valor){
		if(!isCheia()){
			v[fim] = valor;
			fim = (fim + 1) % max;
			cont++;
		}
	}
	
	public Cliente remover(){
		Cliente r = v[inicio];
		inicio = (inicio + 1)% max;
		cont--;
		return r;
	}
	
	public boolean isVazia(){
		return (cont == 0);
	}
	public boolean isCheia(){
		return ( cont == max);
	}
	
	public void esvaziar(){
		inicio = 0;
		fim = 0;
		cont = 0;
	}
}
