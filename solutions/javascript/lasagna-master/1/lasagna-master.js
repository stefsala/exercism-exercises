/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */
export function cookingStatus (remaining){
  if (remaining) {
    return "Not done, please wait.";
  } else if (remaining == 0) {
    return "Lasagna is done.";
  } else {
    return "You forgot to set the timer.";
  }
}

export function preparationTime(layers, avgTime = 2) {
  return layers.length * avgTime;
}

export function quantities(layers) {
  let noodles = 0;
  let sauce = 0;
  for (let item in layers) {
    console.log(item);
    console.log(layers[item]);
    if (layers[item] == "noodles") {
      noodles++;
    } if (layers[item] == "sauce") {
      sauce++;
    }
  }
  return {noodles: noodles * 50, sauce: sauce * 0.2}
}

export function addSecretIngredient(friendsList, myList) {
  myList.push(friendsList.at(-1));
}

export function scaleRecipe(recipe, dose) {
  let new_recipe = {...recipe};
  for (let item in new_recipe) {
    new_recipe[item] = new_recipe[item] * (dose/2);
  }
  return new_recipe;
}
