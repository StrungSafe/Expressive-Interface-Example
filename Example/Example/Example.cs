namespace Example
{
    using System.Collections.Generic;

    public class Example
    {
        private readonly IList<string> names;

        public Example()
        {
            names = new List<string> { "John", "Mohammad" };
        }

        public IList<string> Names
        {
            get
            {
                var copy = new string[names.Count];
                names.CopyTo(copy, 0);
                return copy;
            }
        }
    }
}