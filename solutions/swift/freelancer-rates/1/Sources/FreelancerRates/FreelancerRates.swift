func dailyRateFrom(hourlyRate: Int) -> Double {
  return Double(hourlyRate * 8).rounded()
}

func monthlyRateFrom(hourlyRate: Int, withDiscount discount: Double) -> Double {
  return Double((dailyRateFrom(hourlyRate: hourlyRate) * 22.0) * (1 - discount/100)).rounded()
}

func workdaysIn(budget: Double, hourlyRate: Int, withDiscount discount: Double) -> Double {
  return (budget / (Double(hourlyRate) * 8.0 * (1 - discount/100))).rounded(.down)
}
