// If x < 0, 反码 + 补码
// Below x > 0
// If x == 0, return "0"
public string Int2Binary(int x){
    string s = string.Empty; 
    int part = 0;
    while(x > 0){
        part = x % 2;
        x /= 2;
        s = part.ToString() + s;
    }

    return s;
}