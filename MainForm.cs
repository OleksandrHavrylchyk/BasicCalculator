using Calculator.Consts;
using Calculator.Services.Calculator;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private readonly ICalculatorService calculatorService;
        public MainForm(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
            InitializeComponent();
        }

        private void digit1_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.One);
            SetInputValue(calculatorService.Input);
        }

        private void digit2_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Two);
            SetInputValue(calculatorService.Input);
        }

        private void digit3_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Three);
            SetInputValue(calculatorService.Input);
        }

        private void digit4_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Four);
            SetInputValue(calculatorService.Input);
        }

        private void digit5_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Five);
            SetInputValue(calculatorService.Input);
        }

        private void digit6_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Six);
            SetInputValue(calculatorService.Input);
        }

        private void digit7_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Seven);
            SetInputValue(calculatorService.Input);
        }

        private void digit8_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Eight);
            SetInputValue(calculatorService.Input);
        }

        private void digit9_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Nine);
            SetInputValue(calculatorService.Input);
        }

        private void digit0_Click(object sender, System.EventArgs e)
        {
            calculatorService.AddDigitToInput(DigitConsts.Zero);
            SetInputValue(calculatorService.Input);
        }

        private void ce_Click(object sender, System.EventArgs e)
        {
            calculatorService.RemoveLastDigitFromInput();
            SetInputValue(calculatorService.Input);
        }

        private void c_Click(object sender, System.EventArgs e)
        {
            calculatorService.ClearInput();
            SetInputValue(calculatorService.Input);
        }

        private void plus_Click(object sender, System.EventArgs e)
        {
            calculatorService.SetOperator(OperatorConsts.Addition);
            SetInputValue(calculatorService.Input);
        }

        private void minus_Click(object sender, System.EventArgs e)
        {
            calculatorService.SetOperator(OperatorConsts.Substruction);
            SetInputValue(calculatorService.Input);
        }

        private void star_Click(object sender, System.EventArgs e)
        {
            calculatorService.SetOperator(OperatorConsts.Multiplication);
            SetInputValue(calculatorService.Input);
        }

        private void divide_Click(object sender, System.EventArgs e)
        {
            calculatorService.SetOperator(OperatorConsts.Division);
            SetInputValue(calculatorService.Input);
        }

        private void SetInputValue(string value)
        {
            textBox1.Text = value;
        }

        private void equal_Click(object sender, System.EventArgs e)
        {
            if(!calculatorService.Calculate())
            {
                return;
            }

            SetInputValue(calculatorService.Input);
        }

        private void ms_Click(object sender, System.EventArgs e)
        {
            calculatorService.StoreNumber();
            SetInputValue(calculatorService.Input);
        }

        private void mr_Click(object sender, System.EventArgs e)
        {
            calculatorService.UnStoreNumber();
            SetInputValue(calculatorService.Input);
        }

        private void mc_Click(object sender, System.EventArgs e)
        {
            calculatorService.ClearStoredNumber();
            SetInputValue(calculatorService.Input);
        }
    }
}