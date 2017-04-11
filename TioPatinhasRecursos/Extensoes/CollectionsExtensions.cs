using System;
using System.Collections.Generic;
using System.Linq;

namespace TioPatinhasRecursos.Extensoes
{
    public static class CollectionsExtensions
    {
        public static IEnumerable<T[]> ChunkBy<T>(this IEnumerable<T> source, int chunkSize)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (chunkSize < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(chunkSize), "chunkSize must be positive");
            }

            var array = source as T[] ?? source.ToArray();
            for (var i = 0; i < array.Length; i += chunkSize)
            {
                var chunk = new T[Math.Min(chunkSize, array.Length - i)];
                Array.Copy(array, i, chunk, 0, chunk.Length);
                yield return chunk;
            }
        }
    }
}