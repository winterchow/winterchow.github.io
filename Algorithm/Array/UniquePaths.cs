// 二维数组[m, n], 从左上角[0, 0] 走到右下角[m, n] 的所有走法线路数。
public int UniquePaths(int m, int n){
    int[] dp = new dp[m + 1, n + 1];
    for(int i = 0; i < m; i++){
        dp[i, 0] = 1;
    }
    for(int i = 0; i < n; i++){
        dp[0, i] = 1;
    }
    for(int i = 1; i < m; i++){
        for(int j = 1; j < n; j++){
            dp[i, j] = dp[i, j - 1] + dp[i - 1, j];
        }
    }

    return dp[m - 1, n - 1];
}

// follow up if we have some obstacles in array[m, n]
public int UniquePaths(int[,] obstacleGrid){
    int m = obstacleGrid.GetLength(0);
    int n = obstacleGrid.GetLength(1);
    if(obstacleGrid[0, 0] == 1){
        return 0;
    }
    obstacleGrid[0, 0] = 1;
    for(int i = 1; i < m; i++){
        obstacleGrid[i, 0] = (obstacleGrid[i, 0] == 0 && obstacleGrid[i - 1, 0] == 1) ? 1 : 0;
    }
    for(int i = 1; i < n; i++){
        obstacleGrid[0, i] = (obstacleGrid[0, i] == 0 && obstacleGrid[0, i - 1] == 1) ? 1 : 0;
    }
    for(int i = 1; i < m; i++){
        for(int j = 1; j < n; j++){
            if(obstacleGrid[i, j] == 0){
                obstacleGrid[i, j] = obstacleGrid[i - 1, j] + obstacleGrid[i, j - 1];
            }
            else{
                obstacleGrid[i, j] = 0;
            }
        }
    }

    return obstacleGrid[m - 1, n - 1];
}