def is_armstrong_number(number):
    digits = [int(digit) for digit in str(number)]
    result = 0
    for single_digit in digits:
        result += pow(single_digit, len(digits))
    return True if number == result else False
        
    
