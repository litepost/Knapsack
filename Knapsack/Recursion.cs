namespace Knapsack;

public class Recursion(List<int> profits, List<int> weights, int capacity)
{
    readonly List<int> profits = profits;
    readonly List<int> weights = weights;
    readonly int capacity = capacity;

    // Time complexity = O(2^N)
    // Space complexity = O(N)
    public int CalculateKnapsackAnswer() {
        return Knapsack(capacity, profits.Count);
    }

    private int Knapsack(int W, int index) {
        if (index == 0 || W == 0)
            return 0;

        if (weights[index - 1] > W) {
            return Knapsack(W, index - 1);
        }
        else {
            return Math.Max(profits[index-1] + Knapsack(W - weights[index-1], index-1), 
                    Knapsack(W, index-1));
        }
    }
}
