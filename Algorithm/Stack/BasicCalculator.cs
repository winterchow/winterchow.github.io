//1. only exist +, - and ().
public int Calculate(string s) {
    Stack<int> stack = new Stack<int>();
    int res = 0; int sign = 1;
    for(int i = 0; i < s.Length; i++){
        if(s[i] - '0' >= 0 && s[i] - '0' <= 9){
            int num = 0;
            while(i < s.Length && s[i] >= '0'){
                num = num * 10 + (s[i] - '0');
                i++;
            }
            res += sign * num;
            i--;
        }
        if(s[i] == '+'){
            sign = 1;
        }
        if(s[i] == '-'){
            sign = -1;
        }
        if(s[i] == '('){
            stack.Push(res);
            stack.Push(sign);
            res = 0;
            sign = 1;
        }
        if(s[i] == ')'){
            res *= stack.Peek();
            stack.Pop();
            res += stack.Peek();
            stack.Pop();
        }
    }

    return res;
}

//2. only exist +, -, *, /.
public int Calculate(string s) {
    int res = 0, num = 0;
    char op = '+';
    Stack<int> stack = new Stack<int>();
    for(int i = 0; i < s.Length; i++){
        if(s[i] - '0' <= 9 && s[i] - '0' >= 0){
            num = num * 10 + (s[i] - '0');
        }
        if((s[i] < '0' && s[i] != ' ') || i == s.Length - 1){
            if(op == '+'){
            stack.Push(num);
            }
            if(op == '-'){
                stack.Push(num * -1);
            }
            if(op == '*' || op == '/'){
                int temp = op == '*' ? stack.Peek() * num : stack.Peek() / num;
                stack.Pop();
                stack.Push(temp);
            }
            op = s[i];
            num = 0;
        }
        
    }
    while(stack.Count != 0){
        res += stack.Peek();
        stack.Pop();
    }

    return res;
}