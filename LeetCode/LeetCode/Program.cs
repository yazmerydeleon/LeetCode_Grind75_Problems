namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses parentheses = new ValidParentheses();
            bool result = parentheses.IsValid("(){}}{");
            Console.WriteLine($"Is Valid: {result}");

        }
    }
}