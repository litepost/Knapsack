using Knapsack;

Recursion recursion = new Recursion(profits: [60, 100, 120],
                                    weights: [10, 20, 30],
                                    capacity: 50);
int totalProfit = recursion.CalculateKnapsackAnswer();
Console.WriteLine($"(Recursion) Total Profit = {totalProfit}");

Memoization memoization = new Memoization(profits: [60, 100, 120], 
                                          weights: [10, 20, 30], 
                                          capacity: 50);
totalProfit = memoization.CalculateKnapsackAnswer();
Console.WriteLine($"(Memoization) Total Profit = {totalProfit}");
