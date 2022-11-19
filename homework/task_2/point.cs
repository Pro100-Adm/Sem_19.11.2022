namespace pointNamespace;
struct Point{
    double x;
    double y;
    double z;

    public Point(double x, double y, double z){
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double GetDistance(Point other){
        return Math.Sqrt(Math.Pow(other.x-this.x, 2)+Math.Pow(other.y-this.y, 2)+Math.Pow(other.z-this.z, 2));
    }
};