namespace BinaryLogicFunctions
{
    public interface IBinaryLogicFunction
    {
        bool Evaluate(bool input1, bool input2);

        void DisplayFunctionInfo();
    }
}
