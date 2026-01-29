//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, number) => {
  let result = number + "th";
  switch (number.toString()[number.toString().length - 1]) {
    case "2": number != 12 && number.toString()[number.toString().length - 2] != 1 ? result = number + "nd" : "12th";
      break;
    case "3": number != 13 && number.toString()[number.toString().length - 2] != 1 ? result = number + "rd" : "13th";
      break;
    case "1": number != 11 && number.toString()[number.toString().length - 2] != 1 ? result = number + "st" : "11th";
      break;
    }
  return name + ", you are the " + result + " customer we serve today. Thank you!";
};
