package ex3;

import java.util.ArrayList;

public class ContaTelefonica {
	private String telefone;
	private String periodo;
	private ArrayList<Ligacao> ligacoes=new ArrayList<Ligacao>();
	
	public ContaTelefonica(String periodo, String telefone){
		this.telefone = telefone;
		this.periodo = periodo;
	}
	
	public boolean addLigacao(Ligacao ligacao){
		return ligacoes.add(ligacao);
	}
	
	public double getValor(){
		double totalligacoes = 0;
		for ( Ligacao ligacaodavez: ligacoes){
			totalligacoes += ligacaodavez.getValor();
		}
		return totalligacoes;
	}
}