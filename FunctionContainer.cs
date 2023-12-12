using System;
using System.Collections.Generic;

namespace BinaryLogicFunctions
{
    public class FunctionContainer : IFunctionContainer
    {
        private List<IBinaryLogicFunction> functions;

        public FunctionContainer()
        {
            functions = new List<IBinaryLogicFunction>();
        }

        public void AddFunction(IBinaryLogicFunction function)
        {
            functions.Add(function);
        }

        public void RemoveFunctionAt(int index)
        {
            if (index >= 0 && index < functions.Count)
            {
                functions.RemoveAt(index);
            }
        }

        public void DisplayFunctions()
        {
            foreach (var function in functions)
            {
                Console.WriteLine(function.GetType().Name);
            }
        }

    
        public int Count
        {
            get { return functions.Count; }
        }

        public List<IBinaryLogicFunction> Functions
        {
            get { return functions; }
        }
    }
}
