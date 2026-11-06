using SpaceAcademy;

int actual = FuelCalculator.Calculate(3, 4);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
actual = FuelCalculator.Calculate(0, 4);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
actual = FuelCalculator.Calculate(3, 0);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
actual = FuelCalculator.Calculate(1, 1);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
actual = FuelCalculator.Calculate(20, 30);
Console.WriteLine($"Forventet: 24. Faktisk: {actual}");
// TODO: Kjør de andre eksemplene og noter resultatene.
