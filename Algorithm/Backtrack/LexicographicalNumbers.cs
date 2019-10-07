// 1 ~ n  1 ~ 13
// 1 2 3 4 5 6 7 8 9 10 11 12 13
// return 1 10 11 12 13 2 3 4 5 6 7 8 9
public IList<int> LexicalOrder(int n) {
    List<int> res = new List<int>();
    for(int i = 1; i < 10; i++){
        BackTrack(res, n, i);
    }
    return res;
}
public void BackTrack(List<int> res, int n, int temp){
    if(temp > n){
        return;
    }
    else{
        res.Add(temp);
        for(int i = 0; i < 10; i++){
            if(temp * 10 + i > n){
                return;
            }
            BackTrack(res, n, temp * 10 + i);
        }
    }
}