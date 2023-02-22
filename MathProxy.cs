namespace program;

public class MathProxy : IMath, IRoot
{
    private static MathProxy _math;
    private Math Obj_math = new Math();
    private MathProxy() { }

   
    public static MathProxy GetMath()
    {
        if (_math == null)
        {
            _math = new MathProxy();
        }
        return _math;
    }

    
    
    public double add(double f_num, double s_num)
    {
        return Obj_math.add(f_num,s_num);
    }

    public double sub(double f_num, double s_num)
    {
        return Obj_math.sub(f_num, s_num);
    }
    
    public double mul(double f_num, double s_num)
    {
        return Obj_math.mul(f_num,s_num);
    }
    
    public double div(double f_num, double s_num)
    {
        return Obj_math.div(f_num, s_num);
    }
    
    public double root(double number) {
        return Obj_math.root(number);
    }
}