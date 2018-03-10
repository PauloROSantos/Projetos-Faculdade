package ex3;

public class Ligacao {
	private String telefoneDestino;
	private double valorMinuto = 1;
	private int tempoDuracao;
	

	public Ligacao(String telefoneDestino, int tempoDuracao){
		this.telefoneDestino = telefoneDestino;
		this.tempoDuracao = tempoDuracao;
	}
	
	public double getValor(){
		return tempoDuracao * valorMinuto;
	}
	
	public String getTelefoneDestino() {
		return telefoneDestino;
	}

	public void setTelefoneDestino(String telefoneDestino) {
		this.telefoneDestino = telefoneDestino;
	}
	public int getTempoDuracao() {
		return tempoDuracao;
	}

	public void setTempoDuracao(int tempoDuracao) {
		this.tempoDuracao = tempoDuracao;
	}

}
