public double MyPow(double x, int n){
    if(n == 0){
        return 1;
    }
    if(n < 0){
        return n == Int32.MinValue ? MyPow(x, Int32.MinValue + 1) / x : MyPow(1 / x, -n);
    }

    return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
}