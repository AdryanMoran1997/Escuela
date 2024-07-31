public class Magia2{
    String texto;
    int n,suma,noProb;
    Sorts orden = new Sorts();
    
    public Magia2(){
        texto="";
        n=0;
        suma=0;
        noProb=0;
    }
    
    public void setN(int num){
        n = num;
    }
    public int longitud(){
        return n;
    }
    
    public int[] textoAArreglo(String textoIngreso){
        int[] arreglo = new int[n];
        texto=textoIngreso;
        String[] arr=texto.split(" ");
        for(int i=0;i<n;i++){
            arreglo[i]=Integer.parseInt(arr[i]);
        }
        arreglo=orden.insertionSort(arreglo);
        return arreglo;
    }
    public int[] textoAArregloInv(String textoIngreso){
        int[] arreglo = new int[n];
        texto=textoIngreso;
        String[] arr=texto.split(" ");
        for(int i=0;i<n;i++){
            arreglo[i]=Integer.parseInt(arr[i]);
        }
        arreglo=orden.invertedInsertionSort(arreglo);
        return arreglo;
    }
}