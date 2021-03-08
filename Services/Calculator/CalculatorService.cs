using Calculator.Consts;
using System;
using System.Text;

namespace Calculator.Services.Calculator
{
    public class CalculatorService : ICalculatorService
    {
        private readonly StringBuilder inputBuilder;

        private string operand1;
        private char operation;

        public string Input { get; private set; }
        public string StoredNumber { get; private set; }

        public CalculatorService()
        {
            inputBuilder = new StringBuilder();
        }

        public void AddDigitToInput(char digit)
        {
            if (!char.IsDigit(digit))
            {
                return;
            }

            inputBuilder.Append(digit);
            SetInputValueFromBuilder();
        }

        public void SetOperator(char operatorDigit)
        {
            if (!OperatorConsts.GetOperators().Contains(operatorDigit) || operation != default(char) || string.IsNullOrWhiteSpace(Input))
            {
                return;
            }

            operation = operatorDigit;
            inputBuilder.Append(operatorDigit);
            operand1 = Input;
            SetInputValueFromBuilder();
        }

        public void RemoveLastDigitFromInput()
        {
            if (inputBuilder.Length == default(int))
            {
                return;
            }

            if (OperatorConsts.GetOperators().Contains(inputBuilder[inputBuilder.Length - 1]))
            {
                SetDefaultOperation();
            }

            inputBuilder.Remove(inputBuilder.Length - 1, 1);
            SetInputValueFromBuilder();
        }

        public void ClearInput()
        {
            inputBuilder.Clear();
            SetDefaultOperation();
            operand1 = string.Empty;
            SetInputValueFromBuilder();
        }

        public bool Calculate()
        {
            if (string.IsNullOrWhiteSpace(operand1))
            {
                return false;
            }

            var operand2 = Input.Substring(operand1.Length + 1);

            if (string.IsNullOrWhiteSpace(operand2))
            {
                return false;
            }

            var operand2Number = Convert.ToDouble(operand2);
            var operand1Number = Convert.ToDouble(operand1);
            double operationResult = 0;

            if (operation == OperatorConsts.Addition)
            {
                operationResult = operand1Number + operand2Number;
            }
            else if (operation == OperatorConsts.Substruction)
            {
                operationResult = operand1Number - operand2Number;
            }
            else if (operation == OperatorConsts.Multiplication)
            {
                operationResult = operand1Number * operand2Number;
            }
            else if (operation == OperatorConsts.Division)
            {
                if (operand2Number != 0)
                {
                    operationResult = operand1Number / operand2Number;
                }
            }

            inputBuilder.Clear();
            inputBuilder.Append(operationResult.ToString());
            SetInputValueFromBuilder();
            SetDefaultOperation();
            operand1 = string.Empty;

            return true;
        }

        public void StoreNumber()
        {
            if (!string.IsNullOrWhiteSpace(operand1))
            {
                StoredNumber = operand1;
            }

            StoredNumber = Input;
            inputBuilder.Clear();
            SetInputValueFromBuilder();
        }

        public void UnStoreNumber()
        {
            inputBuilder.Append(StoredNumber);
            SetInputValueFromBuilder();
        }
        public void ClearStoredNumber()
        {
            StoredNumber = string.Empty;
        }

        private void SetInputValueFromBuilder()
        {
            Input = inputBuilder.ToString();
        }

        private void SetDefaultOperation()
        {
            operation = default(char);
        }
    }
}