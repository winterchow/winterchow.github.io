public int String2Int(string s){
    long res = 0, carry = 1;
    if(s.Length == 0){
        throw new System.Exception("null");
    }
    if(s.Length == 1 && (s[0] - '0' < 0 && s[0] - '0' > 9)){
        throw new System.Exception("invalid");
    }
    if(s[0] == '+' || s[0] == '-'){
        for(int i = s.Length - 1; i > 0; i--){
            if(s[i] - '0' >= 0 && s[i] - '0' <= 9){
                res += (s[i] - '0') * carry;
                carry *= 10;
            }
            else{
                throw;
            }
        }

        res = s[0] == '+' ? res : res * -1;
    }
    else{
        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] - '0' >= 0 && s[i] - '0' <= 9){
                res += (s[i] - '0') * carry;
                carry *= 10;
            }
            else{
                throw;
            }
        }
    }

    return (int)res;
}