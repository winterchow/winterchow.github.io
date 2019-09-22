public IList<IList<int>> Subsets(int[] nums) {
    List<IList<int>> res = new List<IList<int>>();
    BackTrack(res, nums, new List<int>(), 0);
    return res;
}
public void BackTrack(List<IList<int>> res, int[] nums, List<int> element, int index){
    res.Add(new List<int>(element));
    for(int i = index; i < nums.Length; i++){
        element.Add(nums[i]);
        BackTrack(res, nums, element, i + 1);
        element.RemoveAt(element.Count - 1);
    }
}