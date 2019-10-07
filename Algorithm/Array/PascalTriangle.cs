//     1
//    1 1
//   1 2 1
//  1 3 3 1
// 1 4 6 4 1
public IList<IList<int>> Generate(int numRows){
    List<IList<int>> res = new List<IList<int>>();
    if(numRows == 0){
        return res;
    }
    res.Add(new List<int>(){1});
    if(numRows == 1){
        return res;
    }
    for(int i = 1; i < numRows; i++){
        int[] row = new int[i + 1];
        row[0] = 1;
        row[i] = 1;
        for(int j = 1; j < i; j++){
            row[j] = res[i - 1][j - 1] + res[i - 1][j];
        }

        res.Add(row);
    }

    return res;
}

// Follow up, get k level row. start index from 0
public IList<int> GetRow(int rowIndex){
    int[] res = new int[rowIndex + 1];
    res[0] = 1;
    for(int i = 1; i < rowIndex + 1; i++){
        for(int j = i; j >= 1; j--){
            res[j] += res[j - 1];
        }
    }

    return res;
}