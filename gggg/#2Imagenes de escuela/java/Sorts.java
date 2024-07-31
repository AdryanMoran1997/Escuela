public class Sorts{
    public Sorts(){
    }
    
    public int[] insertionSort(int[] arr){
        int i,j,key,temp;
        for(i=1;i<arr.length;i++){
            key=arr[i];
            j=i-1;
            while(j>=0 && key<arr[j]){
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                j--;
            }
        }
        return arr;
    }
    
    public int[] invertedInsertionSort(int[] arr){
        int i,j,key,temp;
        for(i=1;i<arr.length;i++){
            key=arr[i];
            j=i-1;
            while(j>=0 && key>arr[j]){
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                j--;
            }
        }
        return arr;
    }
}