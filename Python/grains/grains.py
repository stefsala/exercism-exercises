def square(number):
    if (number > 0) and (number < 65):
        return pow (2, number -1)
    else:
        raise ValueError("square must be between 1 and 64")


def total():
    result = 0
    for x in range(1,65):
        result += pow(2,x-1)
    return result
