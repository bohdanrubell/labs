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
}