namespace Lesson15.Static
{
    public class Counter
    {
        private static int _globalCount = 0;
        private int _instanceCount = 0;

        public static int GetGlobalCount () => _globalCount;

        public void Increment ()
        {
            _instanceCount++;
            _globalCount++;
        }

        public int GetInstanceCount () => _instanceCount;
    }
}
