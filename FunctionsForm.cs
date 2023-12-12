using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BinaryLogicFunctions
{
    public partial class FunctionsForm : Form
    {
        private FunctionContainer functionContainer;

        public FunctionsForm()
        {
            InitializeComponent();
            functionContainer = new FunctionContainer();
            InitializeComboBoxes();
        }  


        private void InitializeComboBoxes()
        {
            List<string> booleanValues1 = new List<string> { "True", "False" };
            firstOperandComboBox.DataSource = booleanValues1;
            List<string> booleanValues2 = new List<string> { "True", "False" };
            secondOperandComboBox.DataSource = booleanValues2;

            List<string> binaryFunctions = new List<string> { "AND", "OR", "XOR", "NOT" };
            functionComboBox.DataSource = binaryFunctions;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            bool firstOperand = bool.Parse(firstOperandComboBox.SelectedItem.ToString());
            bool secondOperand = bool.Parse(secondOperandComboBox.SelectedItem.ToString());
            string selectedFunction = functionComboBox.SelectedItem.ToString();

            BinaryLogicFunction function = CreateFunction(selectedFunction);

            bool result = function.Evaluate(firstOperand, secondOperand);

            resultLabel.Text = $"Result: {result}";

            string functionInfo = $"{function.GetType().Name}: {firstOperand} {selectedFunction} {secondOperand} = {result}";
            listBoxResults.Items.Add(functionInfo);

            functionContainer.AddFunction(function);
        }

        private BinaryLogicFunction CreateFunction(string functionName)
        {
            switch (functionName)
            {
                case "AND":
                    return new ANDFunction();
                case "OR":
                    return new ORFunction();
                case "XOR":
                    return new XORFunction();
                case "NOT":
                    return new NOTFunction();
                default:
                    throw new ArgumentException("Invalid function name");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxResults.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < functionContainer.Count)
            {
                functionContainer.RemoveFunctionAt(selectedIndex);
                listBoxResults.Items.RemoveAt(selectedIndex);
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var function in functionContainer.Functions)
            {
                listBoxResults.Items.Add(function.GetType().Name);
            }
        }
    }
} 

