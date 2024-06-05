//Console.WriteLine(UnitConverter.MilimeterToCentimetre(100));
//Console.WriteLine(UnitConverter.MilimeterToDecimeter(120));
//Console.WriteLine(UnitConverter.MilimeterToMetre(1200));
//Console.WriteLine(UnitConverter.MilimeterToKilometer(12000));

//Console.WriteLine(UnitConverter.CentimetreToMilimeter(15));
//Console.WriteLine(UnitConverter.CentimetreToDecimeter(15));
//Console.WriteLine(UnitConverter.CentimetreToMetre(15));
//Console.WriteLine(UnitConverter.CentimetreToKilometer(1500000));

//Console.WriteLine(UnitConverter.DecimeterToMilimeter(12));
//Console.WriteLine(UnitConverter.DecimeterToKilometer(120000));
//Console.WriteLine(UnitConverter.MetreToMilimeter(12));
//Console.WriteLine(UnitConverter.MetreToKilometer(12000));

//Console.WriteLine(UnitConverter.KilometerToMilimeter (0.001));

//Console.WriteLine(UnitConverter.MilligramsToKilogram (12000000));
//Console.WriteLine(UnitConverter.MilligramsToGram(12000));


//Console.WriteLine(MathHelper.Exponentiation(2, 4));
//Console.WriteLine(MathHelper.Factorial(5));
//Console.WriteLine(MathHelper.RootCalculations(625,2));
//Console.WriteLine(MathHelper.RootCalculations(27,3));

//string LatestVersion = "7.0.1";
//AppVersion.IsUpdateAvailable(LatestVersion);

//Car car = new Car("lada", 90, 5);

//Triangle triangle = new Triangle(10, 5);
//Console.WriteLine(triangle.GetArea());
//Circle cicrle = new Circle(20);
//Console.WriteLine(cicrle.GetArea());

ChekingAccount check = new ChekingAccount(1000, "Biba", "Boba", 1500);
check.Overdraft(5000);
check.Overdraft(1000);
SavingsAccount save = new SavingsAccount("Biba", "Boba", 1000, 15);
save.InterestAccrual();