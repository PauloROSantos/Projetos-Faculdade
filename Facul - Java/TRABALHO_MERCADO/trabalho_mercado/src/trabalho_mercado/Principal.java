package trabalho_mercado;

import java.io.IOException;

//INTEGRANTES
//PAULO ROBERTO RA: 1600356
//LUIS GUSTAVO RA: 1600140
//BRUNO RA: 1600244
//RICARDO ROSSETI RA: 1600432

public class Principal {
	public static void main(String args[]) throws IOException{
		
		
		Simulador _8Horas = new Simulador(0.3);
		_8Horas.gerarRelatorio();
		
		Simulador _10Horas = new Simulador(0.4);
		_10Horas.gerarRelatorio();
		
		Simulador _12Horas = new Simulador(0.5);
		_12Horas.gerarRelatorio();
		
		Simulador _14Horas = new Simulador(0.7);
		_14Horas.gerarRelatorio();
		
		Simulador _16Horas = new Simulador(0.9);
		_16Horas.gerarRelatorio();
		
		Simulador _18Horas = new Simulador(0.8);
		_18Horas.gerarRelatorio();
		
		Simulador _20Horas = new Simulador(0.6);
		_20Horas.gerarRelatorio();

		
		
	
		
	}
}
