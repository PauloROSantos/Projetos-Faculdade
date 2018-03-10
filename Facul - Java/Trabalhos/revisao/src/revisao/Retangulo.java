package revisao;

public class Retangulo {
	private int base;
	private int altura;
	
	public Retangulo(int base, int altura){
		this.base = base;
		this.altura = altura;
	}
	
	public int area(int base, int altura){
		return base*altura;
	}
	public int perimetro(int base, int altura){
		return 2*(base + altura);
	}

}
