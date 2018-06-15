namespace AnsiCodes
{
    public class AnsiCode
    {
        public string Code { get; private set; }
        internal AnsiCode(string code) { Code = code; }
        public override string ToString() { return Code; }
    }
}