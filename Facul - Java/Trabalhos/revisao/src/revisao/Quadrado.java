package revisao;

public class Quadrado {
	private int lado;
	
	public Quadrado(int lado){
		this.lado = lado;
	}
	public int area(int lado){
		return lado*lado;
	}
	public int perimetro(int lado){
		return lado*4;
	}
}
