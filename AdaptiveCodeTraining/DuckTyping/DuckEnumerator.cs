namespace AdaptiveCodeTraining
{
    public class DuckEnumerator
    {
        int i = 0;

        public bool MoveNext()
        {
            return i++ < 10;
        }

        public int Current
        {
            get
            {
                return i;
            }
        }
    }
}