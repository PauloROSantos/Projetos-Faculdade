package condo;

import java.time.LocalDate;

public class Consultor {
	public static void main(String args[]){
		
		//Criando moradores
		Morador morador1 = new Morador("Joao","teste","teste2",5000.0,LocalDate.of(1990, 1, 15));
		Morador morador2 = new Morador("Joao","teste","teste2",0000.0,LocalDate.of(1991, 6, 1));
		
		//Criando Apartamentos
		Apartamento apartamento1 = new Apartamento(1,1,500);
		Apartamento apartamento2 = new Apartamento(1,2,500);
		Apartamento apartamento3 = new Apartamento(1,3,500);
		
		//Criando Predios
		Predio predio1 = new Predio(1,10,"belga");
		Predio predio2 = new Predio(2,10,"Zafira");
		
		//Criando Condominios
		Condominio condominio1 = new Condominio("Zeca","SP","HELP",01);
		
		//Adicionando morador ao apartamento
		apartamento1.addMorador(morador1);
		apartamento1.addMorador(morador2);
		
		//adicionando apartamento ao predio
		predio1.addApartamento(apartamento1);
		predio1.addApartamento(apartamento2);
		predio2.addApartamento(apartamento3);
		
		//adicionando predio ao condominio
		condominio1.addPredio(predio1);
		condominio1.addPredio(predio2);
		
		//Testes
		
		System.out.println(morador2.idade());
		System.out.println(morador1.getDataNasc());
		System.out.println(morador1.getRenda());
		
		System.out.println(apartamento1.rendaMedia());
		System.out.println(apartamento2.isVazio());
		
		System.out.println(apartamento1.listaMoradores());
		System.out.println();
		System.out.println(predio1.getAndares());
		System.out.println(predio1.getNumero());
		System.out.println(predio1.nApartamentos());
		System.out.println(predio1.nApartamentosVazios());
		System.out.println(predio1.rendaMedia());
		System.out.println(predio1.listaApartamentos());
		System.out.println();
		System.out.println();
		
		System.out.println(condominio1.rendaMedia());
		System.out.println(condominio1.nDeApartamentos());
		System.out.println(condominio1.nDeApartamentosVazios());
		System.out.println(condominio1.listaPredios());
		
		
		
	}

}
