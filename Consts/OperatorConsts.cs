using System.Collections.Generic;

namespace Calculator.Consts
{
    public static class OperatorConsts
    {
        public const char Addition = '+';
        public const char Substruction = '-';
        public const char Multiplication = '*';
        public const char Division = '/';
        public static List<char> GetOperators()
        {
            return new List<char>()
            {
                Addition,
                Substruction,
                Multiplication,
                Division
            };
        }
    }
}