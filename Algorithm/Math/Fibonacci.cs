// Solution 1
public int Fibonacci(int n){
    if(n < 2){
        return n;
    }

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

// Solution 2
public int FibonacciDP(int n){
    if(n < 2){
        return n;
    }
    int[] cache = new int[n + 1];
    cache[0] = 0;
    cache[1] = 1;
    for(int i = 2; i <= n; i++){
        cache[i] = cache[i - 1] + cache[i - 2];
    }

    return cache[n];
}

// Solution 3
public int FibonacciIteration(int n){
    if(n < 2){
        return n;
    }
    int sum = 1;
    int pre = 0;
    int cur = 1;
    while(n > 1){
        sum = pre + cur;
        pre = cur;
        cur = sum;
        n--;
    }

    return cur;
}