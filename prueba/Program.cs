string customerName = "Ms. Barros";
string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.Clear();

string presentationMessage = (string.Format("Dear {0}", customerName)) + "\n";
presentationMessage += string.Format("As a customer of our {0} offering we are excited to tell you about a new financial product that would dramatically increase your return.", currentProduct) + "\n";
presentationMessage += string.Format("Currently, you own {0:N0} shares at a return of {1:P2}.",currentShares, currentReturn) + "\n";
presentationMessage += string.Format("Our new product, {0} offers a return of {1:P2}.  Given your current volume, your potential profit would be {2:C2}.",newProduct, newReturn, newProfit) + "\n";

Console.WriteLine(presentationMessage);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = (currentProduct.PadRight(20) + currentReturn.ToString("P2").PadRight(8) + currentProfit.ToString("C2").PadLeft(15)) + "\n"; 
comparisonMessage += ($"{newProduct.PadRight(20)}{newReturn.ToString("P2").PadRight(8)}{newProfit.ToString("C2").PadLeft(15)} \n");  
comparisonMessage += ($"{newProduct.PadRight(20)}{string.Format("{0:P}",newReturn).PadRight(10)}");
Console.WriteLine(comparisonMessage);