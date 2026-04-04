using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProj
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Replicates the .NET 10 Shuffle functionality for .NET 9.
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random? random = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            // Use Random.Shared if no specific random instance is provided
            var rng = random ?? Random.Shared;

            // We must buffer the collection to shuffle it
            var buffer = source.ToArray();

            for (int i = buffer.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                // Modern C# tuple swap
                (buffer[i], buffer[j]) = (buffer[j], buffer[i]);
            }

            foreach (var item in buffer)
            {
                yield return item;
            }
        }
    }
}
