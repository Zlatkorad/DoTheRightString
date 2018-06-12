namespace DoTheRightString.Util
{
    /// <summary>
    /// Provides test result values of String manipulation tests.
    /// </summary>
    public class TestResult
    {
        private ulong _testStart;
        private ulong _testFinish;

        public ulong TestTimeInMiliseconds
        {
            get
            {
                return _testFinish - _testStart;
            }
        }

        public TestResult(ulong start, ulong finish)
        {
            _testStart = start;
            _testFinish = finish;
        }
    }
}
