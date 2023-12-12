using System;

namespace BinaryLogicFunctions
{
    public abstract class BinaryLogicFunction : IBinaryLogicFunction
    {
        public BinaryLogicFunction() { }

        public abstract bool Evaluate(bool input1, bool input2);

        public void DisplayFunctionInfo()
        {
            Console.WriteLine($"Function Type: {GetType().Name}");
        }
    }


    public class ANDFunction : BinaryLogicFunction
    {
        public ANDFunction() { }

        public override bool Evaluate(bool input1, bool input2)
        {
            return input1 && input2;
        }
    }

    public class ORFunction : BinaryLogicFunction
    {
        public ORFunction() { }

        public override bool Evaluate(bool input1, bool input2)
        {
            return input1 || input2;
        }
    }

    public class XORFunction : BinaryLogicFunction
    {
        public XORFunction() { }

        public override bool Evaluate(bool input1, bool input2)
        {
            return input1 ^ input2;
        }
    }

    public class NOTFunction : BinaryLogicFunction
    {
        public NOTFunction() { }

        public override bool Evaluate(bool input1, bool input2)
        {
            return !input1;
        }
    }

}
