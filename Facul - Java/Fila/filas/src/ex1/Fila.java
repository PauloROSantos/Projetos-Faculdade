package ex1;

public class Fila {
	private int inicio, fim;
	private int[] fila;
	private final int max = 100;
	private int cont;
	
	public Fila(){
		inicio = 0;
		fim = 0;
		cont = 0;
		fila = new int[max];
	}
	
	public void inserir(int i) {
		fila[fim] = i;
		fim = (fim + 1) % max;
		cont++;
		
	}

	public int remover() {
		int r = fila[inicio];
		inicio = (inicio +1) % max;
		cont--;
		return r;
		
	}
	
	public void esvaziar(){
		inicio = 0;
		fim = 0;
		cont = 0;
	}
	
	public boolean isVazia(){
		return (cont == 0);
	}
	
	public boolean isFull(){
		return (cont == max);
	}

}
