package trabalho_mercado;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Random;

//INTEGRANTES
//PAULO ROBERTO RA: 1600356
//LUIS GUSTAVO RA: 1600140
//BRUNO RA: 1600244
//RICARDO ROSSETI RA: 1600432

public class Simulador {
	private double probabilidade;
	private Queue<Cliente> fila = new LinkedList<Cliente>();   //criando fila de clientes
	private ArrayList<Caixa> listaDeCaixa = new ArrayList<Caixa>();  //criando lista de caixas
	Random gerador = new Random();
	
	//====================CONSTRUTOR DO SIMULADOR==============================
	public Simulador(double probabilidade) {
		this.probabilidade = probabilidade;
		this.fila = new LinkedList<Cliente>();;
		this.listaDeCaixa = new ArrayList<Caixa>();
		
	}
	
	//=====================GERAR RELATORIO DA SIMULA��O=========================
	public void gerarRelatorio() throws IOException{
		String nomeArquivo = (Double.toString(probabilidade)+"prob.txt");
		FileWriter arquivo = new FileWriter(nomeArquivo, false);
		for ( int caixas = 5 ; caixas < 21 ; caixas++){
			abrirCaixas(caixas);
			int tempo = 120;
			boolean teste = true;
		while((tempo > 0) && (teste)){              // 2 horas de funcionamento
			for(Caixa caixaOcupado : listaDeCaixa){
				if(caixaOcupado.getTempoDeAtendimento() == 0){
					caixaOcupado.livre();
				}else{
					caixaOcupado.diminuiTempoAtendimento();
				}
			}
			if (gerador.nextInt(10) <= probabilidade*10){ //Adicionando cliente de acordo com a probabilidade
				fila.add(new Cliente()); 				// novo cliente
				}
			if(!fila.isEmpty()){             //Enquanto a fila n�o estiver vazia
				for (Caixa caixaLivre : listaDeCaixa){		//rotaciona a lista de caixas
					while ((caixaLivre.getStatus()) && (!fila.isEmpty())){			//procura um caixa livre e um cliente na fila
						if(!fila.isEmpty()){
							caixaLivre.atendimento(fila.remove());  //direciona o primeiro cliente para atendimento
						}
					}
			}
				for(int i = 0; i < fila.size(); i++){
					Cliente adicionaTempo = fila.remove();	
					adicionaTempo.adicionaTempoDeEspera();
					fila.add(adicionaTempo);
				}
			}

			//for(Caixa caixaOcupado : listaDeCaixa){
				//System.out.println("tempo de atendimento: "+ caixaOcupado.getTempoDeAtendimento());
			//}
			for(int i = 0; i < fila.size();i++){
				Cliente verificaTempo = fila.remove();
				//System.out.println(verificaTempo.getTempoDeEspera());
					if(verificaTempo.getTempoDeEspera() > 10){
						
						teste = false;
						//System.out.println(verificaTempo.getTempoDeEspera());
					}
				fila.add(verificaTempo);
				
			}
			
			tempo--;
			//System.out.println("tempo: "+tempo);
		
			
		}
		System.out.println("------------------------------------");
		if(!teste){
			System.out.println("TEMPO DE FILA EXCEDIDO!");
			relatorioCliente();
			System.out.println("Proximo cliente excedeu o limite de 10 minutos na fila.");
			System.out.println();
		}
		relatorioCaixa();
		System.out.println("------------------------------------");
		System.out.println();
		gerarArquivoRelatorio(teste,arquivo);
		fila.clear();
		listaDeCaixa.clear();
		}
		arquivo.close();
		}
	//==================ABRIR CAIXAS===============================
	public void abrirCaixas(int numeroDeCaixas){   //abrindo os caixas de acordo com o parametro passado para simula��o
		for (int i = 0 ; i < numeroDeCaixas ; i++){
			listaDeCaixa.add(new Caixa());
		}
	}
	
	//==================RELATORIO DE CLIENTES=======================
	private void relatorioCliente() {
		int totalDeClienteNaFila = fila.size();
		System.out.println("Numero de clientes na fila: "+ totalDeClienteNaFila);
	}
	
	//==================RELATORIO DE CAIXAS==========================
	private void relatorioCaixa() {
		
		int cont = 0;
		double total = 0;
		int totalCliente = 0;
		int maiorTempoDeEspera = 0;
		for(Caixa caixaOcupado : listaDeCaixa){
			totalCliente += caixaOcupado.getTotalDeClientesAtendidos();
			total += caixaOcupado.getValorCaixa();
			cont++;
			if (caixaOcupado.getMaiorTempoDeEspera() > maiorTempoDeEspera){
				maiorTempoDeEspera = caixaOcupado.getMaiorTempoDeEspera();
			}
		}
		System.out.println("Numero de caixas abertos: "+ cont);
		System.out.printf("Total arrecadado R$: %.2f %n",total);
		System.out.println("Total gasto com os caixas R$: "+(cont*300));
		System.out.printf("Lucro total obtido R$: %.2f %n",(total-(cont*300)));
		System.out.println(totalCliente+" clientes atendidos.");
		System.out.println("Maior tempo de espera de cliente atendido: "+maiorTempoDeEspera+" minutos.");
	}
	
	//====================GERADOR DE ARQUIVO==========================
	private void gerarArquivoRelatorio(boolean teste, FileWriter arquivo2) throws IOException {
		
		PrintWriter gravarArquivo = new PrintWriter(arquivo2);
		
		int cont = 0;
		double total = 0;
		int totalCliente = 0;
		int maiorTempoDeEspera = 0;
		
		gravarArquivo.println("------------------------------------");
		if(!teste){
			int totalDeClienteNaFila = fila.size();
			gravarArquivo.println("TEMPO DE FILA EXCEDIDO!");
			gravarArquivo.println("Numero de clientes na fila: "+ totalDeClienteNaFila);
			gravarArquivo.println("Proximo cliente excedeu o limite de 10 minutos na fila.");
			gravarArquivo.println();
		}
		
		for(Caixa caixaOcupado : listaDeCaixa){
			totalCliente += caixaOcupado.getTotalDeClientesAtendidos();
			total += caixaOcupado.getValorCaixa();
			cont++;
			if (caixaOcupado.getMaiorTempoDeEspera() > maiorTempoDeEspera){
				maiorTempoDeEspera = caixaOcupado.getMaiorTempoDeEspera();
			}
		}
		gravarArquivo.println("Numero de caixas abertos: "+ cont);
		gravarArquivo.printf("Total arrecadado R$: %.2f %n",total);
		gravarArquivo.println("Total gasto com os caixas R$: "+(cont*300));
		gravarArquivo.printf("Lucro total obtido R$: %.2f %n",(total-(cont*300)));
		gravarArquivo.println(totalCliente+" clientes atendidos.");
		gravarArquivo.println("Maior tempo de espera de cliente atendido: "+maiorTempoDeEspera+" minutos.");
		gravarArquivo.println("------------------------------------");
		gravarArquivo.println();

		
	}
}
