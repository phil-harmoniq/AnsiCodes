namespace AnsiCodes
{
    /// <summary>
    /// Container class for for storing ANSI codes.
    /// </summary>
    public sealed class AnsiCode
    {
        private string _code;
        internal AnsiCode(string code)
        {
            if (WindowsHelper.IsWindows)
            {
                if (WindowsHelper.AnsiEnabled)
                {
                    _code = code;
                }
                else if (!WindowsHelper.AnsiEnableAttempted)
                {
                    if (WindowsHelper.Enable())
                    {
                        _code = code;
                    }
                }
            }
            else
            {
                _code = code;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() { return _code; }
    }
}