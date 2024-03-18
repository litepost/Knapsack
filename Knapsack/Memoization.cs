namespace Knapsack;

public class Memoization(List<int> profits, List<int> weights, int capacity)
{
    readonly List<int> profits = profits;
    readonly List<int> weights = weights;
    readonly int capacity = capacity;

    public int CalculateKnapsackAnswer() {
        List<List<int>> dp = [];

        for (int n = 0; n < profits.Count + 1; n++) {
            List<int> tmpW = [];
            for (int w = 0; w < capacity + 1; w++) {
                tmpW.Add(-1);
            }
            dp.Add(tmpW);
        }

        return Knapsack(capacity, profits.Count, dp);
    }

    private int Knapsack(int W, int index, List<List<int>> dp) {
        if (index == 0 || W == 0) return 0;
        if (dp[index][W] != -1) return dp[index][W];
        if (weights[index-1] > W) {
            return dp[index][W] = Knapsack(W, index-1, dp);
        }
        else {
            return dp[index][W] = Math.Max(profits[index-1] + Knapsack(W-weights[index-1], index-1, dp), 
                                          Knapsack(W, index-1, dp));
        }
    }
}
