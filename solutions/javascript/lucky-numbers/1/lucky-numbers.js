// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  //let num1 = arraySum(array1);
  //let num2 = arraySum(array2);
  let num1 = array1.join("");
  let num2 = array2.join("");
  return Number(num1) + Number(num2);
}
/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  if (String(value).length > 2) {
    return String(value)[0] == String(value)[String(value).length - 1] && luckyNumber(shrinkNumber(value));
  } else if (String(value).length == 2) {
    return String(value)[0] == String(value)[String(value).length - 1];
  } else { return true; }
  return false;
}

function shrinkNumber(value) {
  value = String(value);
  console.log(value + " | "+ value.slice(1,value.length - 1))
  return Number(value.slice(1,value.length - 1));
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if (!Boolean(input)){
    return "Required field";
  }
  if (input && input > 0) {
    return "";
  } else {
    return "Must be a number besides 0";
  }
}
