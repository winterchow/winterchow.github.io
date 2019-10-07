public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
    List<IList<int>> res = new List<IList<int>>();
    Array.Sort(candidates);
    BackTrack(candidates, res, new List<int>(), target, 0);
    return res; 
}
public void BackTrack(int[] candidates, List<IList<int>> res, List<int> element, int target, int index){
    if(target == 0){
        res.Add(new List<int>(element));
        return;
    }
    if(target < 0){
        return;
    }
    for(int i = index; i < candidates.Length; i++){
        if(i > index && candidates[i] == candidates[i - 1]){
            continue;
        }
        element.Add(candidates[i]);
        BackTrack(candidates, res, element, target - candidates[i], i + 1);
        element.RemoveAt(element.Count() - 1);
    }
}