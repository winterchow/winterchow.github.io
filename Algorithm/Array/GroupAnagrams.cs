public IList<IList<string>> GroupAnagrams(string[] strs){
    List<IList<string>> res = new List<IList<string>>();
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    foreach(var str in strs){
        string key = string.Empty;
        int[] temp = new int[26];
        foreach(var x in str){
            temp[x - 'a']++;
        }
        foreach(var i in temp){
            key += i.ToString();
        }
        if(dict.ContainsKey(key)){
            dict[key].Add(str);
        }
        else{
            dict.Add(key, new List<string>(){ str });
        }
    }

    foreach(var k in dict){
        res.Add(k.Value);
    }

    return res;
}