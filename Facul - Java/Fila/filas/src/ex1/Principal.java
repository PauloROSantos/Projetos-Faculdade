package ex1;

public class Principal {
	public static void main(String arg[]){
			Fila fila = new Fila();
			
			fila.inserir(10);
			fila.inserir(20);
			fila.inserir(30);
			
			System.out.println(fila.remover());
			System.out.println(fila.remover());
			System.out.println(fila.remover());
			
			System.out.println(fila.isVazia());
			System.out.println(fila.isFull());
	}
}
