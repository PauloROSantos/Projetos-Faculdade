package lista;

import trabalho_mercado.Caixa;

public class No {
	private Caixa caixa;
	private No prox;
	
	public Caixa getElemento() {
		return caixa;
	}


	public void setElemento(Caixa caixa) {
		this.caixa = caixa;
	}


	public No getProx() {
		return prox;
	}


	public void setProx(No prox) {
		this.prox = prox;
	}

	
	public No (Caixa caixa){
		this.caixa = caixa;
		this.prox = null;
	}
	
}
