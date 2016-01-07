using System;
namespace ClassLibrary1
{
    public class calNumber
    {
        protected double x;
        public virtual string cal(double first, double second)
        {
            return null;
        }

    }

    public class calAdd : calNumber
    {
        public void test()
        { }
        public override string cal(double first, double second)
        {
            x = first + second;
            return x + "";
        }
    }
    public class calMinus : calNumber
    {
        public override string cal(double first, double second)
        {
            x = first - second;
            return x + "";
        }
    }

    public class calMultiply : calNumber
    {
        public override string cal(double first, double second)
        {
            x = first * second;
            return x + "";
        }

    }

    public class calDivide : calNumber
    {
        public override string cal(double first, double second)
        {
            x = first / second;
            return x + "";
        }
    }
}





