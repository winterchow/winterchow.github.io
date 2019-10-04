public double CalaAngle(double hour, double min){
    if(hour < 0 || min < 0 || hour > 12 || min > 60){
        return -1;
        throw new System.Exception("wrong input");
    }
    if(hour == 12){
        hour = 0;
    }
    if(min == 60){
        min = 0;
    }
    double hourAngle = 0.5 * (hour * 60 + min);
    double minAngle = 6 * min;
    double angle = Math.Abs(hourAngle - minAngle);
    angle = Math.Min(360 - angle, angle);
    
    return angle;
}