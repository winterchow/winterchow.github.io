// 1 2 3      1 4 7      7 4 1
// 4 5 6  ->  2 5 8  ->  8 5 2
// 7 8 9      3 6 9      9 6 3
public void Rotate(int[][] matrix) {
    int width = matrix.GetLength(0);
    for(int i = 0; i < width; i++){
        for(int j = i + 1; j < width; j++){
            int temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }
    for(int i = 0; i < width; i++){
        Array.Reverse(matrix[i]);
    }
}