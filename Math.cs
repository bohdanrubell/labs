namespace program;

public class Math : IMath
{
    public double add(double f_num, double s_num)
    {
        return f_num + s_num;
    }

    public double sub(double f_num, double s_num)
    {
        return f_num - s_num;
    }
    public double mul(double f_num, double s_num)
    {
        return f_num * s_num;
    }
    public double div(double f_num, double s_num)
    {
        return f_num / s_num;
    }

    public double root(double number)
    {
        return System.Math.Sqrt(number);
    }
}