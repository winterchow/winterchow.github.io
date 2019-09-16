// We have RMB with a face value of 1, 5, 10, 20, 50, 100.
// How many combinations just enough to spend all money(10000 RMB).

public long BuyFruit(int[] faceValues, int totalMoney){
    long[] dp = new long[totalMoney + 1];
    for(int i = 0; i < totalMoney.Length; i++){
        dp[i] = 1;
    }
    foreach(var faceValue in faceValues){
        for(int i = faceValue; i <= totalMoney; i++){
            dp[i] += dp[i - faceValue];
        }
    }

    return dp[totalMoney];
}