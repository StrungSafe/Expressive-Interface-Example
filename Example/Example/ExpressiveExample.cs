namespace Example
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class ExpressiveExample
    {
        public ExpressiveExample()
        {
            Names = new ReadOnlyCollection<string>(new List<string> { "John", "Mohammad" });
        }

        public IReadOnlyCollection<string> Names { get; }
    }
}