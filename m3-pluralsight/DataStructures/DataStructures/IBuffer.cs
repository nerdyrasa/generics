using System.Collections.Generic;

namespace DataStructures
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }

        T Read();
        void Write(T value);
    }
}