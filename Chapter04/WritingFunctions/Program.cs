//TimesTable(7);

ConfigureConsole();

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");
// Alternatively, call function in the interpolated string.
// WriteLine($"You must pay {CalculateTax(amount: 149, twoLetterRegionCode: "FR"):C} in tax.");