using Carbon.Core.Entities;


namespace Carbon.Core.Interfaces;


public interface ICarbonCalculator
{
/// <summary>
/// Calculate emissions (kg CO2e) for a given category and quantity.
/// </summary>
double Calculate(ActivityCategory category, double quantity, string? unit = null, string? subtype = null);
}