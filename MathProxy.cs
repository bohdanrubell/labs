
namespace program;

public class MathProxy : IMath
{
    private IMath _math;

    public MathProxy()
    {
        Math m = new Math();
        _math = m;
    }
    
    public double add(double f_num, double s_num)
    {
        return _math.add(f_num,s_num);
    }

    public double sub(double f_num, double s_num)
    {
        return _math.sub(f_num, s_num);
    }
    
    public double mul(double f_num, double s_num)
    {
        return _math.mul(f_num,s_num);
    }
    
    public double div(double f_num, double s_num)
    {
        return _math.div(f_num,s_num);
    }
    
    public double root(double number) {
        return _math.root(number);
    }
}