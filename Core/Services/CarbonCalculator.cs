using Carbon.Core.Interfaces;
using Carbon.Core.Entities;


namespace Carbon.Core.Services;


/// <summary>
/// Simple rule-based calculator. Replace / extend with data-driven factors.
/// Values are illustrative only.
/// </summary>
public class CarbonCalculator : ICarbonCalculator
{
public double Calculate(ActivityCategory category, double quantity, string? unit = null, string? subtype = null)
{
// Return kg CO2e
switch (category)
{
case ActivityCategory.Transportation:
// assume quantity in km and using an average car factor 0.192 kg/km (approx)
if (unit?.ToLower() == "km" || unit == null) return quantity * 0.192;
// if miles
if (unit.ToLower() == "mi") return quantity * 0.308; // 1 mi ~ 1.609 km
break;
case ActivityCategory.HomeEnergy:
// assume kWh and avg grid factor 0.4 kgCO2/kWh
if (unit?.ToLower() == "kwh" || unit == null) return quantity * 0.4;
break;
case ActivityCategory.Food:
// assume kg of food; subtype could be "beef" (60 kgCO2/kg) or "veggies" (2 kgCO2/kg)
if (!string.IsNullOrEmpty(subtype))
{
if (subtype.ToLower().Contains("beef")) return quantity * 60.0;
if (subtype.ToLower().Contains("lamb")) return quantity * 24.0;
if (subtype.ToLower().Contains("poultry")) return quantity * 6.9;
if (subtype.ToLower().Contains("veggie")) return quantity * 2.0;
}
// default average food
return quantity * 5.0;
case ActivityCategory.Waste:
// assume kg waste, 1.9 kgCO2/kg average
return quantity * 1.9;
case ActivityCategory.Purchases:
// assume monetary value in local currency; e.g., per $100 = 50kgCO2
// if unit is "money" and quantity is in units of currency
if (unit?.ToLower() == "money") return (quantity / 100.0) * 50.0;
// fallback assume kg product weight
return quantity * 3.0;
case ActivityCategory.Services:
// services: convert money to factor
if (unit?.ToLower() == "money") return (quantity / 100.0) * 30.0;
break;
}
return 0.0;
}
}