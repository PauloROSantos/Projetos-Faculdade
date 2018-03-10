package pilha;

public class Pilha {
	private int quantidade;
	private int topo;
	
	private int[] pilha;
	
	public Pilha(int quantidade){
		this.quantidade = quantidade;
		pilha = new int[quantidade];
		topo = 0;
	}
	
	public int pop(){
		int r = 0;
		if (!isVazia()){
			topo--;
			r =pilha[topo];
		}else{
			System.out.println("fila vazia");
		}
		return r;
		
	}
	
	public boolean push(int valor){
		if (!isCheia()){
			return false;			
		}else{
			pilha[topo] = valor;
			topo++;
			return true;
		}
		
	}
	
	public boolean isVazia(){
		return ( topo == 0);
	}
	public boolean isCheia(){
		return (topo == quantidade);
		
	}
	public void esvaziar(){
		topo = 0;
	}
	public int tamanho(){
		return topo;
	}
	
}
