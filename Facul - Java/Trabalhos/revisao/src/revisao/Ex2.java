package revisao;

import java.util.ArrayList;

public class Ex2 extends Thread {
	static int[] vetor = {1,2,3,4,5};
	
	public static void main (String args[]){
		Ex2 teste = new Ex2();
		teste.start();
	}
	public void run(){
		System.out.println("funciona");
	}
}

