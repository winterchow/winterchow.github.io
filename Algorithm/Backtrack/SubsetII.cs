public IList<IList<int>> SubsetsWithDup(int[] array){
    List<IList<int>> res = new List<IList<int>>();
    Array.Sort(array);
    BackTrack(res, array, new List<int>(), 0);
    return res;
}
public void BackTrack(List<IList<int>> res, int[] array, List<int> element, int index){
    res.Add(new List<int>(element));
    for(int i = index; i < array.Length; i++){
        if(i > index && array[i] == array[i - 1]){
            continue;
        }
        element.Add(array[i]);
        BackTrack(res, array, element, i + 1);
        element.RemoveAt(element.Count() - 1);
    }
}