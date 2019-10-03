private string[] Mapping = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
public IList<string> LetterCombinations(string digits){
    List<string> res = new List<string>();
    if(digits.Length == 0){
        return res;
    }
    BackTrack(res, digits, string.Empty, 0);
    return res;
}
public void BackTrack(List<string> res, string digits, string element, int index){
    if(element.Length == digits.Length){
        res.Add(element);
        return;
    }
    string temp = Mapping[digits[index] - '0'];
    for(int i = 0; i < temp.Length; i++){
        BackTrack(res, digits, element + temp[i], index + 1);
    }
}