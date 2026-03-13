def square_root(number):
    low = 0
    high = number
    mid = number // 2
    while mid**2 != number:
        if mid**2 > number:
            high = mid
        else:
            low = mid + 1
        mid = (low + high) // 2
        
    return mid
        