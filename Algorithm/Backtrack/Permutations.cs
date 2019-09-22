public IList<IList<int>> Permute(int[] nums) {
    List<IList<int>> res = new List<IList<int>>();
    BackTrack(res, nums, new List<int>());
    return res;
}
public void BackTrack(List<IList<int>> res, int[] nums, List<int> element){
    if(element.Count == nums.Length){
        res.Add(new List<int>(element));
        return;
    }
    for(int i = 0; i < nums.Length; i++){
        if(element.Contains(nums[i])){
            continue;
        }
        element.Add(nums[i]);
        BackTrack(res, nums, element);
        element.RemoveAt(element.Count - 1);
    }
}