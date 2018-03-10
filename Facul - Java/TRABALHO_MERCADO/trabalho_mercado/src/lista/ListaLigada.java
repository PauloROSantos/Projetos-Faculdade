package lista;

import trabalho_mercado.Caixa;
import trabalho_mercado.Cliente;

public class ListaLigada {
	private No inicio;
	
	public ListaLigada(){
		inicio = null;
	}
	
	public void adicionar(Caixa caixa){
		No novo = new No(caixa);
		novo.setProx(inicio);
		inicio = novo;
	}
	public void remover(){
		if (!vazia())
			inicio = inicio.getProx();
	}
	
	public boolean vazia(){
		return (inicio == null);
	}
	
	public void mostrar(){
		if(!vazia()){
			No p = inicio;
		
			while (p != null){
				System.out.println(p.getElemento());
				p = p.getProx();
			}
		}else{
			System.out.println("lista vazia");
		}
		}
	
	public void proximoCaixa(){
		
	}

	public void atender(Cliente cliente) {
		No p = inicio;
		Caixa caixa = p.getElemento();
		
		while( p != null){
			if ( caixa.getStatus() != false){
				caixa.atendimento(cliente);
			}else{
				p = p.getProx();
				caixa = p.getElemento();
			}
		}
		
	}
	
}
