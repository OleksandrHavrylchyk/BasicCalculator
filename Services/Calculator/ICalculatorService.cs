namespace Calculator.Services.Calculator
{
    public interface ICalculatorService
    {
        string Input { get; }
        string StoredNumber { get; }
        void AddDigitToInput(char digit);
        void RemoveLastDigitFromInput();
        void ClearInput();
        void SetOperator(char operatorDigit);
        bool Calculate();
        void StoreNumber();
        void UnStoreNumber();
        void ClearStoredNumber();
    }
}