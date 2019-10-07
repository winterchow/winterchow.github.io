public int Binary2Int(string binary){
    int res = 0, val = 0;
    for(int i = binary.Length - 1; i >= 0; i--){
        val = Int32.Parse(binary[i].ToString());
        if(val == 0){
            continue;
        }
        if(val == 1){
            res += Math.Pow(2, binary.Length - i - 1);
        }
        // if val > 1, invalid.
    }

    return res;
}