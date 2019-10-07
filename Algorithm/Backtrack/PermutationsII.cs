public IList<IList<int>> PermuteUnique(int[] nums){
    List<IList<int>> res = new List<IList<int>>();
    Array.Sort(nums);
    bool[] used = new bool[nums.Length];
    BackTrack(res, nums, used, new List<int>());
    return res;
}
public void BackTrack(List<IList<int>> res, int[] nums, bool[] used, List<int> element){
    if(element.Count() == nums.Length){
        res.Add(new List<int>(element));
    }
    for(int i = 0; i < nums.Length; i++){
        if(i > 0 && nums[i] == nums[i - 1] && !used[i - 1]){
            continue;
        }
        if(used[i]){
            continue;
        }
        element.Add(nums[i]);
        used[i] = true;
        BackTrack(res, nums, used, element);
        used[i] = false;
        element.RemoveAt(element.Count() - 1);
    }
}