package ex3;

public class GerenciadorConta {
	public static void main(String args[]){
		Ligacao ligacao = new Ligacao("190",40);
		Ligacao ligacao2 = new Ligacao("0900-tolouco",50);
		Ligacao ligacao3 = new Ligacao("0800-MINHAROLA",100);
		
		ContaTelefonica ct = new ContaTelefonica("99501-2152","agosto");
		ContaTelefonica ct2 = new ContaTelefonica("Bruno-0DELICIA","dezembro");
		
		ct2.addLigacao(ligacao);
		
		ct.addLigacao(ligacao);
		ct.addLigacao(ligacao2);
		ct.addLigacao(ligacao3);
		
		System.out.print(ct.getValor());
		System.out.println(ct2.getValor());
	}

}