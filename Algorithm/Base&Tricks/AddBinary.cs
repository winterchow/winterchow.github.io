public string AddBinary(string a, string b) {
    string res = string.Empty;
    int m = a.Length - 1, n = b.Length - 1, carry = 0;
    while(m >= 0 || n >= 0){
        int p = m >= 0 ? a[m--] - '0' : 0;
        int q = n >= 0 ? b[n--] - '0' : 0;
        int sum = p + q + carry;
        res = (sum % 2).ToString() + res;
        carry = sum / 2;
    }        

    return carry == 1 ? '1' + res : res;
}