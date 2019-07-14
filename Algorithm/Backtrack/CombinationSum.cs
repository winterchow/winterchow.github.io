// Get all combinations of an array with a target number.
// BackTrack.
public List<List<int>> CombinationSum(int[] candidates, int target){
    List<List<int>> result = new List<List<int>>();
    BackTrack(result, candidates, target, new List<int>(), 0);
    return result;
}
private void BackTrack(List<List<int>> res, int[] candidates, int target, List<int> selected, int index){
    if(target == 0){
        res.Add(new List<int>(selected));
        return;
    }
    if(target < 0){
        return;
    }
    for(int i = index; i < candidates.Length; i++){
        selected.Add(candidates[i]);
        BackTrack(res, candidates, target - candidates[i], selected, i + 1);
        selected.RemoveAt(selected.Count - 1);
    }
}