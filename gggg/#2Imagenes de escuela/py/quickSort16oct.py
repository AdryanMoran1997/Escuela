
def quickSort(arr,inicio_idx,fin_idx):
    if inicio_idx >= fin_idx:
        return

    
    pivote_idx = inicio_idx
    compara = fin_idx

    while compara != pivote_idx:
        if ord[compara] > ord[pivote_idx]:
            if arr[compara] <= arr[pivote_idx]:
                #intercambio
                temp = arr[pivote_idx]
                arr[pivote_idx] = arr[compara]
                arr[compara] = temp

                #intercambio indice
                temp_idx = pivote_idx
                pivote_idx = compara
                copara = temp_idx

        else:
             if ord(arr[compara]) > ord(arr[pivote_idx]):
                #intercambio
                temp = arr[pivote_idx]
                arr[pivote_idx] = arr[compara]
                arr[compara] = temp

                #intercambio indice
                temp_idx = pivote_idx
                pivote_idx = compara
                copara = temp_idx

        if compara > pivote_idx:
            compara -= 1
        else:
            compara += 1
            

    quickSort(arr,inicio_idx,pivote_idx-1)
    quickSort(arr,pivote_idx+1,fin_idx)


arr = [1,4,34,54,6,7,56,32,12,25,9]
inicio = 0
print(arr)
quickSort(arr, inicio, len(arr)-1)
print(arr)







