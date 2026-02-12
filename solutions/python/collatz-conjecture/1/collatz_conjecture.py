def steps(number):
    step_list = [number]
    if number > 0:
        while step_list[-1] != 1:
            step_list.append(core(step_list[-1]))
        return len(step_list) -1 
    else:
        raise ValueError("Only positive integers are allowed")

def core(number):
    if number > 0:
        if number % 2 == 0:
            return number/2
    return number*3+1