package condo;


import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.Period;


public class Morador {
	
	private String nome;
	private String cic;
	private String rg;
	private double renda;
	private LocalDate dataNascimento;
	
	public void setDataNasc(LocalDate dataNasc) {
		this.dataNascimento = dataNasc;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCic() {
		return cic;
	}

	public void setCic(String cic) {
		this.cic = cic;
	}

	public String getRg() {
		return rg;
	}

	public void setRg(String rg) {
		this.rg = rg;
	}

	public double getRenda() {
		return renda;
	}

	public void setRenda(double renda) {
		this.renda = renda;
	}
	
	public LocalDate getDataNasc() {
		return dataNascimento;
	}
	

	public Morador(String nome, String cic, String rg, double renda, LocalDate dataNasc ){
		this.nome = nome;
		this.cic = cic;
		this.rg = rg;
		this.renda = renda;
		this.dataNascimento = dataNasc;
	}
	
	public int idade(){
		LocalDate nasc = dataNascimento;
		LocalDate atual = LocalDate.now();
		Period periodo =  Period.between(nasc, atual);
		return periodo.getYears();
	}
	
}
