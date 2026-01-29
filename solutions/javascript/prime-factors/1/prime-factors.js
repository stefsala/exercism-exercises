//
// This is only a SKELETON file for the 'Prime Factors' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const primeFactors = (number) => {
  let primeArray = new Array();
  let factor = 2;
  while (number >= factor) {
    if (number % factor == 0) {
      primeArray.push(factor);
      number = number / factor;
    } else {
      factor++;
    }
  }
  return primeArray;
};
