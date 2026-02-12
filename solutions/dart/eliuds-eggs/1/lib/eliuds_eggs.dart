class EggCounter {
  String binary_converter(int number) {
    if (number - 1 > 0)
      return (number % 2).toString() + binary_converter((number / 2).floor());
    else
      return number.toString();
  }

  int count(int number) {
    return '1'.allMatches(binary_converter(number)).length;
  }
}
