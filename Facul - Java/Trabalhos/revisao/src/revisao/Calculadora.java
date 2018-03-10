package revisao;

public class Calculadora {
	private double ultimoResultado;
	
	public double somar(double v1, double v2){
		ultimoResultado = v1+v2;
		return v1+v2;
	}
	public double subtrair(double v1, double v2){
		ultimoResultado = v1-v2;
		return v1-v2;
	}
	public double multiplicar ( double v1, double v2){
		ultimoResultado = v1*v2;
		return v1*v2;
	}
	public double dividir(double v1, double v2){
		ultimoResultado = v1/v2;
		return v1 / v2;
	}
}
