namespace AdaptiveCodeTraining
{
    internal class Duck
    {
        public Duck()
        {
        }
        public DuckEnumerator GetEnumerator()
        {
            return new DuckEnumerator();
        }
    }
}