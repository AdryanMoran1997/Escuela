def binSearch(X, arr, n):
    int: low
    int: high
    int: mid

    low = 0
    high = n - 1
    while low <= high:
        mid = (low + high) // 2
        if X < arr[mid]:
            high = mid - 1
            mid = mid - 1
        elif X > arr[mid]:
            low = mid + 1
        else:
            return mid
    return -1
