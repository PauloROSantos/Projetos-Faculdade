package ex1;

public class GerenciadorCidades {
	public static void main(String args[]){
		
		Estado sp = new Estado("São Paulo","SP");
		
		Cidade cp = new Cidade("Santo Anastacio", sp);
		
		
		sp.addCidade(cp);
		
		System.out.println(cp.getEstado().getSigla());
		
	}

}