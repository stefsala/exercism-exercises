//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = (inDate) => {
  let outDate = new Date();
  outDate.setTime(inDate.getTime() + 1000000000*1000);
  return outDate;
};
