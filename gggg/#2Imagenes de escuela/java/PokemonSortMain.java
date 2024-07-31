import java.util.Scanner;

public class PokemonSortMain{
    public static void main(String args[]){
        Scanner lector1 = new Scanner(System.in);
        Scanner lector2 = new Scanner(System.in);
        Magia2 hadaMadrina = new Magia2();
        String texto="";
        int n;
        
        System.out.println("¿Cuántos pokemon atrapó Carlitos?");
        n = lector1.nextInt();
        lector1.nextLine();
        int[] noPoke = new int[n];
        hadaMadrina.setN(n);
        
        System.out.println("Escriba el Cp de cada pokemon");
        texto = lector1.nextLine();
        lector1.close();
        
        System.out.println("");
        noPoke = hadaMadrina.textoAArregloInv(texto);
        for(int i=0;i<noPoke.length;i++){
            System.out.print(noPoke[i]+" ");
        }
    }
}