using System.Collections.Generic;

namespace BinaryLogicFunctions
{
    public interface IFunctionContainer
    {
        void AddFunction(IBinaryLogicFunction function);
        void RemoveFunctionAt(int index);
        void DisplayFunctions();

        int Count { get; }
        List<IBinaryLogicFunction> Functions { get; }
    }
}
