package revisao2;

public class Ex2 {
	static int[][] botoes = {{3,1,3},
					         {6,5,5}};
	
	
	
	static int[][] camisas = {{100,50},
					   		  {50,100},
					          {50,50}};

	static int total[][] = new int[botoes.length][camisas[0].length]; // Quantidade de linhas da primeira matriz
																		// Quantidade de colunas da segunda matriz
	
	public static int[][] totalBotoes(){
		
		 
		
		for (int i = 0 ; i < total.length ; i++){ // roda a coluna da matrizResultante
			for ( int j = 0; j < total[0].length ; j++){ // roda a linha da matrizResultante
				for ( int x = 0 ; x < botoes[0].length ; x++ ){ // esse for roda a quantidade de colunas da primeira matriz
					total[i][j] += botoes[i][x] * camisas[x][j]; //multiplica a primeira linha inteira da primeira matriz
																// pela primeira coluna inteira da segunda matriz
																// e guarda na posição [0][0] da matriz resultante
																// depois a primeira linha da primeira matriz
																// pela segunda coluna da segunda matriz
																// e guarda na posição [0][1] da matriz resultante
																
				}
			}
		}
		return total;
	}
	public static void imprimir(int[][] total2){
		for ( int i = 0; i < total2.length ; i++){
			for ( int j = 0; j < total2[0].length ; j++){
				System.out.printf(total2[i][j]+" ");
			}
			System.out.println();
		}
	}
	public static void main (String args[]){
		totalBotoes();
		imprimir(total);
	}
}
