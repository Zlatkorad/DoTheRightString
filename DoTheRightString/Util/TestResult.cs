namespace DoTheRightString.Util
{
    /// <summary>
    /// Provides test result values of String manipulation tests.
    /// </summary>
    public class TestResult
    {
        private ulong _testStart;
        private ulong _testFinish;

        /// <summary>
        /// Difference in finished time and starting time, in miliseconds.
        /// </summary>
        public ulong TestTimeInMiliseconds
        {
            get
            {
                return _testFinish - _testStart;
            }
        }

        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        public TestResult(ulong start, ulong finish)
        {
            _testStart = start;
            _testFinish = finish;
        }
    }
}
