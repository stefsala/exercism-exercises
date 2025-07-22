def equilateral(sides):
    if all(item > 0 for item in sides) and isTriangle(sides):
        return True if (sides[0] == sides[1] and sides[1] == sides[2]) else False
    return False


def isosceles(sides):
    if all(item > 0 for item in sides) and isTriangle(sides):
        return True if sides[0] == sides[1] or sides[1] == sides[2] or sides[0] == sides[2] else False
    return False

def scalene(sides):
    if all(item > 0 for item in sides) and isTriangle(sides):
        return True if not equilateral(sides) and not isosceles(sides) else False
    return False

def isTriangle(sides):
    return sides[0] + sides[1] >= sides[2] and sides[1] + sides[2] >= sides[0] and sides[0] + sides[2] >= sides[1]