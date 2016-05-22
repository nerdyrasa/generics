using System.Collections.Generic;

namespace DataStructures
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        IEnumerable<TOutput> AsEnumerableOf<TOutput>();
        T Read();
    }
}
