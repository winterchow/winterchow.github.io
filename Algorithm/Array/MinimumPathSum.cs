public int MinPathSum(int[,] grid) {
    int m = grid.GetLength(0);
    int n = grid.GetLength(1);
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            if(i == 0 && j != 0){
                grid[i, j] += grid[i, j - 1];
            }
            if(i != 0 && j == 0){
                grid[i, j] += grid[i - 1, j];
            }
            if(i != 0 && j != 0){
                grid[i, j] += Math.Min(grid[i, j - 1], grid[i - 1, j]);
            }
        }
    }

    return grid[m - 1, n - 1];
}