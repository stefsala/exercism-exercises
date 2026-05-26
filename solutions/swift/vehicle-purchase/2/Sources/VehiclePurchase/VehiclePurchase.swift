func canIBuy(vehicle: String, price: Double, monthlyBudget: Double) -> String {
  if ((monthlyBudget*12*5) >= price) {
    return "Yes! I'm getting a \(vehicle)"
  }
  if ((monthlyBudget * 12 * 5 * 110)/100 >= price) {
    return "I'll have to be frugal if I want a \(vehicle)"
  }
  return "Darn! No \(vehicle) for me"
}

func licenseType(numberOfWheels wheels: Int) -> String {
  if (wheels <= 3 && wheels > 1) {
    return "You will need a motorcycle license for your vehicle"
  }
  if (wheels == 4 || wheels == 6) {
    return "You will need an automobile license for your vehicle"
  }
  if wheels == 18 {
    return "You will need a commercial trucking license for your vehicle"
  }
  return "We do not issue licenses for those types of vehicles"
}

func calculateResellPrice(originalPrice: Int, yearsOld: Int) -> Int {
  if (yearsOld < 3) {
    return originalPrice * 80/100 //al posto di conversione int -> double -> int
  }
  if (yearsOld < 10) {
    return originalPrice * 70/100
  }
  return originalPrice * 50/100
}
